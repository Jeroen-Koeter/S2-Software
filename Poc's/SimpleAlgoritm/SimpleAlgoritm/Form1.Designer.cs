using System.Windows.Forms.VisualStyles;

namespace SimpleAlgoritm
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
            this.prijsLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.prijsTextBox = new System.Windows.Forms.TextBox();
            this.bonLabel = new System.Windows.Forms.Label();
            this.bonTextBox = new System.Windows.Forms.TextBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.maxButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.averageButton = new System.Windows.Forms.Button();
            this.maxLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.getAllButton = new System.Windows.Forms.Button();
            this.getAllTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // prijsLabel
            // 
            this.prijsLabel.AutoSize = true;
            this.prijsLabel.Location = new System.Drawing.Point(121, 9);
            this.prijsLabel.Name = "prijsLabel";
            this.prijsLabel.Size = new System.Drawing.Size(32, 15);
            this.prijsLabel.TabIndex = 0;
            this.prijsLabel.Text = "Prijs:";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(12, 9);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(52, 15);
            this.productLabel.TabIndex = 1;
            this.productLabel.Text = "Product:";
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(12, 27);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(100, 23);
            this.productTextBox.TabIndex = 2;
            // 
            // prijsTextBox
            // 
            this.prijsTextBox.Location = new System.Drawing.Point(118, 27);
            this.prijsTextBox.Name = "prijsTextBox";
            this.prijsTextBox.Size = new System.Drawing.Size(48, 23);
            this.prijsTextBox.TabIndex = 3;
            this.prijsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prijsTextBox_KeyPress);
            // 
            // bonLabel
            // 
            this.bonLabel.AutoSize = true;
            this.bonLabel.Location = new System.Drawing.Point(173, 9);
            this.bonLabel.Name = "bonLabel";
            this.bonLabel.Size = new System.Drawing.Size(31, 15);
            this.bonLabel.TabIndex = 4;
            this.bonLabel.Text = "Bon:";
            // 
            // bonTextBox
            // 
            this.bonTextBox.Enabled = false;
            this.bonTextBox.Location = new System.Drawing.Point(173, 26);
            this.bonTextBox.Multiline = true;
            this.bonTextBox.Name = "bonTextBox";
            this.bonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bonTextBox.Size = new System.Drawing.Size(100, 412);
            this.bonTextBox.TabIndex = 5;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(13, 57);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(153, 23);
            this.addProductButton.TabIndex = 6;
            this.addProductButton.Text = "Product toevoegen";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // maxButton
            // 
            this.maxButton.Location = new System.Drawing.Point(279, 27);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(121, 23);
            this.maxButton.TabIndex = 7;
            this.maxButton.Text = "Maximum prijs";
            this.maxButton.UseVisualStyleBackColor = true;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(280, 57);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(120, 23);
            this.sortButton.TabIndex = 8;
            this.sortButton.Text = "Sorteer bon";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // averageButton
            // 
            this.averageButton.Location = new System.Drawing.Point(280, 87);
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(120, 23);
            this.averageButton.TabIndex = 9;
            this.averageButton.Text = "Gemiddelde prijs";
            this.averageButton.UseVisualStyleBackColor = true;
            this.averageButton.Click += new System.EventHandler(this.averageButton_Click);
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(406, 31);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(90, 15);
            this.maxLabel.TabIndex = 10;
            this.maxLabel.Text = "Maximum prijs:";
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(406, 91);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(164, 15);
            this.averageLabel.TabIndex = 11;
            this.averageLabel.Text = "Gemiddelde prijs per product:";
            // 
            // getAllButton
            // 
            this.getAllButton.Location = new System.Drawing.Point(280, 117);
            this.getAllButton.Name = "getAllButton";
            this.getAllButton.Size = new System.Drawing.Size(179, 23);
            this.getAllButton.TabIndex = 12;
            this.getAllButton.Text = "Alle producten met deze prijs:";
            this.getAllButton.UseVisualStyleBackColor = true;
            this.getAllButton.Click += new System.EventHandler(this.getAllButton_Click);
            // 
            // getAllTextBox
            // 
            this.getAllTextBox.Location = new System.Drawing.Point(465, 118);
            this.getAllTextBox.Name = "getAllTextBox";
            this.getAllTextBox.Size = new System.Drawing.Size(100, 23);
            this.getAllTextBox.TabIndex = 13;
            this.getAllTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.getAllTextBox_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getAllTextBox);
            this.Controls.Add(this.getAllButton);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.averageButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.maxButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.bonTextBox);
            this.Controls.Add(this.bonLabel);
            this.Controls.Add(this.prijsTextBox);
            this.Controls.Add(this.productTextBox);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.prijsLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prijsLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.TextBox prijsTextBox;
        private System.Windows.Forms.Label bonLabel;
        private System.Windows.Forms.TextBox bonTextBox;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button maxButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button averageButton;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Button getAllButton;
        private System.Windows.Forms.TextBox getAllTextBox;
    }
}

