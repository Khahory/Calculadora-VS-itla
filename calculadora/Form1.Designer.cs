namespace calculadora
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
            this.tbox_resultado = new System.Windows.Forms.TextBox();
            this.bt_uno = new System.Windows.Forms.Button();
            this.bt_seis = new System.Windows.Forms.Button();
            this.bt_nueve = new System.Windows.Forms.Button();
            this.bt_cero = new System.Windows.Forms.Button();
            this.bt_ocho = new System.Windows.Forms.Button();
            this.bt_siete = new System.Windows.Forms.Button();
            this.bt_cinco = new System.Windows.Forms.Button();
            this.bt_cuadro = new System.Windows.Forms.Button();
            this.bt_tres = new System.Windows.Forms.Button();
            this.bt_dos = new System.Windows.Forms.Button();
            this.bt_punto = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_mas = new System.Windows.Forms.Button();
            this.bt_dividir = new System.Windows.Forms.Button();
            this.bt_multiplicar = new System.Windows.Forms.Button();
            this.bt_menos = new System.Windows.Forms.Button();
            this.bt_igualdad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbox_resultado
            // 
            this.tbox_resultado.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_resultado.Location = new System.Drawing.Point(12, 29);
            this.tbox_resultado.Name = "tbox_resultado";
            this.tbox_resultado.Size = new System.Drawing.Size(345, 34);
            this.tbox_resultado.TabIndex = 0;
            this.tbox_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bt_uno
            // 
            this.bt_uno.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_uno.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_uno.Location = new System.Drawing.Point(12, 84);
            this.bt_uno.Name = "bt_uno";
            this.bt_uno.Size = new System.Drawing.Size(64, 64);
            this.bt_uno.TabIndex = 1;
            this.bt_uno.Text = "1";
            this.bt_uno.UseVisualStyleBackColor = true;
            this.bt_uno.Click += new System.EventHandler(this.bt_uno_Click);
            // 
            // bt_seis
            // 
            this.bt_seis.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_seis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_seis.Location = new System.Drawing.Point(153, 154);
            this.bt_seis.Name = "bt_seis";
            this.bt_seis.Size = new System.Drawing.Size(64, 64);
            this.bt_seis.TabIndex = 2;
            this.bt_seis.Text = "6";
            this.bt_seis.UseVisualStyleBackColor = true;
            this.bt_seis.Click += new System.EventHandler(this.bt_seis_Click);
            // 
            // bt_nueve
            // 
            this.bt_nueve.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nueve.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_nueve.Location = new System.Drawing.Point(153, 223);
            this.bt_nueve.Name = "bt_nueve";
            this.bt_nueve.Size = new System.Drawing.Size(64, 64);
            this.bt_nueve.TabIndex = 3;
            this.bt_nueve.Text = "9";
            this.bt_nueve.UseVisualStyleBackColor = true;
            this.bt_nueve.Click += new System.EventHandler(this.bt_nueve_Click);
            // 
            // bt_cero
            // 
            this.bt_cero.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cero.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cero.Location = new System.Drawing.Point(13, 293);
            this.bt_cero.Name = "bt_cero";
            this.bt_cero.Size = new System.Drawing.Size(134, 64);
            this.bt_cero.TabIndex = 4;
            this.bt_cero.Text = "0";
            this.bt_cero.UseVisualStyleBackColor = true;
            this.bt_cero.Click += new System.EventHandler(this.bt_cero_Click);
            // 
            // bt_ocho
            // 
            this.bt_ocho.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ocho.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_ocho.Location = new System.Drawing.Point(83, 223);
            this.bt_ocho.Name = "bt_ocho";
            this.bt_ocho.Size = new System.Drawing.Size(64, 64);
            this.bt_ocho.TabIndex = 5;
            this.bt_ocho.Text = "8";
            this.bt_ocho.UseVisualStyleBackColor = true;
            this.bt_ocho.Click += new System.EventHandler(this.bt_ocho_Click);
            // 
            // bt_siete
            // 
            this.bt_siete.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_siete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_siete.Location = new System.Drawing.Point(13, 223);
            this.bt_siete.Name = "bt_siete";
            this.bt_siete.Size = new System.Drawing.Size(64, 64);
            this.bt_siete.TabIndex = 6;
            this.bt_siete.Text = "7";
            this.bt_siete.UseVisualStyleBackColor = true;
            this.bt_siete.Click += new System.EventHandler(this.bt_siete_Click);
            // 
            // bt_cinco
            // 
            this.bt_cinco.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cinco.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cinco.Location = new System.Drawing.Point(83, 154);
            this.bt_cinco.Name = "bt_cinco";
            this.bt_cinco.Size = new System.Drawing.Size(64, 64);
            this.bt_cinco.TabIndex = 7;
            this.bt_cinco.Text = "5";
            this.bt_cinco.UseVisualStyleBackColor = true;
            this.bt_cinco.Click += new System.EventHandler(this.bt_cinco_Click);
            // 
            // bt_cuadro
            // 
            this.bt_cuadro.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cuadro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_cuadro.Location = new System.Drawing.Point(13, 154);
            this.bt_cuadro.Name = "bt_cuadro";
            this.bt_cuadro.Size = new System.Drawing.Size(64, 64);
            this.bt_cuadro.TabIndex = 8;
            this.bt_cuadro.Text = "4";
            this.bt_cuadro.UseVisualStyleBackColor = true;
            this.bt_cuadro.Click += new System.EventHandler(this.bt_cuadro_Click);
            // 
            // bt_tres
            // 
            this.bt_tres.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tres.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_tres.Location = new System.Drawing.Point(152, 84);
            this.bt_tres.Name = "bt_tres";
            this.bt_tres.Size = new System.Drawing.Size(64, 64);
            this.bt_tres.TabIndex = 9;
            this.bt_tres.Text = "3";
            this.bt_tres.UseVisualStyleBackColor = true;
            this.bt_tres.Click += new System.EventHandler(this.bt_tres_Click);
            // 
            // bt_dos
            // 
            this.bt_dos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_dos.Location = new System.Drawing.Point(82, 84);
            this.bt_dos.Name = "bt_dos";
            this.bt_dos.Size = new System.Drawing.Size(64, 64);
            this.bt_dos.TabIndex = 10;
            this.bt_dos.Text = "2";
            this.bt_dos.UseVisualStyleBackColor = true;
            this.bt_dos.Click += new System.EventHandler(this.bt_dos_Click);
            // 
            // bt_punto
            // 
            this.bt_punto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_punto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_punto.Location = new System.Drawing.Point(153, 293);
            this.bt_punto.Name = "bt_punto";
            this.bt_punto.Size = new System.Drawing.Size(64, 64);
            this.bt_punto.TabIndex = 11;
            this.bt_punto.Text = ".";
            this.bt_punto.UseVisualStyleBackColor = true;
            this.bt_punto.Click += new System.EventHandler(this.bt_punto_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_clear.Location = new System.Drawing.Point(223, 84);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(134, 64);
            this.bt_clear.TabIndex = 12;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_mas
            // 
            this.bt_mas.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_mas.Location = new System.Drawing.Point(223, 154);
            this.bt_mas.Name = "bt_mas";
            this.bt_mas.Size = new System.Drawing.Size(64, 64);
            this.bt_mas.TabIndex = 14;
            this.bt_mas.Text = "+";
            this.bt_mas.UseVisualStyleBackColor = true;
            this.bt_mas.Click += new System.EventHandler(this.bt_mas_Click);
            // 
            // bt_dividir
            // 
            this.bt_dividir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dividir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_dividir.Location = new System.Drawing.Point(293, 223);
            this.bt_dividir.Name = "bt_dividir";
            this.bt_dividir.Size = new System.Drawing.Size(64, 64);
            this.bt_dividir.TabIndex = 15;
            this.bt_dividir.Text = "/";
            this.bt_dividir.UseVisualStyleBackColor = true;
            this.bt_dividir.Click += new System.EventHandler(this.bt_dividir_Click);
            // 
            // bt_multiplicar
            // 
            this.bt_multiplicar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_multiplicar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_multiplicar.Location = new System.Drawing.Point(223, 223);
            this.bt_multiplicar.Name = "bt_multiplicar";
            this.bt_multiplicar.Size = new System.Drawing.Size(64, 64);
            this.bt_multiplicar.TabIndex = 16;
            this.bt_multiplicar.Text = "*";
            this.bt_multiplicar.UseVisualStyleBackColor = true;
            this.bt_multiplicar.Click += new System.EventHandler(this.bt_multiplicar_Click);
            // 
            // bt_menos
            // 
            this.bt_menos.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_menos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_menos.Location = new System.Drawing.Point(293, 154);
            this.bt_menos.Name = "bt_menos";
            this.bt_menos.Size = new System.Drawing.Size(64, 64);
            this.bt_menos.TabIndex = 17;
            this.bt_menos.Text = "-";
            this.bt_menos.UseVisualStyleBackColor = true;
            this.bt_menos.Click += new System.EventHandler(this.bt_menos_Click);
            // 
            // bt_igualdad
            // 
            this.bt_igualdad.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_igualdad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_igualdad.Location = new System.Drawing.Point(223, 293);
            this.bt_igualdad.Name = "bt_igualdad";
            this.bt_igualdad.Size = new System.Drawing.Size(134, 64);
            this.bt_igualdad.TabIndex = 18;
            this.bt_igualdad.Text = "=";
            this.bt_igualdad.UseVisualStyleBackColor = true;
            this.bt_igualdad.Click += new System.EventHandler(this.bt_igualdad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 371);
            this.Controls.Add(this.bt_cero);
            this.Controls.Add(this.bt_igualdad);
            this.Controls.Add(this.bt_menos);
            this.Controls.Add(this.bt_multiplicar);
            this.Controls.Add(this.bt_dividir);
            this.Controls.Add(this.bt_mas);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_punto);
            this.Controls.Add(this.bt_dos);
            this.Controls.Add(this.bt_tres);
            this.Controls.Add(this.bt_cuadro);
            this.Controls.Add(this.bt_cinco);
            this.Controls.Add(this.bt_siete);
            this.Controls.Add(this.bt_ocho);
            this.Controls.Add(this.bt_nueve);
            this.Controls.Add(this.bt_seis);
            this.Controls.Add(this.bt_uno);
            this.Controls.Add(this.tbox_resultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_resultado;
        private System.Windows.Forms.Button bt_uno;
        private System.Windows.Forms.Button bt_seis;
        private System.Windows.Forms.Button bt_nueve;
        private System.Windows.Forms.Button bt_cero;
        private System.Windows.Forms.Button bt_ocho;
        private System.Windows.Forms.Button bt_siete;
        private System.Windows.Forms.Button bt_cinco;
        private System.Windows.Forms.Button bt_cuadro;
        private System.Windows.Forms.Button bt_tres;
        private System.Windows.Forms.Button bt_dos;
        private System.Windows.Forms.Button bt_punto;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_mas;
        private System.Windows.Forms.Button bt_dividir;
        private System.Windows.Forms.Button bt_multiplicar;
        private System.Windows.Forms.Button bt_menos;
        private System.Windows.Forms.Button bt_igualdad;
    }
}

