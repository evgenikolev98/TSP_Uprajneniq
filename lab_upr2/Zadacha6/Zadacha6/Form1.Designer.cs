namespace Zadacha6
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
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.width_lbl = new System.Windows.Forms.Label();
            this.height_lbl = new System.Windows.Forms.Label();
            this.area_lbl = new System.Windows.Forms.Label();
            this.width2 = new System.Windows.Forms.Label();
            this.height2 = new System.Windows.Forms.Label();
            this.area2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(29, -1);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(367, 31);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(0, 30);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(29, 351);
            this.vScrollBar1.TabIndex = 1;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Area Calculation";
            // 
            // width_lbl
            // 
            this.width_lbl.AutoSize = true;
            this.width_lbl.Location = new System.Drawing.Point(150, 138);
            this.width_lbl.Name = "width_lbl";
            this.width_lbl.Size = new System.Drawing.Size(0, 13);
            this.width_lbl.TabIndex = 3;
            // 
            // height_lbl
            // 
            this.height_lbl.AutoSize = true;
            this.height_lbl.Location = new System.Drawing.Point(150, 164);
            this.height_lbl.Name = "height_lbl";
            this.height_lbl.Size = new System.Drawing.Size(0, 13);
            this.height_lbl.TabIndex = 4;
            // 
            // area_lbl
            // 
            this.area_lbl.AutoSize = true;
            this.area_lbl.Location = new System.Drawing.Point(150, 193);
            this.area_lbl.Name = "area_lbl";
            this.area_lbl.Size = new System.Drawing.Size(0, 13);
            this.area_lbl.TabIndex = 5;
            // 
            // width2
            // 
            this.width2.AutoSize = true;
            this.width2.Location = new System.Drawing.Point(214, 138);
            this.width2.Name = "width2";
            this.width2.Size = new System.Drawing.Size(0, 13);
            this.width2.TabIndex = 6;
            // 
            // height2
            // 
            this.height2.AutoSize = true;
            this.height2.Location = new System.Drawing.Point(214, 164);
            this.height2.Name = "height2";
            this.height2.Size = new System.Drawing.Size(0, 13);
            this.height2.TabIndex = 7;
            // 
            // area2
            // 
            this.area2.AutoSize = true;
            this.area2.Location = new System.Drawing.Point(214, 193);
            this.area2.Name = "area2";
            this.area2.Size = new System.Drawing.Size(0, 13);
            this.area2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(405, 421);
            this.Controls.Add(this.area2);
            this.Controls.Add(this.height2);
            this.Controls.Add(this.width2);
            this.Controls.Add(this.area_lbl);
            this.Controls.Add(this.height_lbl);
            this.Controls.Add(this.width_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label width_lbl;
        private System.Windows.Forms.Label height_lbl;
        private System.Windows.Forms.Label area_lbl;
        private System.Windows.Forms.Label width2;
        private System.Windows.Forms.Label height2;
        private System.Windows.Forms.Label area2;
    }
}

