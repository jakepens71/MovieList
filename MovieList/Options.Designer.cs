namespace MovieList
{
    partial class Options
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdMoviesWanted = new System.Windows.Forms.RadioButton();
            this.rdMoviesObtained = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdMoviesWanted);
            this.groupBox1.Controls.Add(this.rdMoviesObtained);
            this.groupBox1.Location = new System.Drawing.Point(25, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Startup";
            // 
            // rdMoviesWanted
            // 
            this.rdMoviesWanted.AutoSize = true;
            this.rdMoviesWanted.Location = new System.Drawing.Point(52, 65);
            this.rdMoviesWanted.Name = "rdMoviesWanted";
            this.rdMoviesWanted.Size = new System.Drawing.Size(100, 17);
            this.rdMoviesWanted.TabIndex = 1;
            this.rdMoviesWanted.TabStop = true;
            this.rdMoviesWanted.Text = "Movies Wanted";
            this.rdMoviesWanted.UseVisualStyleBackColor = true;
            // 
            // rdMoviesObtained
            // 
            this.rdMoviesObtained.AutoSize = true;
            this.rdMoviesObtained.Location = new System.Drawing.Point(52, 30);
            this.rdMoviesObtained.Name = "rdMoviesObtained";
            this.rdMoviesObtained.Size = new System.Drawing.Size(105, 17);
            this.rdMoviesObtained.TabIndex = 0;
            this.rdMoviesObtained.TabStop = true;
            this.rdMoviesObtained.Text = "Movies Obtained";
            this.rdMoviesObtained.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RadioButton rdMoviesWanted;
        private System.Windows.Forms.RadioButton rdMoviesObtained;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}