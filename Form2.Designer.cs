namespace BibIioteca
{
    partial class Form2
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
            this.lblDatos1 = new System.Windows.Forms.Label();
            this.lblDatos2 = new System.Windows.Forms.Label();
            this.lblDatos3 = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDatos1
            // 
            this.lblDatos1.AutoSize = true;
            this.lblDatos1.Location = new System.Drawing.Point(358, 134);
            this.lblDatos1.Name = "lblDatos1";
            this.lblDatos1.Size = new System.Drawing.Size(59, 25);
            this.lblDatos1.TabIndex = 0;
            this.lblDatos1.Text = "label1";
            this.lblDatos1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDatos2
            // 
            this.lblDatos2.AutoSize = true;
            this.lblDatos2.Location = new System.Drawing.Point(358, 172);
            this.lblDatos2.Name = "lblDatos2";
            this.lblDatos2.Size = new System.Drawing.Size(59, 25);
            this.lblDatos2.TabIndex = 1;
            this.lblDatos2.Text = "label1";
            // 
            // lblDatos3
            // 
            this.lblDatos3.AutoSize = true;
            this.lblDatos3.Location = new System.Drawing.Point(358, 213);
            this.lblDatos3.Name = "lblDatos3";
            this.lblDatos3.Size = new System.Drawing.Size(59, 25);
            this.lblDatos3.TabIndex = 2;
            this.lblDatos3.Text = "label2";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Location = new System.Drawing.Point(325, 56);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(133, 25);
            this.lblBienvenido.TabIndex = 3;
            this.lblBienvenido.Text = "BIENVENIDO/A";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(325, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.lblDatos3);
            this.Controls.Add(this.lblDatos2);
            this.Controls.Add(this.lblDatos1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDatos1;
        private Label lblDatos2;
        private Label lblDatos3;
        private Label lblBienvenido;
        private Button btnExit;
    }
}