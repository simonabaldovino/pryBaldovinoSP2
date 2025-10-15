namespace pryBaldovinoCabaña
{
    partial class frmCabania
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
            groupBox1 = new GroupBox();
            txtDias = new TextBox();
            lblDias = new Label();
            cboPersonas = new ComboBox();
            lblPersonas = new Label();
            cboTipo = new ComboBox();
            lblTipo = new Label();
            btnAceptar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDias);
            groupBox1.Controls.Add(lblDias);
            groupBox1.Controls.Add(cboPersonas);
            groupBox1.Controls.Add(lblPersonas);
            groupBox1.Controls.Add(cboTipo);
            groupBox1.Controls.Add(lblTipo);
            groupBox1.Location = new Point(29, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 118);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de Cabaña";
            // 
            // txtDias
            // 
            txtDias.Location = new Point(403, 49);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(80, 23);
            txtDias.TabIndex = 5;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(368, 52);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(29, 15);
            lblDias.TabIndex = 4;
            lblDias.Text = "Días";
            // 
            // cboPersonas
            // 
            cboPersonas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPersonas.FormattingEnabled = true;
            cboPersonas.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cboPersonas.Location = new Point(261, 49);
            cboPersonas.Name = "cboPersonas";
            cboPersonas.Size = new Size(82, 23);
            cboPersonas.TabIndex = 3;
            // 
            // lblPersonas
            // 
            lblPersonas.AutoSize = true;
            lblPersonas.Location = new Point(201, 52);
            lblPersonas.Name = "lblPersonas";
            lblPersonas.Size = new Size(54, 15);
            lblPersonas.TabIndex = 2;
            lblPersonas.Text = "Personas";
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "Tipo A", "Tipo B ", "Tipo C" });
            cboTipo.Location = new Point(59, 49);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(121, 23);
            cboTipo.TabIndex = 1;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(23, 52);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(432, 186);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 28);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar ";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmCabania
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 450);
            Controls.Add(btnAceptar);
            Controls.Add(groupBox1);
            Name = "frmCabania";
            Text = "frmCabania";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDias;
        private Label lblDias;
        private ComboBox cboPersonas;
        private Label lblPersonas;
        private ComboBox cboTipo;
        private Label lblTipo;
        private Button btnAceptar;
    }
}