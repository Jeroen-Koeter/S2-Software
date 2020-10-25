namespace CircusTrein
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
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountDierenNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GenereerDierenButton = new System.Windows.Forms.Button();
            this.VulWagonsButton = new System.Windows.Forms.Button();
            this.WagonsTextBox = new System.Windows.Forms.TextBox();
            this.DierenTextBox = new System.Windows.Forms.TextBox();
            this.WagonLabel = new System.Windows.Forms.Label();
            this.DierenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AmountDierenNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(320, 9);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(80, 15);
            this.AmountLabel.TabIndex = 0;
            this.AmountLabel.Text = "Aantal dieren:";
            // 
            // AmountDierenNumericUpDown
            // 
            this.AmountDierenNumericUpDown.Location = new System.Drawing.Point(406, 7);
            this.AmountDierenNumericUpDown.Name = "AmountDierenNumericUpDown";
            this.AmountDierenNumericUpDown.Size = new System.Drawing.Size(35, 23);
            this.AmountDierenNumericUpDown.TabIndex = 1;
            // 
            // GenereerDierenButton
            // 
            this.GenereerDierenButton.Location = new System.Drawing.Point(320, 64);
            this.GenereerDierenButton.Name = "GenereerDierenButton";
            this.GenereerDierenButton.Size = new System.Drawing.Size(121, 23);
            this.GenereerDierenButton.TabIndex = 2;
            this.GenereerDierenButton.Text = "Maak dieren";
            this.GenereerDierenButton.UseVisualStyleBackColor = true;
            this.GenereerDierenButton.Click += new System.EventHandler(this.GenerateAnimalsButton_Click);
            // 
            // VulWagonsButton
            // 
            this.VulWagonsButton.Location = new System.Drawing.Point(320, 117);
            this.VulWagonsButton.Name = "VulWagonsButton";
            this.VulWagonsButton.Size = new System.Drawing.Size(121, 23);
            this.VulWagonsButton.TabIndex = 3;
            this.VulWagonsButton.Text = "Vul wagons";
            this.VulWagonsButton.UseVisualStyleBackColor = true;
            this.VulWagonsButton.Click += new System.EventHandler(this.FillCartsButton_Click);
            // 
            // WagonsTextBox
            // 
            this.WagonsTextBox.Location = new System.Drawing.Point(13, 29);
            this.WagonsTextBox.Multiline = true;
            this.WagonsTextBox.Name = "WagonsTextBox";
            this.WagonsTextBox.ReadOnly = true;
            this.WagonsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.WagonsTextBox.Size = new System.Drawing.Size(301, 409);
            this.WagonsTextBox.TabIndex = 4;
            // 
            // DierenTextBox
            // 
            this.DierenTextBox.Location = new System.Drawing.Point(447, 29);
            this.DierenTextBox.Multiline = true;
            this.DierenTextBox.Name = "DierenTextBox";
            this.DierenTextBox.ReadOnly = true;
            this.DierenTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DierenTextBox.Size = new System.Drawing.Size(301, 409);
            this.DierenTextBox.TabIndex = 4;
            // 
            // WagonLabel
            // 
            this.WagonLabel.AutoSize = true;
            this.WagonLabel.Location = new System.Drawing.Point(13, 9);
            this.WagonLabel.Name = "WagonLabel";
            this.WagonLabel.Size = new System.Drawing.Size(53, 15);
            this.WagonLabel.TabIndex = 5;
            this.WagonLabel.Text = "Wagons:";
            // 
            // DierenLabel
            // 
            this.DierenLabel.AutoSize = true;
            this.DierenLabel.Location = new System.Drawing.Point(448, 9);
            this.DierenLabel.Name = "DierenLabel";
            this.DierenLabel.Size = new System.Drawing.Size(44, 15);
            this.DierenLabel.TabIndex = 6;
            this.DierenLabel.Text = "Dieren:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DierenLabel);
            this.Controls.Add(this.WagonLabel);
            this.Controls.Add(this.DierenTextBox);
            this.Controls.Add(this.WagonsTextBox);
            this.Controls.Add(this.VulWagonsButton);
            this.Controls.Add(this.GenereerDierenButton);
            this.Controls.Add(this.AmountDierenNumericUpDown);
            this.Controls.Add(this.AmountLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AmountDierenNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.NumericUpDown AmountDierenNumericUpDown;
        private System.Windows.Forms.Button GenereerDierenButton;
        private System.Windows.Forms.Button VulWagonsButton;
        private System.Windows.Forms.TextBox WagonsTextBox;
        private System.Windows.Forms.TextBox DierenTextBox;
        private System.Windows.Forms.Label WagonLabel;
        private System.Windows.Forms.Label DierenLabel;
    }
}

