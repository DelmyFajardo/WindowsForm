namespace calculadora_de_viajes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPuntoOrigen = new System.Windows.Forms.TextBox();
            this.txtPuntoDestino = new System.Windows.Forms.TextBox();
            this.txtVelocidadConstante = new System.Windows.Forms.TextBox();
            this.btnTiempoTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(245, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora de viajes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(218, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Punto  Origen ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(358, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Punto Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(502, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Velocidad Constante";
            // 
            // txtPuntoOrigen
            // 
            this.txtPuntoOrigen.BackColor = System.Drawing.Color.Turquoise;
            this.txtPuntoOrigen.Location = new System.Drawing.Point(208, 120);
            this.txtPuntoOrigen.Name = "txtPuntoOrigen";
            this.txtPuntoOrigen.Size = new System.Drawing.Size(97, 20);
            this.txtPuntoOrigen.TabIndex = 4;
            this.txtPuntoOrigen.Text = "m/s";
            // 
            // txtPuntoDestino
            // 
            this.txtPuntoDestino.BackColor = System.Drawing.Color.Turquoise;
            this.txtPuntoDestino.Location = new System.Drawing.Point(340, 120);
            this.txtPuntoDestino.Name = "txtPuntoDestino";
            this.txtPuntoDestino.Size = new System.Drawing.Size(115, 20);
            this.txtPuntoDestino.TabIndex = 5;
            this.txtPuntoDestino.Text = "m/s";
            // 
            // txtVelocidadConstante
            // 
            this.txtVelocidadConstante.BackColor = System.Drawing.Color.Turquoise;
            this.txtVelocidadConstante.Location = new System.Drawing.Point(492, 120);
            this.txtVelocidadConstante.Name = "txtVelocidadConstante";
            this.txtVelocidadConstante.Size = new System.Drawing.Size(129, 20);
            this.txtVelocidadConstante.TabIndex = 6;
            this.txtVelocidadConstante.Text = "m/s\'2";
            // 
            // btnTiempoTotal
            // 
            this.btnTiempoTotal.BackColor = System.Drawing.Color.Fuchsia;
            this.btnTiempoTotal.Location = new System.Drawing.Point(312, 205);
            this.btnTiempoTotal.Name = "btnTiempoTotal";
            this.btnTiempoTotal.Size = new System.Drawing.Size(174, 58);
            this.btnTiempoTotal.TabIndex = 7;
            this.btnTiempoTotal.Text = "Tiempo Total";
            this.btnTiempoTotal.UseVisualStyleBackColor = false;
            this.btnTiempoTotal.Click += new System.EventHandler(this.btnTiempoTotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTiempoTotal);
            this.Controls.Add(this.txtVelocidadConstante);
            this.Controls.Add(this.txtPuntoDestino);
            this.Controls.Add(this.txtPuntoOrigen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPuntoOrigen;
        private System.Windows.Forms.TextBox txtPuntoDestino;
        private System.Windows.Forms.TextBox txtVelocidadConstante;
        private System.Windows.Forms.Button btnTiempoTotal;
    }
}

