namespace Deneb
{
    partial class AddVariationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTime = new System.Windows.Forms.Label();
            this.labelVariation = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxVariation = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(15, 22);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(44, 13);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "Time (s)";
            // 
            // labelVariation
            // 
            this.labelVariation.AutoSize = true;
            this.labelVariation.Location = new System.Drawing.Point(15, 58);
            this.labelVariation.Name = "labelVariation";
            this.labelVariation.Size = new System.Drawing.Size(77, 13);
            this.labelVariation.TabIndex = 1;
            this.labelVariation.Text = "Variation (pcm)";
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(122, 19);
            this.textBoxTime.MaxLength = 2;
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(83, 20);
            this.textBoxTime.TabIndex = 2;
            this.textBoxTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTime_KeyPress);
            // 
            // textBoxVariation
            // 
            this.textBoxVariation.Location = new System.Drawing.Point(122, 55);
            this.textBoxVariation.MaxLength = 4;
            this.textBoxVariation.Name = "textBoxVariation";
            this.textBoxVariation.Size = new System.Drawing.Size(83, 20);
            this.textBoxVariation.TabIndex = 3;
            this.textBoxVariation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxVariation_KeyDown);
            this.textBoxVariation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVariation_KeyPress);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(122, 100);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(83, 27);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(18, 101);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(83, 26);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // AddVariationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(219, 140);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxVariation);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.labelVariation);
            this.Controls.Add(this.labelTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddVariationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add a Variation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelVariation;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxVariation;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}