namespace GreenvillerevenueGUI
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
            this.ltlSentence = new System.Windows.Forms.Label();
            this.blbWriten = new System.Windows.Forms.Label();
            this.lylContestants = new System.Windows.Forms.TextBox();
            this.tytContestants = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFrfMost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ltlSentence
            // 
            this.ltlSentence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltlSentence.Location = new System.Drawing.Point(36, 44);
            this.ltlSentence.Name = "ltlSentence";
            this.ltlSentence.Size = new System.Drawing.Size(450, 23);
            this.ltlSentence.TabIndex = 0;
            this.ltlSentence.Text = "Please enter the amount of contestants from last year";
            // 
            // blbWriten
            // 
            this.blbWriten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbWriten.Location = new System.Drawing.Point(39, 117);
            this.blbWriten.Name = "blbWriten";
            this.blbWriten.Size = new System.Drawing.Size(455, 23);
            this.blbWriten.TabIndex = 1;
            this.blbWriten.Text = "Please enter the amount of contestants from this year";
            // 
            // lylContestants
            // 
            this.lylContestants.Location = new System.Drawing.Point(583, 46);
            this.lylContestants.Name = "lylContestants";
            this.lylContestants.Size = new System.Drawing.Size(100, 20);
            this.lylContestants.TabIndex = 2;
            // 
            // tytContestants
            // 
            this.tytContestants.Location = new System.Drawing.Point(583, 119);
            this.tytContestants.Name = "tytContestants";
            this.tytContestants.Size = new System.Drawing.Size(100, 20);
            this.tytContestants.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(43, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(703, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Click here to see which year has the most contestants from this year and last yea" +
    "r";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFrfMost
            // 
            this.lblFrfMost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFrfMost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrfMost.Location = new System.Drawing.Point(40, 325);
            this.lblFrfMost.Name = "lblFrfMost";
            this.lblFrfMost.Size = new System.Drawing.Size(706, 30);
            this.lblFrfMost.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFrfMost);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tytContestants);
            this.Controls.Add(this.lylContestants);
            this.Controls.Add(this.blbWriten);
            this.Controls.Add(this.ltlSentence);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ltlSentence;
        private System.Windows.Forms.Label blbWriten;
        private System.Windows.Forms.TextBox lylContestants;
        private System.Windows.Forms.TextBox tytContestants;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFrfMost;
    }
}

