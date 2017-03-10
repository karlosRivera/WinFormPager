namespace DataGridView_CS.ucControl
{
    partial class ButtonPager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlPager = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlPager
            // 
            this.pnlPager.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPager.Location = new System.Drawing.Point(0, 0);
            this.pnlPager.Name = "pnlPager";
            this.pnlPager.Size = new System.Drawing.Size(343, 26);
            this.pnlPager.TabIndex = 2;
            // 
            // ButtonPager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPager);
            this.Name = "ButtonPager";
            this.Size = new System.Drawing.Size(343, 26);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPager;
    }
}
