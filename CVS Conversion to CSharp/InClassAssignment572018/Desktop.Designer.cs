﻿namespace InClassAssignment572018
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectBTN = new System.Windows.Forms.Button();
            this.loadCorrectBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(30, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Path will be displayed here";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // selectBTN
            // 
            this.selectBTN.Location = new System.Drawing.Point(30, 205);
            this.selectBTN.Name = "selectBTN";
            this.selectBTN.Size = new System.Drawing.Size(86, 45);
            this.selectBTN.TabIndex = 2;
            this.selectBTN.Text = "Select File";
            this.selectBTN.UseVisualStyleBackColor = true;
            this.selectBTN.Click += new System.EventHandler(this.selectBTN_Click);
            // 
            // loadCorrectBTN
            // 
            this.loadCorrectBTN.Location = new System.Drawing.Point(158, 205);
            this.loadCorrectBTN.Name = "loadCorrectBTN";
            this.loadCorrectBTN.Size = new System.Drawing.Size(148, 45);
            this.loadCorrectBTN.TabIndex = 3;
            this.loadCorrectBTN.Text = "Load && Correct Dates";
            this.loadCorrectBTN.UseVisualStyleBackColor = true;
            this.loadCorrectBTN.Click += new System.EventHandler(this.loadCorrectBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 282);
            this.Controls.Add(this.loadCorrectBTN);
            this.Controls.Add(this.selectBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button selectBTN;
        private System.Windows.Forms.Button loadCorrectBTN;
    }
}

