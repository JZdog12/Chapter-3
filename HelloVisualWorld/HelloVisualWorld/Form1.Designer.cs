namespace HelloVisualWorld
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
            this.btnClickHere = new System.Windows.Forms.Button();
            this.lblHello = new System.Windows.Forms.Label();
            this.btnGoodbye = new System.Windows.Forms.Button();
            this.btnReallyLast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClickHere
            // 
            this.btnClickHere.Location = new System.Drawing.Point(145, 165);
            this.btnClickHere.Name = "btnClickHere";
            this.btnClickHere.Size = new System.Drawing.Size(75, 23);
            this.btnClickHere.TabIndex = 0;
            this.btnClickHere.Text = "Click Here";
            this.btnClickHere.UseVisualStyleBackColor = true;
            this.btnClickHere.Click += new System.EventHandler(this.btnClickHere_Click);
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(142, 75);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(99, 13);
            this.lblHello.TabIndex = 1;
            this.lblHello.Text = "Hello, Visual World!";
            this.lblHello.Visible = false;
            // 
            // btnGoodbye
            // 
            this.btnGoodbye.Location = new System.Drawing.Point(145, 219);
            this.btnGoodbye.Name = "btnGoodbye";
            this.btnGoodbye.Size = new System.Drawing.Size(75, 23);
            this.btnGoodbye.TabIndex = 2;
            this.btnGoodbye.Text = "Click Me Last";
            this.btnGoodbye.UseVisualStyleBackColor = true;
            this.btnGoodbye.Click += new System.EventHandler(this.btnGoodbye_Click);
            // 
            // btnReallyLast
            // 
            this.btnReallyLast.Location = new System.Drawing.Point(145, 278);
            this.btnReallyLast.Name = "btnReallyLast";
            this.btnReallyLast.Size = new System.Drawing.Size(75, 23);
            this.btnReallyLast.TabIndex = 3;
            this.btnReallyLast.Text = "No Really Click Me Last";
            this.btnReallyLast.UseVisualStyleBackColor = true;
            this.btnReallyLast.Click += new System.EventHandler(this.btnReallyLast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReallyLast);
            this.Controls.Add(this.btnGoodbye);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.btnClickHere);
            this.Name = "Form1";
            this.Text = "Hello Visual World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickHere;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Button btnGoodbye;
        private System.Windows.Forms.Button btnReallyLast;
    }
}

