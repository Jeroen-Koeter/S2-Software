namespace CircusTrein.ViewWinForm
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
            this.CreateAnimalButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.DietTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SortTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateAnimalButton
            // 
            this.CreateAnimalButton.Location = new System.Drawing.Point(395, 119);
            this.CreateAnimalButton.Name = "CreateAnimalButton";
            this.CreateAnimalButton.Size = new System.Drawing.Size(97, 34);
            this.CreateAnimalButton.TabIndex = 0;
            this.CreateAnimalButton.Text = "Create dier";
            this.CreateAnimalButton.UseVisualStyleBackColor = true;
            this.CreateAnimalButton.Click += new System.EventHandler(this.CreateAnimalButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(25, 22);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(97, 34);
            this.SortButton.TabIndex = 1;
            this.SortButton.Text = "Sorteer Dieren";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Location = new System.Drawing.Point(392, 58);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(100, 23);
            this.SizeTextBox.TabIndex = 2;
            // 
            // DietTextBox
            // 
            this.DietTextBox.Location = new System.Drawing.Point(392, 88);
            this.DietTextBox.Name = "DietTextBox";
            this.DietTextBox.Size = new System.Drawing.Size(100, 23);
            this.DietTextBox.TabIndex = 3;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(392, 29);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 23);
            this.NameTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Naam van het dier:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Grootte van het dier::";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dieët van het dier";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(588, 61);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 69);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "Dieren groottes:\r\n- 1 = Klein\r\n- 3 = Middel\r\n- 5 = Groot";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(588, 136);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 55);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "Dieren dieëten:\r\n- 1 = Herbivoor\r\n- 2 = Carnivoor";
            // 
            // SortTextBox
            // 
            this.SortTextBox.Enabled = false;
            this.SortTextBox.Location = new System.Drawing.Point(25, 57);
            this.SortTextBox.Multiline = true;
            this.SortTextBox.Name = "SortTextBox";
            this.SortTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SortTextBox.Size = new System.Drawing.Size(237, 353);
            this.SortTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.SortTextBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.DietTextBox);
            this.Controls.Add(this.SizeTextBox);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.CreateAnimalButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateAnimalButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.TextBox DietTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox SortTextBox;
    }
}

