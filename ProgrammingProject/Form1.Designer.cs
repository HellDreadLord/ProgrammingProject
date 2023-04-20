namespace ProgrammingProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            trackBar1 = new TrackBar();
            label1 = new Label();
            LabelOrbit = new Label();
            LabelPlanetDay = new Label();
            LabelDate = new Label();
            LabelSeason = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(14, 47);
            button1.Name = "button1";
            button1.Size = new Size(76, 29);
            button1.TabIndex = 0;
            button1.Text = "Stop";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(14, 12);
            button2.Name = "button2";
            button2.Size = new Size(76, 29);
            button2.TabIndex = 1;
            button2.Text = "Start";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(97, 12);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.RightToLeft = RightToLeft.Yes;
            trackBar1.Size = new Size(296, 56);
            trackBar1.TabIndex = 2;
            trackBar1.Value = 50;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(186, 51);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 3;
            label1.Text = "Planet Velocity";
            // 
            // LabelOrbit
            // 
            LabelOrbit.AutoSize = true;
            LabelOrbit.BackColor = Color.Transparent;
            LabelOrbit.ForeColor = Color.White;
            LabelOrbit.Location = new Point(3, 94);
            LabelOrbit.Name = "LabelOrbit";
            LabelOrbit.Size = new Size(94, 20);
            LabelOrbit.TabIndex = 4;
            LabelOrbit.Text = "Orbit Period";
            // 
            // LabelPlanetDay
            // 
            LabelPlanetDay.AutoSize = true;
            LabelPlanetDay.BackColor = Color.Transparent;
            LabelPlanetDay.ForeColor = Color.White;
            LabelPlanetDay.Location = new Point(6, 124);
            LabelPlanetDay.Name = "LabelPlanetDay";
            LabelPlanetDay.Size = new Size(84, 20);
            LabelPlanetDay.TabIndex = 5;
            LabelPlanetDay.Text = "Planet Day";
            // 
            // LabelDate
            // 
            LabelDate.AutoSize = true;
            LabelDate.BackColor = Color.Transparent;
            LabelDate.ForeColor = Color.White;
            LabelDate.Location = new Point(6, 153);
            LabelDate.Name = "LabelDate";
            LabelDate.Size = new Size(42, 20);
            LabelDate.TabIndex = 6;
            LabelDate.Text = "Date";
            // 
            // LabelSeason
            // 
            LabelSeason.AutoSize = true;
            LabelSeason.BackColor = Color.Transparent;
            LabelSeason.ForeColor = Color.White;
            LabelSeason.Location = new Point(6, 183);
            LabelSeason.Name = "LabelSeason";
            LabelSeason.Size = new Size(58, 20);
            LabelSeason.TabIndex = 7;
            LabelSeason.Text = "Season";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(486, 353);
            Controls.Add(LabelSeason);
            Controls.Add(LabelDate);
            Controls.Add(LabelPlanetDay);
            Controls.Add(LabelOrbit);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
        private TrackBar trackBar1;
        private Label label1;
        private Label LabelOrbit;
        private Label LabelPlanetDay;
        private Label LabelDate;
        private Label LabelSeason;
    }
}