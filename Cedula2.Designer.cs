namespace Proyecto_F._Costos_Empresariales
{
    partial class Cedula2
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
            btnCalculate = new Button();
            btnNext = new Button();
            txtCostoTPT = new TextBox();
            label1 = new Label();
            txtCostoTCI = new TextBox();
            label6 = new Label();
            txtCostoTMO = new TextBox();
            label4 = new Label();
            txtCostoTMP = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Silver;
            btnCalculate.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(489, 229);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(173, 62);
            btnCalculate.TabIndex = 30;
            btnCalculate.Text = "inicio";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Silver;
            btnNext.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(489, 306);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(173, 62);
            btnNext.TabIndex = 29;
            btnNext.Text = "Siguiente Cedula";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // txtCostoTPT
            // 
            txtCostoTPT.Font = new Font("Tahoma", 12F);
            txtCostoTPT.Location = new Point(477, 132);
            txtCostoTPT.Name = "txtCostoTPT";
            txtCostoTPT.Size = new Size(185, 32);
            txtCostoTPT.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F);
            label1.Location = new Point(430, 97);
            label1.Name = "label1";
            label1.Size = new Size(347, 24);
            label1.TabIndex = 27;
            label1.Text = "Costo Total De Produccion Terminada";
            // 
            // txtCostoTCI
            // 
            txtCostoTCI.Font = new Font("Tahoma", 12F);
            txtCostoTCI.Location = new Point(54, 363);
            txtCostoTCI.Name = "txtCostoTCI";
            txtCostoTCI.Size = new Size(186, 32);
            txtCostoTCI.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F);
            label6.Location = new Point(24, 324);
            label6.Name = "label6";
            label6.Size = new Size(284, 24);
            label6.TabIndex = 25;
            label6.Text = "Costo Total  Costos Indirectos:";
            // 
            // txtCostoTMO
            // 
            txtCostoTMO.Font = new Font("Tahoma", 12F);
            txtCostoTMO.Location = new Point(54, 243);
            txtCostoTMO.Name = "txtCostoTMO";
            txtCostoTMO.Size = new Size(186, 32);
            txtCostoTMO.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.Location = new Point(24, 207);
            label4.Name = "label4";
            label4.Size = new Size(256, 24);
            label4.TabIndex = 23;
            label4.Text = "Costo Total  Mano de Obra:";
            // 
            // txtCostoTMP
            // 
            txtCostoTMP.Font = new Font("Tahoma", 12F);
            txtCostoTMP.Location = new Point(54, 132);
            txtCostoTMP.Name = "txtCostoTMP";
            txtCostoTMP.Size = new Size(186, 32);
            txtCostoTMP.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(24, 97);
            label2.Name = "label2";
            label2.Size = new Size(249, 24);
            label2.TabIndex = 21;
            label2.Text = "Costo Total Materia Prima:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(24, 28);
            label3.Name = "label3";
            label3.Size = new Size(154, 24);
            label3.TabIndex = 31;
            label3.Text = "Produccion Final";
            // 
            // Cedula2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(848, 464);
            Controls.Add(label3);
            Controls.Add(btnCalculate);
            Controls.Add(btnNext);
            Controls.Add(txtCostoTPT);
            Controls.Add(label1);
            Controls.Add(txtCostoTCI);
            Controls.Add(label6);
            Controls.Add(txtCostoTMO);
            Controls.Add(label4);
            Controls.Add(txtCostoTMP);
            Controls.Add(label2);
            Name = "Cedula2";
            Text = "Cedula2";
            Load += Cedula2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Button btnNext;
        private TextBox txtCostoTPT;
        private Label label1;
        private TextBox txtCostoTCI;
        private Label label6;
        private TextBox txtCostoTMO;
        private Label label4;
        private TextBox txtCostoTMP;
        private Label label2;
        private Label label3;
    }
}