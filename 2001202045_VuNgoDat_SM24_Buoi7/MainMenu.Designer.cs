
namespace _2001202045_VuNgoDat_SM24_Buoi7
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuB1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuB2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuB1_BTVN = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuB1,
            this.menuB2,
            this.menuB1_BTVN});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuB1
            // 
            this.menuB1.Name = "menuB1";
            this.menuB1.Size = new System.Drawing.Size(140, 24);
            this.menuB1.Text = "Quản Lý Sinh Viên";
            this.menuB1.Click += new System.EventHandler(this.menuB1_Click);
            // 
            // menuB2
            // 
            this.menuB2.Name = "menuB2";
            this.menuB2.Size = new System.Drawing.Size(115, 24);
            this.menuB2.Text = "Quản Lý Điểm";
            this.menuB2.Click += new System.EventHandler(this.menuB2_Click);
            // 
            // menuB1_BTVN
            // 
            this.menuB1_BTVN.Name = "menuB1_BTVN";
            this.menuB1_BTVN.Size = new System.Drawing.Size(86, 24);
            this.menuB1_BTVN.Text = "From Lớp";
            this.menuB1_BTVN.Click += new System.EventHandler(this.menuB1_BTVN_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_2001202045_VuNgoDat_SM24_Buoi7.Properties.Resources.e55dcfac8fb94fe716a8;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "Sảnh Chính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuB1;
        private System.Windows.Forms.ToolStripMenuItem menuB2;
        private System.Windows.Forms.ToolStripMenuItem menuB1_BTVN;
    }
}

