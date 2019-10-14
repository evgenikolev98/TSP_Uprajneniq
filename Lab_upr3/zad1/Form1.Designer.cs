namespace zad1
{
    partial class Form1
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
            this.математическиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.алгебраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тиКласToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.степенуванеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.миКласToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.съкратеноУмножениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.миКласToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.квадратноУравнениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.математическиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // математическиToolStripMenuItem
            // 
            this.математическиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.алгебраToolStripMenuItem});
            this.математическиToolStripMenuItem.Name = "математическиToolStripMenuItem";
            this.математическиToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.математическиToolStripMenuItem.Text = "Математически формули";
            // 
            // алгебраToolStripMenuItem
            // 
            this.алгебраToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тиКласToolStripMenuItem,
            this.миКласToolStripMenuItem,
            this.миКласToolStripMenuItem1,
            this.изходToolStripMenuItem});
            this.алгебраToolStripMenuItem.Name = "алгебраToolStripMenuItem";
            this.алгебраToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.алгебраToolStripMenuItem.Text = "Алгебра";
            // 
            // тиКласToolStripMenuItem
            // 
            this.тиКласToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.степенуванеToolStripMenuItem});
            this.тиКласToolStripMenuItem.Name = "тиКласToolStripMenuItem";
            this.тиКласToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.тиКласToolStripMenuItem.Text = "6-ти клас";
            // 
            // степенуванеToolStripMenuItem
            // 
            this.степенуванеToolStripMenuItem.Name = "степенуванеToolStripMenuItem";
            this.степенуванеToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.степенуванеToolStripMenuItem.Text = "Степенуване";
            this.степенуванеToolStripMenuItem.Click += new System.EventHandler(this.степенуванеToolStripMenuItem_Click);
            // 
            // миКласToolStripMenuItem
            // 
            this.миКласToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.съкратеноУмножениеToolStripMenuItem});
            this.миКласToolStripMenuItem.Name = "миКласToolStripMenuItem";
            this.миКласToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.миКласToolStripMenuItem.Text = "7-ми клас";
            // 
            // съкратеноУмножениеToolStripMenuItem
            // 
            this.съкратеноУмножениеToolStripMenuItem.Name = "съкратеноУмножениеToolStripMenuItem";
            this.съкратеноУмножениеToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.съкратеноУмножениеToolStripMenuItem.Text = "Съкратено умножение";
            this.съкратеноУмножениеToolStripMenuItem.Click += new System.EventHandler(this.съкратеноУмножениеToolStripMenuItem_Click);
            // 
            // миКласToolStripMenuItem1
            // 
            this.миКласToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.квадратноУравнениеToolStripMenuItem});
            this.миКласToolStripMenuItem1.Name = "миКласToolStripMenuItem1";
            this.миКласToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.миКласToolStripMenuItem1.Text = "8-ми клас";
            // 
            // квадратноУравнениеToolStripMenuItem
            // 
            this.квадратноУравнениеToolStripMenuItem.Name = "квадратноУравнениеToolStripMenuItem";
            this.квадратноУравнениеToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.квадратноУравнениеToolStripMenuItem.Text = "квадратно уравнение";
            this.квадратноУравнениеToolStripMenuItem.Click += new System.EventHandler(this.квадратноУравнениеToolStripMenuItem_Click);
            // 
            // изходToolStripMenuItem
            // 
            this.изходToolStripMenuItem.Name = "изходToolStripMenuItem";
            this.изходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.изходToolStripMenuItem.Text = "Изход";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem математическиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem алгебраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тиКласToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem степенуванеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem миКласToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem съкратеноУмножениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem миКласToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem квадратноУравнениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изходToolStripMenuItem;
    }
}

