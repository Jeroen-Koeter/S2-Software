
namespace DatabaseDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.SQLButton = new System.Windows.Forms.Button();
            this.QueryTextBox = new System.Windows.Forms.TextBox();
            this.ExampleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(517, 17);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(331, 450);
            this.ResultTextBox.TabIndex = 2;
            // 
            // SQLButton
            // 
            this.SQLButton.Location = new System.Drawing.Point(12, 12);
            this.SQLButton.Name = "SQLButton";
            this.SQLButton.Size = new System.Drawing.Size(117, 29);
            this.SQLButton.TabIndex = 3;
            this.SQLButton.Text = "Run Query ";
            this.SQLButton.UseVisualStyleBackColor = true;
            this.SQLButton.Click += new System.EventHandler(this.SQLButton_Click);
            // 
            // QueryTextBox
            // 
            this.QueryTextBox.Location = new System.Drawing.Point(12, 47);
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.Size = new System.Drawing.Size(499, 20);
            this.QueryTextBox.TabIndex = 4;
            // 
            // ExampleTextBox
            // 
            this.ExampleTextBox.Location = new System.Drawing.Point(12, 73);
            this.ExampleTextBox.Multiline = true;
            this.ExampleTextBox.Name = "ExampleTextBox";
            this.ExampleTextBox.ReadOnly = true;
            this.ExampleTextBox.Size = new System.Drawing.Size(499, 123);
            this.ExampleTextBox.TabIndex = 5;
            this.ExampleTextBox.Text = resources.GetString("ExampleTextBox.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 479);
            this.Controls.Add(this.ExampleTextBox);
            this.Controls.Add(this.QueryTextBox);
            this.Controls.Add(this.SQLButton);
            this.Controls.Add(this.ResultTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button SQLButton;
        private System.Windows.Forms.TextBox QueryTextBox;
        private System.Windows.Forms.TextBox ExampleTextBox;
    }
}

