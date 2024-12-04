namespace Proyecto_F._Costos_Empresariales
{
    partial class frmCedula4
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
            label1 = new Label();
            txtProduccionTerminada = new TextBox();
            label2 = new Label();
            txtCostoInvertarioFinal = new TextBox();
            label3 = new Label();
            txtGranTotal = new TextBox();
            btnGranTotal = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            btnInicio = new Button();
            btnCerrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(26, 62);
            label1.Name = "label1";
            label1.Size = new Size(208, 21);
            label1.TabIndex = 0;
            label1.Text = "Costo Producción Terminada";
            // 
            // txtProduccionTerminada
            // 
            txtProduccionTerminada.Location = new Point(253, 60);
            txtProduccionTerminada.Name = "txtProduccionTerminada";
            txtProduccionTerminada.Size = new Size(125, 23);
            txtProduccionTerminada.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 103);
            label2.Name = "label2";
            label2.Size = new Size(165, 21);
            label2.TabIndex = 2;
            label2.Text = "Costo Inventario Final ";
            // 
            // txtCostoInvertarioFinal
            // 
            txtCostoInvertarioFinal.Location = new Point(253, 103);
            txtCostoInvertarioFinal.Name = "txtCostoInvertarioFinal";
            txtCostoInvertarioFinal.Size = new Size(125, 23);
            txtCostoInvertarioFinal.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 174);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 4;
            label3.Text = "Gran total ";
            // 
            // txtGranTotal
            // 
            txtGranTotal.Location = new Point(152, 172);
            txtGranTotal.Name = "txtGranTotal";
            txtGranTotal.ReadOnly = true;
            txtGranTotal.Size = new Size(125, 23);
            txtGranTotal.TabIndex = 5;
            // 
            // btnGranTotal
            // 
            btnGranTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGranTotal.Location = new Point(182, 220);
            btnGranTotal.Name = "btnGranTotal";
            btnGranTotal.Size = new Size(95, 39);
            btnGranTotal.TabIndex = 6;
            btnGranTotal.Text = "Calcular";
            btnGranTotal.UseVisualStyleBackColor = true;
            btnGranTotal.Click += btnGranTotal_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnGranTotal);
            groupBox1.Controls.Add(txtProduccionTerminada);
            groupBox1.Controls.Add(txtGranTotal);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCostoInvertarioFinal);
            groupBox1.Location = new Point(187, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 286);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 19);
            label4.Name = "label4";
            label4.Size = new Size(172, 32);
            label4.TabIndex = 8;
            label4.Text = "Gran total";
            label4.Click += label4_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.LightSteelBlue;
            btnInicio.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInicio.Location = new Point(12, 53);
            btnInicio.Margin = new Padding(3, 2, 3, 2);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(151, 46);
            btnInicio.TabIndex = 31;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.LightSteelBlue;
            btnCerrar.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(12, 103);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(151, 46);
            btnCerrar.TabIndex = 32;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmCedula4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(806, 393);
            Controls.Add(btnCerrar);
            Controls.Add(btnInicio);
            Controls.Add(groupBox1);
            Name = "frmCedula4";
            Text = "Cedula4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtProduccionTerminada;
        private Label label2;
        private TextBox txtCostoInvertarioFinal;
        private Label label3;
        private TextBox txtGranTotal;
        private Button btnGranTotal;
        private GroupBox groupBox1;
        private Label label4;
        private Button btnInicio;
        private Button btnCerrar;
    }
}