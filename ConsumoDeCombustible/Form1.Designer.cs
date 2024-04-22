namespace ConsumoDeCombustible
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtconsumo = new System.Windows.Forms.Label();
            this.lblDistanciaRecorrida = new System.Windows.Forms.Label();
            this.txtDistanciaRec = new System.Windows.Forms.TextBox();
            this.lblRendimiento = new System.Windows.Forms.Label();
            this.txtRendimiento = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtconsumo
            // 
            this.txtconsumo.AutoSize = true;
            this.txtconsumo.BackColor = System.Drawing.Color.Coral;
            this.txtconsumo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtconsumo.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconsumo.Location = new System.Drawing.Point(217, 41);
            this.txtconsumo.Name = "txtconsumo";
            this.txtconsumo.Size = new System.Drawing.Size(329, 33);
            this.txtconsumo.TabIndex = 0;
            this.txtconsumo.Text = "Consumo de Combustible";
            // 
            // lblDistanciaRecorrida
            // 
            this.lblDistanciaRecorrida.AutoSize = true;
            this.lblDistanciaRecorrida.BackColor = System.Drawing.Color.Gold;
            this.lblDistanciaRecorrida.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDistanciaRecorrida.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDistanciaRecorrida.Location = new System.Drawing.Point(184, 163);
            this.lblDistanciaRecorrida.Name = "lblDistanciaRecorrida";
            this.lblDistanciaRecorrida.Size = new System.Drawing.Size(97, 15);
            this.lblDistanciaRecorrida.TabIndex = 1;
            this.lblDistanciaRecorrida.Text = "Distancia recorrida";
            // 
            // txtDistanciaRec
            // 
            this.txtDistanciaRec.Location = new System.Drawing.Point(164, 140);
            this.txtDistanciaRec.Name = "txtDistanciaRec";
            this.txtDistanciaRec.Size = new System.Drawing.Size(139, 20);
            this.txtDistanciaRec.TabIndex = 2;
            this.txtDistanciaRec.Text = "Km";
            this.txtDistanciaRec.TextChanged += new System.EventHandler(this.txtDistanciaRec_TextChanged);
            // 
            // lblRendimiento
            // 
            this.lblRendimiento.AutoSize = true;
            this.lblRendimiento.BackColor = System.Drawing.Color.Gold;
            this.lblRendimiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRendimiento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRendimiento.Location = new System.Drawing.Point(478, 163);
            this.lblRendimiento.Name = "lblRendimiento";
            this.lblRendimiento.Size = new System.Drawing.Size(68, 15);
            this.lblRendimiento.TabIndex = 3;
            this.lblRendimiento.Text = "Rendimiento";
            // 
            // txtRendimiento
            // 
            this.txtRendimiento.Location = new System.Drawing.Point(447, 140);
            this.txtRendimiento.Name = "txtRendimiento";
            this.txtRendimiento.Size = new System.Drawing.Size(136, 20);
            this.txtRendimiento.TabIndex = 4;
            this.txtRendimiento.Text = "Km/Gal";
            this.txtRendimiento.TextChanged += new System.EventHandler(this.txtRendimiento_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(270, 206);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(220, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = ":El total de  comsumo de gasolina es";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.Color.Crimson;
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltotal.Location = new System.Drawing.Point(361, 267);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbltotal.Size = new System.Drawing.Size(48, 15);
            this.lbltotal.TabIndex = 6;
            this.lbltotal.Text = "             ";
            this.lbltotal.Click += new System.EventHandler(this.lbltotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRendimiento);
            this.Controls.Add(this.lblRendimiento);
            this.Controls.Add(this.txtDistanciaRec);
            this.Controls.Add(this.lblDistanciaRecorrida);
            this.Controls.Add(this.txtconsumo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtconsumo;
        private System.Windows.Forms.Label lblDistanciaRecorrida;
        private System.Windows.Forms.TextBox txtDistanciaRec;
        private System.Windows.Forms.Label lblRendimiento;
        private System.Windows.Forms.TextBox txtRendimiento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbltotal;
    }
}

