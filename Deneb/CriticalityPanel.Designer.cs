namespace Deneb
{
    partial class CriticalityPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddVariationToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem DeleteVariationToolStripMenu;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.components = new System.ComponentModel.Container();

            // 
            // CriticalityPanel
            // 
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddVariationToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteVariationToolStripMenu = new System.Windows.Forms.ToolStripMenuItem(); 
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Size = new System.Drawing.Size(518, 204);
            this.ResumeLayout(false);

            this.contextMenuStrip1.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddVariationToolStripMenu,
            this.DeleteVariationToolStripMenu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(228, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // AddVariationToolStripMenu
            // 
            this.AddVariationToolStripMenu.Name = "AddVariationToolStripMenu";
            this.AddVariationToolStripMenu.Size = new System.Drawing.Size(227, 22);
            this.AddVariationToolStripMenu.Text = "Add a variation (on the right)";
            this.AddVariationToolStripMenu.Click += new System.EventHandler(this.AddVariationToolStripMenu_Click);
            // 
            // DeleteVariationToolStripMenu
            // 
            this.DeleteVariationToolStripMenu.Name = "DeleteVariationToolStripMenu";
            this.DeleteVariationToolStripMenu.Size = new System.Drawing.Size(227, 22);
            this.DeleteVariationToolStripMenu.Text = "Delete Variation (the left one)";
            this.DeleteVariationToolStripMenu.Click += new System.EventHandler(this.DeleteVariationToolStripMenu_Click);

            this.contextMenuStrip1.ResumeLayout(false);

        }

        #endregion
    }
}
