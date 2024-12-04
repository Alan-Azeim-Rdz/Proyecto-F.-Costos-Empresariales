namespace Proyecto_F._Costos_Empresariales
{
    partial class Cedula3
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
            txtCostoTCI = new TextBox();
            label6 = new Label();
            txtCostoTMO = new TextBox();
            label4 = new Label();
            txtCostoTMP = new TextBox();
            label2 = new Label();
            txtCostoTIF = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtCostoTCI
            // 
            txtCostoTCI.Font = new Font("Tahoma", 12F);
            txtCostoTCI.Location = new Point(30, 330);
            txtCostoTCI.Name = "txtCostoTCI";
            txtCostoTCI.Size = new Size(249, 32);
            txtCostoTCI.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F);
            label6.Location = new Point(30, 295);
            label6.Name = "label6";
            label6.Size = new Size(284, 24);
            label6.TabIndex = 15;
            label6.Text = "Costo Total  Costos Indirectos:";
            // 
            // txtCostoTMO
            // 
            txtCostoTMO.Font = new Font("Tahoma", 12F);
            txtCostoTMO.Location = new Point(30, 213);
            txtCostoTMO.Name = "txtCostoTMO";
            txtCostoTMO.Size = new Size(249, 32);
            txtCostoTMO.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.Location = new Point(30, 178);
            label4.Name = "label4";
            label4.Size = new Size(256, 24);
            label4.TabIndex = 13;
            label4.Text = "Costo Total  Mano de Obra:";
            // 
            // txtCostoTMP
            // 
            txtCostoTMP.Font = new Font("Tahoma", 12F);
            txtCostoTMP.Location = new Point(30, 103);
            txtCostoTMP.Name = "txtCostoTMP";
            txtCostoTMP.Size = new Size(249, 32);
            txtCostoTMP.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(30, 68);
            label2.Name = "label2";
            label2.Size = new Size(249, 24);
            label2.TabIndex = 11;
            label2.Text = "Costo Total Materia Prima:";
            // 
            // txtCostoTIF
            // 
            txtCostoTIF.Font = new Font("Tahoma", 12F);
            txtCostoTIF.Location = new Point(436, 103);
            txtCostoTIF.Name = "txtCostoTIF";
            txtCostoTIF.Size = new Size(249, 32);
            txtCostoTIF.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F);
            label1.Location = new Point(436, 68);
            label1.Name = "label1";
            label1.Size = new Size(295, 24);
            label1.TabIndex = 17;
            label1.Text = "Costo Total De Inventario Final:";
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(645, 364);
            button1.Name = "button1";
            button1.Size = new Size(173, 62);
            button1.TabIndex = 19;
            button1.Text = "Siguiente Cedula";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Font = new Font("Segoe UI Symbol", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(645, 266);
            button2.Name = "button2";
            button2.Size = new Size(173, 62);
            button2.TabIndex = 20;
            button2.Text = "Inicio";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Cedula3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(121, 134, 203);
            ClientSize = new Size(894, 463);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtCostoTIF);
            Controls.Add(label1);
            Controls.Add(txtCostoTCI);
            Controls.Add(label6);
            Controls.Add(txtCostoTMO);
            Controls.Add(label4);
            Controls.Add(txtCostoTMP);
            Controls.Add(label2);
            Name = "Cedula3";
            Text = "Cedula3";
            Load += Cedula3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCostoTCI;
        private Label label6;
        private TextBox txtCostoTMO;
        private Label label4;
        private TextBox txtCostoTMP;
        private Label label2;
        private TextBox txtCostoTIF;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}