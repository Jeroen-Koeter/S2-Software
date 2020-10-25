namespace dobbelstenen
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.loopTimes = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.telUitkomst = new System.Windows.Forms.Label();
            this.telNummer = new System.Windows.Forms.TextBox();
            this.tellen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.average = new System.Windows.Forms.Label();
            this.gemiddeldeBerekenen = new System.Windows.Forms.Button();
            this.maxMin = new System.Windows.Forms.Button();
            this.lblMax = new System.Windows.Forms.Label();
            this.Minlable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loopTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 117);
            this.button1.TabIndex = 0;
            this.button1.Text = "generate ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(417, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "100";
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "max nummer:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(593, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 117);
            this.button2.TabIndex = 4;
            this.button2.Text = "reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "aantal loops: ";
            // 
            // Output1
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 20;
            this.lbOutput.Location = new System.Drawing.Point(12, 12);
            this.lbOutput.Name = "Output1";
            this.lbOutput.Size = new System.Drawing.Size(120, 544);
            this.lbOutput.TabIndex = 7;
            // 
            // loopTimes
            // 
            this.loopTimes.LargeChange = 1;
            this.loopTimes.Location = new System.Drawing.Point(410, 58);
            this.loopTimes.Maximum = 1000;
            this.loopTimes.Name = "loopTimes";
            this.loopTimes.Size = new System.Drawing.Size(156, 69);
            this.loopTimes.TabIndex = 8;
            this.loopTimes.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "0";
            // 
            // telUitkomst
            // 
            this.telUitkomst.AutoSize = true;
            this.telUitkomst.Location = new System.Drawing.Point(147, 12);
            this.telUitkomst.Name = "telUitkomst";
            this.telUitkomst.Size = new System.Drawing.Size(73, 20);
            this.telUitkomst.TabIndex = 11;
            this.telUitkomst.Text = "uitkomst:";
            // 
            // telNummer
            // 
            this.telNummer.Location = new System.Drawing.Point(440, 303);
            this.telNummer.Name = "telNummer";
            this.telNummer.Size = new System.Drawing.Size(137, 26);
            this.telNummer.TabIndex = 12;
            this.telNummer.TextChanged += new System.EventHandler(this.TelNummer_TextChanged);
            // 
            // tellen
            // 
            this.tellen.Location = new System.Drawing.Point(593, 258);
            this.tellen.Name = "tellen";
            this.tellen.Size = new System.Drawing.Size(195, 117);
            this.tellen.TabIndex = 13;
            this.tellen.Text = "tellen";
            this.tellen.UseVisualStyleBackColor = true;
            this.tellen.Click += new System.EventHandler(this.Tellen_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(304, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 50);
            this.label4.TabIndex = 14;
            this.label4.Text = "welk nummer wil je tellen?";
            // 
            // average
            // 
            this.average.AutoSize = true;
            this.average.Location = new System.Drawing.Point(8, 559);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(99, 20);
            this.average.TabIndex = 15;
            this.average.Text = "gemiddelde: ";
            // 
            // gemiddeldeBerekenen
            // 
            this.gemiddeldeBerekenen.Location = new System.Drawing.Point(12, 598);
            this.gemiddeldeBerekenen.Name = "gemiddeldeBerekenen";
            this.gemiddeldeBerekenen.Size = new System.Drawing.Size(135, 79);
            this.gemiddeldeBerekenen.TabIndex = 16;
            this.gemiddeldeBerekenen.Text = "gemiddelde berekenen";
            this.gemiddeldeBerekenen.UseVisualStyleBackColor = true;
            this.gemiddeldeBerekenen.Click += new System.EventHandler(this.GemiddeldeBerekenen_Click);
            // 
            // maxMin
            // 
            this.maxMin.Location = new System.Drawing.Point(593, 381);
            this.maxMin.Name = "maxMin";
            this.maxMin.Size = new System.Drawing.Size(195, 117);
            this.maxMin.TabIndex = 17;
            this.maxMin.Text = "Max/Min";
            this.maxMin.UseVisualStyleBackColor = true;
            this.maxMin.Click += new System.EventHandler(this.MaxMin_Click);
            // 
            // Maxlable
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(589, 501);
            this.lblMax.Name = "Maxlable";
            this.lblMax.Size = new System.Drawing.Size(80, 20);
            this.lblMax.TabIndex = 18;
            this.lblMax.Text = "Maximum:";
            // 
            // Minlable
            // 
            this.Minlable.AutoSize = true;
            this.Minlable.Location = new System.Drawing.Point(589, 536);
            this.Minlable.Name = "Minlable";
            this.Minlable.Size = new System.Drawing.Size(76, 20);
            this.Minlable.TabIndex = 19;
            this.Minlable.Text = "Minimum:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 683);
            this.Controls.Add(this.Minlable);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.maxMin);
            this.Controls.Add(this.gemiddeldeBerekenen);
            this.Controls.Add(this.average);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tellen);
            this.Controls.Add(this.telNummer);
            this.Controls.Add(this.telUitkomst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loopTimes);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.loopTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.TrackBar loopTimes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label telUitkomst;
        private System.Windows.Forms.TextBox telNummer;
        private System.Windows.Forms.Button tellen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label average;
        private System.Windows.Forms.Button gemiddeldeBerekenen;
        private System.Windows.Forms.Button maxMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label Minlable;
    }
}

