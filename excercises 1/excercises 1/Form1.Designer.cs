﻿namespace excercises_1
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
            this.button1 = new System.Windows.Forms.Button();
            this.abaResult = new System.Windows.Forms.Label();
            this.qtqChicken1 = new System.Windows.Forms.TextBox();
            this.qtqChicken2 = new System.Windows.Forms.TextBox();
            this.qtqChicken3 = new System.Windows.Forms.TextBox();
            this.qtqChicken5 = new System.Windows.Forms.TextBox();
            this.qtqChicken4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter eggs produce by each of 5 chickens";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(282, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Click to calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // abaResult
            // 
            this.abaResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.abaResult.Location = new System.Drawing.Point(245, 392);
            this.abaResult.Name = "abaResult";
            this.abaResult.Size = new System.Drawing.Size(263, 23);
            this.abaResult.TabIndex = 7;
            // 
            // qtqChicken1
            // 
            this.qtqChicken1.Location = new System.Drawing.Point(211, 132);
            this.qtqChicken1.Name = "qtqChicken1";
            this.qtqChicken1.Size = new System.Drawing.Size(78, 20);
            this.qtqChicken1.TabIndex = 8;
            // 
            // qtqChicken2
            // 
            this.qtqChicken2.Location = new System.Drawing.Point(325, 132);
            this.qtqChicken2.Name = "qtqChicken2";
            this.qtqChicken2.Size = new System.Drawing.Size(79, 20);
            this.qtqChicken2.TabIndex = 9;
            // 
            // qtqChicken3
            // 
            this.qtqChicken3.Location = new System.Drawing.Point(429, 132);
            this.qtqChicken3.Name = "qtqChicken3";
            this.qtqChicken3.Size = new System.Drawing.Size(79, 20);
            this.qtqChicken3.TabIndex = 10;
            // 
            // qtqChicken5
            // 
            this.qtqChicken5.Location = new System.Drawing.Point(325, 185);
            this.qtqChicken5.Name = "qtqChicken5";
            this.qtqChicken5.Size = new System.Drawing.Size(79, 20);
            this.qtqChicken5.TabIndex = 11;
            // 
            // qtqChicken4
            // 
            this.qtqChicken4.Location = new System.Drawing.Point(211, 185);
            this.qtqChicken4.Name = "qtqChicken4";
            this.qtqChicken4.Size = new System.Drawing.Size(79, 20);
            this.qtqChicken4.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.qtqChicken4);
            this.Controls.Add(this.qtqChicken5);
            this.Controls.Add(this.qtqChicken3);
            this.Controls.Add(this.qtqChicken2);
            this.Controls.Add(this.qtqChicken1);
            this.Controls.Add(this.abaResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label abaResult;
        private System.Windows.Forms.TextBox qtqChicken1;
        private System.Windows.Forms.TextBox qtqChicken2;
        private System.Windows.Forms.TextBox qtqChicken3;
        private System.Windows.Forms.TextBox qtqChicken5;
        private System.Windows.Forms.TextBox qtqChicken4;
    }
}

