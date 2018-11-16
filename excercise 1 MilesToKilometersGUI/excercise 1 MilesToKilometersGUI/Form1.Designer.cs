namespace excercise_1_MilesToKilometersGUI
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
            this.lblread = new System.Windows.Forms.Label();
            this.mlmMiles = new System.Windows.Forms.TextBox();
            this.btbCalculate = new System.Windows.Forms.Button();
            this.frfKilometer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblread
            // 
            this.lblread.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblread.Location = new System.Drawing.Point(81, 78);
            this.lblread.Name = "lblread";
            this.lblread.Size = new System.Drawing.Size(375, 23);
            this.lblread.TabIndex = 0;
            this.lblread.Text = "Please enter the amount of miles in the box";
            // 
            // mlmMiles
            // 
            this.mlmMiles.Location = new System.Drawing.Point(558, 78);
            this.mlmMiles.Name = "mlmMiles";
            this.mlmMiles.Size = new System.Drawing.Size(100, 20);
            this.mlmMiles.TabIndex = 1;
            // 
            // btbCalculate
            // 
            this.btbCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbCalculate.Location = new System.Drawing.Point(225, 188);
            this.btbCalculate.Name = "btbCalculate";
            this.btbCalculate.Size = new System.Drawing.Size(375, 55);
            this.btbCalculate.TabIndex = 2;
            this.btbCalculate.Text = "Click here to find the amount of kilometers";
            this.btbCalculate.UseVisualStyleBackColor = true;
            this.btbCalculate.Click += new System.EventHandler(this.btbCalculate_Click);
            // 
            // frfKilometer
            // 
            this.frfKilometer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.frfKilometer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frfKilometer.Location = new System.Drawing.Point(225, 291);
            this.frfKilometer.Name = "frfKilometer";
            this.frfKilometer.Size = new System.Drawing.Size(375, 107);
            this.frfKilometer.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frfKilometer);
            this.Controls.Add(this.btbCalculate);
            this.Controls.Add(this.mlmMiles);
            this.Controls.Add(this.lblread);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblread;
        private System.Windows.Forms.TextBox mlmMiles;
        private System.Windows.Forms.Button btbCalculate;
        private System.Windows.Forms.Label frfKilometer;
    }
}

