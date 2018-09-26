namespace Szkola_2_1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.bROLL = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.pbdice4_4 = new System.Windows.Forms.PictureBox();
            this.pbdice4_3 = new System.Windows.Forms.PictureBox();
            this.pbdice4_2 = new System.Windows.Forms.PictureBox();
            this.pbdice4_1 = new System.Windows.Forms.PictureBox();
            this.showdice = new System.Windows.Forms.PictureBox();
            this.pbdice6 = new System.Windows.Forms.PictureBox();
            this.pbdice5 = new System.Windows.Forms.PictureBox();
            this.pbdice4 = new System.Windows.Forms.PictureBox();
            this.pbdice3 = new System.Windows.Forms.PictureBox();
            this.pbdice2 = new System.Windows.Forms.PictureBox();
            this.pbdice1 = new System.Windows.Forms.PictureBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbdice4_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdice4_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdice4_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdice4_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showdice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdice6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdice1)).BeginInit();
            this.SuspendLayout();
            // 
            // bROLL
            // 
            this.bROLL.Location = new System.Drawing.Point(12, 223);
            this.bROLL.Name = "bROLL";
            this.bROLL.Size = new System.Drawing.Size(196, 23);
            this.bROLL.TabIndex = 7;
            this.bROLL.Text = "ROLL!";
            this.bROLL.UseVisualStyleBackColor = true;
            this.bROLL.Click += new System.EventHandler(this.bROLL_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(260, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(215, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 17);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "D6";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(214, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "D4";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // pbdice4_4
            // 
            this.pbdice4_4.Image = global::Szkola_2_1.Properties.Resources.d4_dice_4;
            this.pbdice4_4.Location = new System.Drawing.Point(629, 118);
            this.pbdice4_4.Name = "pbdice4_4";
            this.pbdice4_4.Size = new System.Drawing.Size(96, 85);
            this.pbdice4_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbdice4_4.TabIndex = 14;
            this.pbdice4_4.TabStop = false;
            this.pbdice4_4.Visible = false;
            // 
            // pbdice4_3
            // 
            this.pbdice4_3.Image = global::Szkola_2_1.Properties.Resources.d4_dice_3;
            this.pbdice4_3.Location = new System.Drawing.Point(527, 118);
            this.pbdice4_3.Name = "pbdice4_3";
            this.pbdice4_3.Size = new System.Drawing.Size(96, 85);
            this.pbdice4_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbdice4_3.TabIndex = 13;
            this.pbdice4_3.TabStop = false;
            this.pbdice4_3.Visible = false;
            // 
            // pbdice4_2
            // 
            this.pbdice4_2.Image = global::Szkola_2_1.Properties.Resources.d4_dice_2;
            this.pbdice4_2.Location = new System.Drawing.Point(631, 27);
            this.pbdice4_2.Name = "pbdice4_2";
            this.pbdice4_2.Size = new System.Drawing.Size(96, 85);
            this.pbdice4_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbdice4_2.TabIndex = 12;
            this.pbdice4_2.TabStop = false;
            this.pbdice4_2.Visible = false;
            // 
            // pbdice4_1
            // 
            this.pbdice4_1.Image = global::Szkola_2_1.Properties.Resources.d4_dice_1;
            this.pbdice4_1.Location = new System.Drawing.Point(529, 27);
            this.pbdice4_1.Name = "pbdice4_1";
            this.pbdice4_1.Size = new System.Drawing.Size(96, 85);
            this.pbdice4_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbdice4_1.TabIndex = 11;
            this.pbdice4_1.TabStop = false;
            this.pbdice4_1.Visible = false;
            // 
            // showdice
            // 
            this.showdice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.showdice.Location = new System.Drawing.Point(12, 36);
            this.showdice.Name = "showdice";
            this.showdice.Size = new System.Drawing.Size(196, 181);
            this.showdice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showdice.TabIndex = 6;
            this.showdice.TabStop = false;
            // 
            // pbdice6
            // 
            this.pbdice6.Image = global::Szkola_2_1.Properties.Resources.dice6;
            this.pbdice6.Location = new System.Drawing.Point(833, 209);
            this.pbdice6.Name = "pbdice6";
            this.pbdice6.Size = new System.Drawing.Size(96, 85);
            this.pbdice6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbdice6.TabIndex = 5;
            this.pbdice6.TabStop = false;
            this.pbdice6.Visible = false;
            // 
            // pbdice5
            // 
            this.pbdice5.Image = global::Szkola_2_1.Properties.Resources.dice5;
            this.pbdice5.Location = new System.Drawing.Point(731, 209);
            this.pbdice5.Name = "pbdice5";
            this.pbdice5.Size = new System.Drawing.Size(96, 85);
            this.pbdice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbdice5.TabIndex = 4;
            this.pbdice5.TabStop = false;
            this.pbdice5.Visible = false;
            // 
            // pbdice4
            // 
            this.pbdice4.Image = global::Szkola_2_1.Properties.Resources.dice4;
            this.pbdice4.Location = new System.Drawing.Point(833, 118);
            this.pbdice4.Name = "pbdice4";
            this.pbdice4.Size = new System.Drawing.Size(96, 85);
            this.pbdice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbdice4.TabIndex = 3;
            this.pbdice4.TabStop = false;
            this.pbdice4.Visible = false;
            // 
            // pbdice3
            // 
            this.pbdice3.Image = global::Szkola_2_1.Properties.Resources.dice3;
            this.pbdice3.Location = new System.Drawing.Point(731, 118);
            this.pbdice3.Name = "pbdice3";
            this.pbdice3.Size = new System.Drawing.Size(96, 85);
            this.pbdice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbdice3.TabIndex = 2;
            this.pbdice3.TabStop = false;
            this.pbdice3.Visible = false;
            // 
            // pbdice2
            // 
            this.pbdice2.Image = global::Szkola_2_1.Properties.Resources.dice2;
            this.pbdice2.Location = new System.Drawing.Point(731, 27);
            this.pbdice2.Name = "pbdice2";
            this.pbdice2.Size = new System.Drawing.Size(96, 85);
            this.pbdice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbdice2.TabIndex = 1;
            this.pbdice2.TabStop = false;
            this.pbdice2.Visible = false;
            // 
            // pbdice1
            // 
            this.pbdice1.Image = global::Szkola_2_1.Properties.Resources.dice1;
            this.pbdice1.Location = new System.Drawing.Point(833, 27);
            this.pbdice1.Name = "pbdice1";
            this.pbdice1.Size = new System.Drawing.Size(96, 85);
            this.pbdice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbdice1.TabIndex = 0;
            this.pbdice1.TabStop = false;
            this.pbdice1.Visible = false;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 251);
            this.Controls.Add(this.pbdice4_4);
            this.Controls.Add(this.pbdice4_3);
            this.Controls.Add(this.pbdice4_2);
            this.Controls.Add(this.pbdice4_1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.bROLL);
            this.Controls.Add(this.showdice);
            this.Controls.Add(this.pbdice6);
            this.Controls.Add(this.pbdice5);
            this.Controls.Add(this.pbdice4);
            this.Controls.Add(this.pbdice3);
            this.Controls.Add(this.pbdice2);
            this.Controls.Add(this.pbdice1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Random Dice";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbdice4_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdice4_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdice4_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdice4_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showdice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdice6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbdice1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbdice1;
        private System.Windows.Forms.PictureBox pbdice2;
        private System.Windows.Forms.PictureBox pbdice3;
        private System.Windows.Forms.PictureBox pbdice4;
        private System.Windows.Forms.PictureBox pbdice5;
        private System.Windows.Forms.PictureBox pbdice6;
        private System.Windows.Forms.PictureBox showdice;
        private System.Windows.Forms.Button bROLL;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.PictureBox pbdice4_1;
        private System.Windows.Forms.PictureBox pbdice4_2;
        private System.Windows.Forms.PictureBox pbdice4_3;
        private System.Windows.Forms.PictureBox pbdice4_4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}

