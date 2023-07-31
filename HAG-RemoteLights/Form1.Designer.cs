namespace HAGRemoteLights
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_start = new System.Windows.Forms.Label();
            this.label_sec = new System.Windows.Forms.Label();
            this.label_current = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer_jedeSekunde = new System.Windows.Forms.Timer(this.components);
            this.timer_starteInXX = new System.Windows.Forms.Timer(this.components);
            this.textCMD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pic8 = new System.Windows.Forms.PictureBox();
            this.pic7 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.label_delta = new System.Windows.Forms.Label();
            this.label_startNow = new System.Windows.Forms.Label();
            this.label_praefix = new System.Windows.Forms.Label();
            this.comboBox_praefix = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_inputPraefix = new System.Windows.Forms.ComboBox();
            this.checkFade = new System.Windows.Forms.CheckBox();
            this.timer_refesh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_start.Location = new System.Drawing.Point(16, 128);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(94, 24);
            this.label_start.TabIndex = 8;
            this.label_start.Text = "Starte in";
            this.label_start.Visible = false;
            // 
            // label_sec
            // 
            this.label_sec.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sec.Location = new System.Drawing.Point(107, 128);
            this.label_sec.Name = "label_sec";
            this.label_sec.Size = new System.Drawing.Size(185, 26);
            this.label_sec.TabIndex = 9;
            this.label_sec.Text = "0 Sekunden";
            this.label_sec.Visible = false;
            this.label_sec.Click += new System.EventHandler(this.label_sec_Click);
            // 
            // label_current
            // 
            this.label_current.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_current.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_current.Location = new System.Drawing.Point(294, 129);
            this.label_current.Name = "label_current";
            this.label_current.Size = new System.Drawing.Size(147, 25);
            this.label_current.TabIndex = 10;
            this.label_current.Text = "0ms";
            this.label_current.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_current.Visible = false;
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(12, 73);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(86, 30);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Starten";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(264, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "C:\\usr\\SoundControl\\";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soundfile:";
            // 
            // timer_jedeSekunde
            // 
            this.timer_jedeSekunde.Interval = 200;
            this.timer_jedeSekunde.Tick += new System.EventHandler(this.timer_jede1ms_Tick);
            // 
            // timer_starteInXX
            // 
            this.timer_starteInXX.Interval = 1000;
            this.timer_starteInXX.Tick += new System.EventHandler(this.timer_starteInXX_Tick);
            // 
            // textCMD
            // 
            this.textCMD.Location = new System.Drawing.Point(20, 179);
            this.textCMD.Multiline = true;
            this.textCMD.Name = "textCMD";
            this.textCMD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textCMD.Size = new System.Drawing.Size(418, 144);
            this.textCMD.TabIndex = 13;
            this.textCMD.TextChanged += new System.EventHandler(this.textCMD_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "CMD:";
            // 
            // pic8
            // 
            this.pic8.Image = global::HAGRemoteLights.Properties.Resources.icons8_round_48_b;
            this.pic8.Location = new System.Drawing.Point(390, 13);
            this.pic8.Name = "pic8";
            this.pic8.Size = new System.Drawing.Size(48, 54);
            this.pic8.TabIndex = 7;
            this.pic8.TabStop = false;
            // 
            // pic7
            // 
            this.pic7.Image = global::HAGRemoteLights.Properties.Resources.icons8_round_48_b;
            this.pic7.Location = new System.Drawing.Point(336, 13);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(48, 54);
            this.pic7.TabIndex = 6;
            this.pic7.TabStop = false;
            // 
            // pic6
            // 
            this.pic6.Image = global::HAGRemoteLights.Properties.Resources.icons8_round_48_b;
            this.pic6.Location = new System.Drawing.Point(282, 13);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(48, 54);
            this.pic6.TabIndex = 5;
            this.pic6.TabStop = false;
            // 
            // pic5
            // 
            this.pic5.Image = global::HAGRemoteLights.Properties.Resources.icons8_round_48_b;
            this.pic5.Location = new System.Drawing.Point(228, 13);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(48, 54);
            this.pic5.TabIndex = 4;
            this.pic5.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.Image = global::HAGRemoteLights.Properties.Resources.icons8_round_48_b;
            this.pic4.Location = new System.Drawing.Point(174, 13);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(48, 54);
            this.pic4.TabIndex = 3;
            this.pic4.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Image = global::HAGRemoteLights.Properties.Resources.icons8_round_48_b;
            this.pic3.Location = new System.Drawing.Point(120, 13);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(48, 54);
            this.pic3.TabIndex = 2;
            this.pic3.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Image = global::HAGRemoteLights.Properties.Resources.icons8_round_48_b;
            this.pic2.Location = new System.Drawing.Point(66, 13);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(48, 54);
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.Image = global::HAGRemoteLights.Properties.Resources.icons8_round_48_b;
            this.pic1.Location = new System.Drawing.Point(12, 13);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(48, 54);
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            // 
            // label_delta
            // 
            this.label_delta.Location = new System.Drawing.Point(324, 146);
            this.label_delta.Name = "label_delta";
            this.label_delta.Size = new System.Drawing.Size(114, 19);
            this.label_delta.TabIndex = 11;
            this.label_delta.Text = "Vergleich 0ms";
            this.label_delta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_delta.Visible = false;
            // 
            // label_startNow
            // 
            this.label_startNow.AutoSize = true;
            this.label_startNow.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_startNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_startNow.Location = new System.Drawing.Point(55, 152);
            this.label_startNow.Name = "label_startNow";
            this.label_startNow.Size = new System.Drawing.Size(85, 24);
            this.label_startNow.TabIndex = 12;
            this.label_startNow.Text = "START!";
            this.label_startNow.Visible = false;
            // 
            // label_praefix
            // 
            this.label_praefix.AutoSize = true;
            this.label_praefix.Location = new System.Drawing.Point(318, 107);
            this.label_praefix.Name = "label_praefix";
            this.label_praefix.Size = new System.Drawing.Size(38, 14);
            this.label_praefix.TabIndex = 6;
            this.label_praefix.Text = "Präfix:";
            // 
            // comboBox_praefix
            // 
            this.comboBox_praefix.FormattingEnabled = true;
            this.comboBox_praefix.Items.AddRange(new object[] {
            "collection",
            "light",
            "lightblink",
            "lightfade"});
            this.comboBox_praefix.Location = new System.Drawing.Point(356, 103);
            this.comboBox_praefix.Name = "comboBox_praefix";
            this.comboBox_praefix.Size = new System.Drawing.Size(82, 22);
            this.comboBox_praefix.TabIndex = 7;
            this.comboBox_praefix.Text = "collection";
            this.comboBox_praefix.SelectedIndexChanged += new System.EventHandler(this.comboBox_praefix_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(340, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "CMD kopieren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Input-Präfix:";
            // 
            // comboBox_inputPraefix
            // 
            this.comboBox_inputPraefix.FormattingEnabled = true;
            this.comboBox_inputPraefix.Items.AddRange(new object[] {
            "L",
            "F",
            "BEAT",
            "TW",
            "Q",
            "Circle"});
            this.comboBox_inputPraefix.Location = new System.Drawing.Point(174, 103);
            this.comboBox_inputPraefix.Name = "comboBox_inputPraefix";
            this.comboBox_inputPraefix.Size = new System.Drawing.Size(73, 22);
            this.comboBox_inputPraefix.TabIndex = 4;
            this.comboBox_inputPraefix.Text = "L";
            this.comboBox_inputPraefix.SelectedIndexChanged += new System.EventHandler(this.comboBox_inputPraefix_SelectedIndexChanged);
            // 
            // checkFade
            // 
            this.checkFade.AutoSize = true;
            this.checkFade.Location = new System.Drawing.Point(253, 105);
            this.checkFade.Name = "checkFade";
            this.checkFade.Size = new System.Drawing.Size(50, 18);
            this.checkFade.TabIndex = 5;
            this.checkFade.Text = "Fade";
            this.checkFade.UseVisualStyleBackColor = true;
            // 
            // timer_refesh
            // 
            this.timer_refesh.Enabled = true;
            this.timer_refesh.Interval = 1000;
            this.timer_refesh.Tick += new System.EventHandler(this.timer_refesh_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 373);
            this.Controls.Add(this.checkFade);
            this.Controls.Add(this.comboBox_inputPraefix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_praefix);
            this.Controls.Add(this.label_praefix);
            this.Controls.Add(this.label_startNow);
            this.Controls.Add(this.label_delta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCMD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_current);
            this.Controls.Add(this.label_sec);
            this.Controls.Add(this.label_start);
            this.Controls.Add(this.pic8);
            this.Controls.Add(this.pic7);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Lichter";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.PictureBox pic7;
        private System.Windows.Forms.PictureBox pic8;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label_sec;
        private System.Windows.Forms.Label label_current;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer_jedeSekunde;
        private System.Windows.Forms.Timer timer_starteInXX;
        private System.Windows.Forms.TextBox textCMD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_delta;
        private System.Windows.Forms.Label label_startNow;
        private System.Windows.Forms.Label label_praefix;
        private System.Windows.Forms.ComboBox comboBox_praefix;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_inputPraefix;
        private System.Windows.Forms.CheckBox checkFade;
        private System.Windows.Forms.Timer timer_refesh;
    }
}

