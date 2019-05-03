namespace FourCalculation.UI
{
    partial class frmMainForm
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
            this.btnToplama = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.btnCıkarma = new System.Windows.Forms.Button();
            this.btnBolme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToplama
            // 
            this.btnToplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToplama.Location = new System.Drawing.Point(271, 108);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(125, 55);
            this.btnToplama.TabIndex = 0;
            this.btnToplama.Tag = "+";
            this.btnToplama.Text = "Toplama";
            this.btnToplama.UseVisualStyleBackColor = true;
            this.btnToplama.Click += new System.EventHandler(this.openButtonsHandler);
            // 
            // btnCarpma
            // 
            this.btnCarpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCarpma.Location = new System.Drawing.Point(271, 194);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(125, 55);
            this.btnCarpma.TabIndex = 1;
            this.btnCarpma.Tag = "*";
            this.btnCarpma.Text = "Carpma";
            this.btnCarpma.UseVisualStyleBackColor = true;
            this.btnCarpma.Click += new System.EventHandler(this.openButtonsHandler);
            // 
            // btnCıkarma
            // 
            this.btnCıkarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCıkarma.Location = new System.Drawing.Point(455, 108);
            this.btnCıkarma.Name = "btnCıkarma";
            this.btnCıkarma.Size = new System.Drawing.Size(125, 55);
            this.btnCıkarma.TabIndex = 2;
            this.btnCıkarma.Tag = "-";
            this.btnCıkarma.Text = "Cıkarma";
            this.btnCıkarma.UseVisualStyleBackColor = true;
            this.btnCıkarma.Click += new System.EventHandler(this.openButtonsHandler);
            // 
            // btnBolme
            // 
            this.btnBolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolme.Location = new System.Drawing.Point(455, 194);
            this.btnBolme.Name = "btnBolme";
            this.btnBolme.Size = new System.Drawing.Size(125, 55);
            this.btnBolme.TabIndex = 3;
            this.btnBolme.Tag = "/";
            this.btnBolme.Text = "Bolme";
            this.btnBolme.UseVisualStyleBackColor = true;
            this.btnBolme.Click += new System.EventHandler(this.openButtonsHandler);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.btnBolme);
            this.Controls.Add(this.btnCıkarma);
            this.Controls.Add(this.btnCarpma);
            this.Controls.Add(this.btnToplama);
            this.Name = "frmMainForm";
            this.Text = "Basic Maths Transaction";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.Button btnCarpma;
        private System.Windows.Forms.Button btnCıkarma;
        private System.Windows.Forms.Button btnBolme;
    }
}

