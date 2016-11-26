using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Deneb
{
    /// <summary>
    /// Ensemble des variations de réactivité sur toute l'expérience
    /// La liste 'items', dans l'ordre, les différentes variations de réactivité.
    /// Les variations de réactivité sont toujours des rampes, un créneau est une rampe de longueur 0
    /// Ce choix permet de simplifier le design du code (le calcul de la valeur à un instant donné est plus simple) 
    /// ainsi que l'interface de création de l'expérience (les variations sont des rectangles qui peuvent être déplacés et redimensionnés à la souris)
    /// </summary>
    [Serializable]
    public class CriticalityVariations : List<CriticalityVariation>
    {

        [Serializable]
        public struct structCharacteristicValues 
        {
            public double initial;
            public double final;
            public double max;
            public double min;

            public structCharacteristicValues(double initialValue)
            {
                // Comme les variations sont donnés dans l'ordre, le calcul des valeurs caractéristiques se fait de manière linéaire
                // Ce calcul est fait dans la méthode add
                // TODO : Il peut également être fait dans une fonction de recalcul après modification de l'ordre des variations.
                max = initialValue;
                min = initialValue;
                initial = initialValue;
                final = initialValue;
            }
        }

        private structCharacteristicValues characteristicValues;
        public structCharacteristicValues CharacteristicValues
        {
            get { return characteristicValues; }
        }

        private double timeSpan;
        public double TimeSpan
        {
            get { return timeSpan; }
        }


        /// <summary>
        /// Constructeur avec une valeur initiale non nulle
        /// </summary>
        /// <param name="initialValue"></param>
        public CriticalityVariations(double initialValue)
        {
            characteristicValues = new structCharacteristicValues(initialValue);
        }

        /// <summary>
        /// Constructeur vide
        /// </summary>
        public CriticalityVariations()
            : this(100)
        {
            // On ajoute une variation par défaut

            this.AddVariation(new CriticalityVariation(1, -100));
            this.AddVariation(new CriticalityVariation(10, 200));
            this.AddVariation(new CriticalityVariation(10, 0));
            this.AddVariation(new CriticalityVariation(0, -200));
            this.AddVariation(new CriticalityVariation(10, 200));
            this.AddVariation(new CriticalityVariation(5, 0));
        }
        public CriticalityVariations(CriticalityVariations criticalityVariations)
        {
            characteristicValues = new structCharacteristicValues(criticalityVariations.CharacteristicValues.initial);
            foreach (CriticalityVariation v in criticalityVariations)
                this.AddVariation(v);
        }


        [OnDeserialized]
        private void OnDeserializedMethod(StreamingContext context)
        {
            double time = 0;
            double rho = characteristicValues.initial;

            foreach (CriticalityVariation cv in this)
            {
                time += cv.length;
                rho += cv.variation;
            }
        }




        /// <summary>
        /// Ajoute une variation et calcule les valeurs caractéristiques de l'expérience
        /// </summary>
        /// <param name="cv">Variation de réactivité</param>
        /// 
        protected void AddVariation(CriticalityVariation cv) 
        {
            base.Add(cv);
            timeSpan += cv.length;
            characteristicValues.final += cv.variation;
            characteristicValues.max = Math.Max(characteristicValues.max, characteristicValues.final);
            characteristicValues.min = Math.Min(characteristicValues.min, characteristicValues.final);
        }


        public void CalculateCharacteristicValues(double initialValue)
        {
            characteristicValues = new structCharacteristicValues(initialValue);
            timeSpan = 0;
            foreach (CriticalityVariation cv in this)
            {
                timeSpan += cv.length;
                characteristicValues.final += cv.variation;
                characteristicValues.max = Math.Max(characteristicValues.max, characteristicValues.final);
                characteristicValues.min = Math.Min(characteristicValues.min, characteristicValues.final);
            }
        }

        public void CalculateCharacteristicValues()
        {
            this.CalculateCharacteristicValues(characteristicValues.initial);
        }


        /// <summary>
        /// Renvoie la réactivité en fonction du temps
        /// </summary>
        /// <param name="time">temps en secondes</param>
        /// <returns>criticité en pcm</returns>
        public double criticality(double time)
        {
            double t = 0;               // valeur du temps
            double instantRho = characteristicValues.initial;  // valeur de réactivité

            foreach (CriticalityVariation v in this)
            {
                if (time > t + v.length)
                {   // S'il reste des variation, on calcule la valeur en fin de la variation
                    t += v.length;
                    instantRho += v.variation;
                }
                else
                {   //Si on a dépassé la dernière variation, on calcule la valeur intermédiaire                    
                    if (v.length == 0)
                        instantRho += v.variation;
                    else
                        instantRho += v.variation * (time - t) / v.length;
                    return instantRho / 100000;
                }
            }
            return instantRho / 100000;
        }
    }
}
