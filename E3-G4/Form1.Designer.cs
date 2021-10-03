namespace E3_G4
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LR = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.lbRespuestaC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCalcularV = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtDma = new System.Windows.Forms.TextBox();
            this.txtDm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbRombo = new System.Windows.Forms.Label();
            this.brnCalcular3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(318, 250);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LR);
            this.tabPage1.Controls.Add(this.btnCalcular);
            this.tabPage1.Controls.Add(this.txtLado);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(310, 224);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cuadrado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LR
            // 
            this.LR.AutoSize = true;
            this.LR.Location = new System.Drawing.Point(49, 151);
            this.LR.Name = "LR";
            this.LR.Size = new System.Drawing.Size(59, 13);
            this.LR.TabIndex = 3;
            this.LR.Text = "Repuesta: ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(96, 99);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(96, 57);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 20);
            this.txtLado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lado:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtRadio);
            this.tabPage2.Controls.Add(this.btnCirculo);
            this.tabPage2.Controls.Add(this.lbRespuestaC);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(310, 224);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Circulo";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(111, 36);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 20);
            this.txtRadio.TabIndex = 3;
            // 
            // btnCirculo
            // 
            this.btnCirculo.Location = new System.Drawing.Point(124, 80);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(75, 23);
            this.btnCirculo.TabIndex = 2;
            this.btnCirculo.Text = "Calcular";
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // lbRespuestaC
            // 
            this.lbRespuestaC.AutoSize = true;
            this.lbRespuestaC.Location = new System.Drawing.Point(56, 138);
            this.lbRespuestaC.Name = "lbRespuestaC";
            this.lbRespuestaC.Size = new System.Drawing.Size(64, 13);
            this.lbRespuestaC.TabIndex = 1;
            this.lbRespuestaC.Text = "Respuesta: ";
            this.lbRespuestaC.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Radio: ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCalcularV);
            this.tabPage3.Controls.Add(this.txtValor);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(310, 224);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Arreglo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCalcularV
            // 
            this.btnCalcularV.Location = new System.Drawing.Point(28, 77);
            this.btnCalcularV.Name = "btnCalcularV";
            this.btnCalcularV.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularV.TabIndex = 7;
            this.btnCalcularV.Text = "Calcular";
            this.btnCalcularV.UseVisualStyleBackColor = true;
            this.btnCalcularV.Click += new System.EventHandler(this.btnCalcularV_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(82, 33);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Valor";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.brnCalcular3);
            this.tabPage4.Controls.Add(this.lbRombo);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.txtDm);
            this.tabPage4.Controls.Add(this.txtDma);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(310, 224);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Rombo";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtDma
            // 
            this.txtDma.Location = new System.Drawing.Point(127, 34);
            this.txtDma.Name = "txtDma";
            this.txtDma.Size = new System.Drawing.Size(100, 20);
            this.txtDma.TabIndex = 0;
            // 
            // txtDm
            // 
            this.txtDm.Location = new System.Drawing.Point(127, 74);
            this.txtDm.Name = "txtDm";
            this.txtDm.Size = new System.Drawing.Size(100, 20);
            this.txtDm.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Diagonal Mayor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Diagonal Menor";
            // 
            // lbRombo
            // 
            this.lbRombo.AutoSize = true;
            this.lbRombo.Location = new System.Drawing.Point(124, 128);
            this.lbRombo.Name = "lbRombo";
            this.lbRombo.Size = new System.Drawing.Size(58, 13);
            this.lbRombo.TabIndex = 4;
            this.lbRombo.Text = "Respuesta";
            // 
            // brnCalcular3
            // 
            this.brnCalcular3.Location = new System.Drawing.Point(28, 123);
            this.brnCalcular3.Name = "brnCalcular3";
            this.brnCalcular3.Size = new System.Drawing.Size(75, 23);
            this.brnCalcular3.TabIndex = 5;
            this.brnCalcular3.Text = "Calcular";
            this.brnCalcular3.UseVisualStyleBackColor = true;
            this.brnCalcular3.Click += new System.EventHandler(this.brnCalcular3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 281);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Label lbRespuestaC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LR;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCalcularV;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button brnCalcular3;
        private System.Windows.Forms.Label lbRombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDm;
        private System.Windows.Forms.TextBox txtDma;
    }
}

