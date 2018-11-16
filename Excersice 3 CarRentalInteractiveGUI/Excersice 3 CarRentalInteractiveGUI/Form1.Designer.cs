namespace Excersice_3_CarRentalInteractiveGUI
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
            this.thtDescription = new System.Windows.Forms.Label();
            this.lrlWriten = new System.Windows.Forms.Label();
            this.amaDays = new System.Windows.Forms.TextBox();
            this.nfnMiles = new System.Windows.Forms.TextBox();
            this.clcResult = new System.Windows.Forms.Button();
            this.apaPay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thtDescription
            // 
            this.thtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thtDescription.Location = new System.Drawing.Point(26, 58);
            this.thtDescription.Name = "thtDescription";
            this.thtDescription.Size = new System.Drawing.Size(435, 23);
            this.thtDescription.TabIndex = 0;
            this.thtDescription.Text = "Please enter the amount of days you had the rental";
            // 
            // lrlWriten
            // 
            this.lrlWriten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lrlWriten.Location = new System.Drawing.Point(30, 136);
            this.lrlWriten.Name = "lrlWriten";
            this.lrlWriten.Size = new System.Drawing.Size(534, 27);
            this.lrlWriten.TabIndex = 1;
            this.lrlWriten.Text = "Please enter the amount of miles you have gone with the rental";
            // 
            // amaDays
            // 
            this.amaDays.Location = new System.Drawing.Point(631, 58);
            this.amaDays.Name = "amaDays";
            this.amaDays.Size = new System.Drawing.Size(100, 20);
            this.amaDays.TabIndex = 2;
            // 
            // nfnMiles
            // 
            this.nfnMiles.Location = new System.Drawing.Point(631, 141);
            this.nfnMiles.Name = "nfnMiles";
            this.nfnMiles.Size = new System.Drawing.Size(100, 20);
            this.nfnMiles.TabIndex = 3;
            // 
            // clcResult
            // 
            this.clcResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clcResult.Location = new System.Drawing.Point(159, 213);
            this.clcResult.Name = "clcResult";
            this.clcResult.Size = new System.Drawing.Size(511, 37);
            this.clcResult.TabIndex = 4;
            this.clcResult.Text = "Click here to see the amount you need to pay for the rental";
            this.clcResult.UseVisualStyleBackColor = true;
            this.clcResult.Click += new System.EventHandler(this.clcPay_Click);
            // 
            // apaPay
            // 
            this.apaPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.apaPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apaPay.Location = new System.Drawing.Point(12, 319);
            this.apaPay.Name = "apaPay";
            this.apaPay.Size = new System.Drawing.Size(776, 48);
            this.apaPay.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.apaPay);
            this.Controls.Add(this.clcResult);
            this.Controls.Add(this.nfnMiles);
            this.Controls.Add(this.amaDays);
            this.Controls.Add(this.lrlWriten);
            this.Controls.Add(this.thtDescription);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label thtDescription;
        private System.Windows.Forms.Label lrlWriten;
        private System.Windows.Forms.TextBox amaDays;
        private System.Windows.Forms.TextBox nfnMiles;
        private System.Windows.Forms.Button clcResult;
        private System.Windows.Forms.Label apaPay;
    }
}

