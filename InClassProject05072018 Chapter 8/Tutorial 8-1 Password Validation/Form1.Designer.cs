namespace Tutorial_8_1_Password_Validation
{
    partial class PasswordValid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordValid));
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.promptLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.checkPasswordButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Location = new System.Drawing.Point(24, 20);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(243, 93);
            this.instructionsLabel.TabIndex = 1;
            this.instructionsLabel.Text = resources.GetString("instructionsLabel.Text");
            this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(69, 122);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(132, 16);
            this.promptLabel.TabIndex = 2;
            this.promptLabel.Text = "Enter a password.";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(139, 199);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 36);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // checkPasswordButton
            // 
            this.checkPasswordButton.Location = new System.Drawing.Point(45, 199);
            this.checkPasswordButton.Name = "checkPasswordButton";
            this.checkPasswordButton.Size = new System.Drawing.Size(75, 36);
            this.checkPasswordButton.TabIndex = 6;
            this.checkPasswordButton.Text = "Check Password";
            this.checkPasswordButton.UseVisualStyleBackColor = true;
            this.checkPasswordButton.Click += new System.EventHandler(this.checkPasswordButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(72, 151);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(129, 20);
            this.passwordTextBox.TabIndex = 5;
            // 
            // PasswordValid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.checkPasswordButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.instructionsLabel);
            this.Name = "PasswordValid";
            this.Text = "Password Validation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button checkPasswordButton;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}

