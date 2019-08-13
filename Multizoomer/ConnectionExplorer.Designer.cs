namespace Multizoomer
{
    partial class ConnectionExplorer
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
            this.imageExplorer1 = new Multizoomer.ImageExplorer();
            this.SuspendLayout();
            // 
            // imageExplorer1
            // 
            this.imageExplorer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageExplorer1.Location = new System.Drawing.Point(12, 12);
            this.imageExplorer1.Name = "imageExplorer1";
            this.imageExplorer1.Size = new System.Drawing.Size(776, 426);
            this.imageExplorer1.TabIndex = 0;
            // 
            // ConnectionExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imageExplorer1);
            this.Name = "ConnectionExplorer";
            this.Text = "Connection Explorer";
            this.Load += new System.EventHandler(this.ConnectionExplorer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ImageExplorer imageExplorer1;
    }
}

