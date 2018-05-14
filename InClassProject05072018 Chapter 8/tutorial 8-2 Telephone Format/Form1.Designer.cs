namespace tutorial_8_2_Telephone_Format
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.formatButton = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.Location = new System.Drawing.Point(12, 27);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(260, 40);
            this.instructionLabel.TabIndex = 2;
            this.instructionLabel.Text = "Enter a 10-digit number and I will format it as a telephone number.";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(139, 109);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // formatButton
            // 
            this.formatButton.Location = new System.Drawing.Point(58, 109);
            this.formatButton.Name = "formatButton";
            this.formatButton.Size = new System.Drawing.Size(75, 23);
            this.formatButton.TabIndex = 5;
            this.formatButton.Text = "Format";
            this.formatButton.UseVisualStyleBackColor = true;
            this.formatButton.Click += new System.EventHandler(this.formatButton_Click);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(86, 70);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 166);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.formatButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button formatButton;
        private System.Windows.Forms.TextBox numberTextBox;
    }
}

