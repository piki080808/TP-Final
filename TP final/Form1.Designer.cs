namespace TP_final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnSigno = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbResultado
            // 
            this.tbResultado.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbResultado.ForeColor = System.Drawing.Color.Red;
            this.tbResultado.Location = new System.Drawing.Point(12, 12);
            this.tbResultado.MaxLength = 20;
            this.tbResultado.Multiline = true;
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.ReadOnly = true;
            this.tbResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbResultado.Size = new System.Drawing.Size(315, 40);
            this.tbResultado.TabIndex = 0;
            this.tbResultado.Text = "0";
            this.tbResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.BackColor = System.Drawing.Color.Silver;
            this.btnBorrarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrarTodo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorrarTodo.ForeColor = System.Drawing.Color.Teal;
            this.btnBorrarTodo.Location = new System.Drawing.Point(12, 58);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(75, 43);
            this.btnBorrarTodo.TabIndex = 1;
            this.btnBorrarTodo.Text = "CE";
            this.btnBorrarTodo.UseVisualStyleBackColor = false;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Silver;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.ForeColor = System.Drawing.Color.Teal;
            this.btnBorrar.Location = new System.Drawing.Point(93, 58);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 43);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "C";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.BackColor = System.Drawing.Color.Silver;
            this.btnRaiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRaiz.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRaiz.ForeColor = System.Drawing.Color.Teal;
            this.btnRaiz.Location = new System.Drawing.Point(174, 58);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(75, 43);
            this.btnRaiz.TabIndex = 3;
            this.btnRaiz.Tag = "√";
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = false;
            this.btnRaiz.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.BackColor = System.Drawing.Color.Silver;
            this.btnCuadrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCuadrado.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCuadrado.ForeColor = System.Drawing.Color.Teal;
            this.btnCuadrado.Location = new System.Drawing.Point(255, 58);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(75, 43);
            this.btnCuadrado.TabIndex = 4;
            this.btnCuadrado.Tag = "²";
            this.btnCuadrado.Text = "x²";
            this.btnCuadrado.UseVisualStyleBackColor = false;
            this.btnCuadrado.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnSiete
            // 
            this.btnSiete.BackColor = System.Drawing.Color.Silver;
            this.btnSiete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiete.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSiete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSiete.Location = new System.Drawing.Point(12, 107);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(75, 56);
            this.btnSiete.TabIndex = 5;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = false;
            this.btnSiete.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnOcho
            // 
            this.btnOcho.BackColor = System.Drawing.Color.Silver;
            this.btnOcho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOcho.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOcho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOcho.Location = new System.Drawing.Point(93, 107);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(75, 56);
            this.btnOcho.TabIndex = 6;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = false;
            this.btnOcho.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnNueve
            // 
            this.btnNueve.BackColor = System.Drawing.Color.Silver;
            this.btnNueve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNueve.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNueve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnNueve.Location = new System.Drawing.Point(174, 107);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(75, 56);
            this.btnNueve.TabIndex = 7;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = false;
            this.btnNueve.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnCuatro
            // 
            this.btnCuatro.BackColor = System.Drawing.Color.Silver;
            this.btnCuatro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCuatro.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCuatro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCuatro.Location = new System.Drawing.Point(12, 169);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(75, 56);
            this.btnCuatro.TabIndex = 8;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = false;
            this.btnCuatro.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnCinco
            // 
            this.btnCinco.BackColor = System.Drawing.Color.Silver;
            this.btnCinco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCinco.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCinco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCinco.Location = new System.Drawing.Point(93, 169);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(75, 56);
            this.btnCinco.TabIndex = 9;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = false;
            this.btnCinco.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnSeis
            // 
            this.btnSeis.BackColor = System.Drawing.Color.Silver;
            this.btnSeis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeis.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSeis.Location = new System.Drawing.Point(174, 169);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(75, 56);
            this.btnSeis.TabIndex = 10;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = false;
            this.btnSeis.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnUno
            // 
            this.btnUno.BackColor = System.Drawing.Color.Silver;
            this.btnUno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUno.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUno.Location = new System.Drawing.Point(12, 231);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(75, 56);
            this.btnUno.TabIndex = 11;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = false;
            this.btnUno.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnDos
            // 
            this.btnDos.BackColor = System.Drawing.Color.Silver;
            this.btnDos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDos.Location = new System.Drawing.Point(93, 231);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(75, 56);
            this.btnDos.TabIndex = 12;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = false;
            this.btnDos.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.Color.Silver;
            this.btnTres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTres.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTres.Location = new System.Drawing.Point(174, 231);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(75, 56);
            this.btnTres.TabIndex = 13;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = false;
            this.btnTres.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnSigno
            // 
            this.btnSigno.BackColor = System.Drawing.Color.Silver;
            this.btnSigno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSigno.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSigno.ForeColor = System.Drawing.Color.Teal;
            this.btnSigno.Location = new System.Drawing.Point(12, 293);
            this.btnSigno.Name = "btnSigno";
            this.btnSigno.Size = new System.Drawing.Size(75, 56);
            this.btnSigno.TabIndex = 14;
            this.btnSigno.Text = "+/-";
            this.btnSigno.UseVisualStyleBackColor = false;
            this.btnSigno.Click += new System.EventHandler(this.btnSigno_Click);
            // 
            // btnCero
            // 
            this.btnCero.BackColor = System.Drawing.Color.Silver;
            this.btnCero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCero.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCero.Location = new System.Drawing.Point(93, 293);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(75, 56);
            this.btnCero.TabIndex = 15;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = false;
            this.btnCero.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnPunto
            // 
            this.btnPunto.BackColor = System.Drawing.Color.Silver;
            this.btnPunto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPunto.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPunto.ForeColor = System.Drawing.Color.Teal;
            this.btnPunto.Location = new System.Drawing.Point(174, 293);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(75, 56);
            this.btnPunto.TabIndex = 16;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = false;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.Silver;
            this.btnDividir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDividir.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDividir.ForeColor = System.Drawing.Color.Teal;
            this.btnDividir.Location = new System.Drawing.Point(255, 107);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 43);
            this.btnDividir.TabIndex = 17;
            this.btnDividir.Tag = "/";
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.Silver;
            this.btnMultiplicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMultiplicar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplicar.ForeColor = System.Drawing.Color.Teal;
            this.btnMultiplicar.Location = new System.Drawing.Point(255, 156);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 43);
            this.btnMultiplicar.TabIndex = 18;
            this.btnMultiplicar.Tag = "X";
            this.btnMultiplicar.Text = "X";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.Color.Silver;
            this.btnMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenos.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenos.ForeColor = System.Drawing.Color.Teal;
            this.btnMenos.Location = new System.Drawing.Point(255, 205);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(75, 43);
            this.btnMenos.TabIndex = 19;
            this.btnMenos.Tag = "-";
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.Silver;
            this.btnSuma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuma.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSuma.ForeColor = System.Drawing.Color.Teal;
            this.btnSuma.Location = new System.Drawing.Point(255, 254);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 43);
            this.btnSuma.TabIndex = 20;
            this.btnSuma.Tag = "+";
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.Silver;
            this.btnIgual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIgual.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIgual.ForeColor = System.Drawing.Color.Red;
            this.btnIgual.Location = new System.Drawing.Point(255, 306);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(75, 43);
            this.btnIgual.TabIndex = 21;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TP_final.Properties.Resources.IMG_20160202_WA0005;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(335, 360);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnSigno);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnCuadrado);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.tbResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbResultado;
        private Button btnBorrarTodo;
        private Button btnBorrar;
        private Button btnRaiz;
        private Button btnCuadrado;
        private Button btnSiete;
        private Button btnOcho;
        private Button btnNueve;
        private Button btnCuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnUno;
        private Button btnDos;
        private Button btnTres;
        private Button btnSigno;
        private Button btnCero;
        private Button btnPunto;
        private Button btnDividir;
        private Button btnMultiplicar;
        private Button btnMenos;
        private Button btnSuma;
        private Button btnIgual;
    }
}