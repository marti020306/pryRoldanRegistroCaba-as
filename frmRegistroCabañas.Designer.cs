namespace pryRoldanRegistroCabañas
{
    partial class frmRegistroCabañas
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
            grbTipoCabañas = new GroupBox();
            mtbDias = new MaskedTextBox();
            lstDias = new Label();
            comboBox1 = new ComboBox();
            lstPersonas = new Label();
            cbxTipo = new ComboBox();
            lblTipo = new Label();
            grbAdicionales = new GroupBox();
            chkAdicionales = new CheckedListBox();
            mrgTipoPago = new GroupBox();
            lblTarjeta = new Label();
            comboBox2 = new ComboBox();
            optTarjeta = new RadioButton();
            optEfectivo = new RadioButton();
            groupBox1 = new GroupBox();
            txt = new TextBox();
            txtNombre = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            cmdAceptar = new Button();
            cmdCancelar = new Button();
            grbTipoCabañas.SuspendLayout();
            grbAdicionales.SuspendLayout();
            mrgTipoPago.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grbTipoCabañas
            // 
            grbTipoCabañas.Controls.Add(mtbDias);
            grbTipoCabañas.Controls.Add(lstDias);
            grbTipoCabañas.Controls.Add(comboBox1);
            grbTipoCabañas.Controls.Add(lstPersonas);
            grbTipoCabañas.Controls.Add(cbxTipo);
            grbTipoCabañas.Controls.Add(lblTipo);
            grbTipoCabañas.Location = new Point(19, 16);
            grbTipoCabañas.Name = "grbTipoCabañas";
            grbTipoCabañas.Size = new Size(652, 111);
            grbTipoCabañas.TabIndex = 0;
            grbTipoCabañas.TabStop = false;
            grbTipoCabañas.Text = "Tipo de cabañas ";
            // 
            // mtbDias
            // 
            mtbDias.Location = new Point(481, 47);
            mtbDias.Mask = "99999";
            mtbDias.Name = "mtbDias";
            mtbDias.Size = new Size(125, 27);
            mtbDias.TabIndex = 2;
            mtbDias.ValidatingType = typeof(int);
            // 
            // lstDias
            // 
            lstDias.AutoSize = true;
            lstDias.Location = new Point(437, 50);
            lstDias.Name = "lstDias";
            lstDias.Size = new Size(38, 20);
            lstDias.TabIndex = 1;
            lstDias.Text = "Días";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(280, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // lstPersonas
            // 
            lstPersonas.AutoSize = true;
            lstPersonas.Location = new Point(208, 45);
            lstPersonas.Name = "lstPersonas";
            lstPersonas.Size = new Size(66, 20);
            lstPersonas.TabIndex = 1;
            lstPersonas.Text = "Personas";
            // 
            // cbxTipo
            // 
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Items.AddRange(new object[] { "Estandar", "Familiar", "Rustica ", "Con pileta" });
            cbxTipo.Location = new Point(51, 39);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(151, 28);
            cbxTipo.TabIndex = 1;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(6, 39);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 20);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo";
            // 
            // grbAdicionales
            // 
            grbAdicionales.Controls.Add(chkAdicionales);
            grbAdicionales.Location = new Point(19, 146);
            grbAdicionales.Name = "grbAdicionales";
            grbAdicionales.Size = new Size(183, 140);
            grbAdicionales.TabIndex = 1;
            grbAdicionales.TabStop = false;
            grbAdicionales.Text = "Adicionales";
            // 
            // chkAdicionales
            // 
            chkAdicionales.BackColor = SystemColors.Menu;
            chkAdicionales.BorderStyle = BorderStyle.None;
            chkAdicionales.ForeColor = SystemColors.InactiveCaptionText;
            chkAdicionales.FormattingEnabled = true;
            chkAdicionales.Items.AddRange(new object[] { "Heladera", "Televisores", "Cocina " });
            chkAdicionales.Location = new Point(23, 36);
            chkAdicionales.Name = "chkAdicionales";
            chkAdicionales.Size = new Size(104, 88);
            chkAdicionales.TabIndex = 2;
            // 
            // mrgTipoPago
            // 
            mrgTipoPago.Controls.Add(lblTarjeta);
            mrgTipoPago.Controls.Add(comboBox2);
            mrgTipoPago.Controls.Add(optTarjeta);
            mrgTipoPago.Controls.Add(optEfectivo);
            mrgTipoPago.Location = new Point(239, 161);
            mrgTipoPago.Name = "mrgTipoPago";
            mrgTipoPago.Size = new Size(432, 125);
            mrgTipoPago.TabIndex = 2;
            mrgTipoPago.TabStop = false;
            mrgTipoPago.Text = "Tipo de Pago";
            // 
            // lblTarjeta
            // 
            lblTarjeta.AutoSize = true;
            lblTarjeta.Location = new Point(200, 47);
            lblTarjeta.Name = "lblTarjeta";
            lblTarjeta.Size = new Size(59, 20);
            lblTarjeta.TabIndex = 4;
            lblTarjeta.Text = "Tarjetas";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Debito", "Credito " });
            comboBox2.Location = new Point(200, 81);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 3;
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Location = new Point(20, 56);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(74, 24);
            optTarjeta.TabIndex = 1;
            optTarjeta.TabStop = true;
            optTarjeta.Text = "Tarjeta";
            optTarjeta.UseVisualStyleBackColor = true;
            // 
            // optEfectivo
            // 
            optEfectivo.AutoSize = true;
            optEfectivo.Location = new Point(20, 26);
            optEfectivo.Name = "optEfectivo";
            optEfectivo.Size = new Size(83, 24);
            optEfectivo.TabIndex = 0;
            optEfectivo.TabStop = true;
            optEfectivo.Text = "Efectivo";
            optEfectivo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(lblApellido);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Location = new Point(25, 307);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(645, 131);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Titular de la Reserva";
            // 
            // txt
            // 
            txt.Location = new Point(82, 82);
            txt.Name = "txt";
            txt.Size = new Size(294, 27);
            txt.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(85, 34);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(291, 27);
            txtNombre.TabIndex = 4;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(6, 85);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(70, 20);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // cmdAceptar
            // 
            cmdAceptar.Location = new Point(567, 451);
            cmdAceptar.Name = "cmdAceptar";
            cmdAceptar.Size = new Size(94, 29);
            cmdAceptar.TabIndex = 4;
            cmdAceptar.Text = "Aceptar";
            cmdAceptar.UseVisualStyleBackColor = true;
            // 
            // cmdCancelar
            // 
            cmdCancelar.Location = new Point(456, 451);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(94, 29);
            cmdCancelar.TabIndex = 5;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // frmRegistroCabañas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(702, 492);
            Controls.Add(cmdCancelar);
            Controls.Add(cmdAceptar);
            Controls.Add(groupBox1);
            Controls.Add(mrgTipoPago);
            Controls.Add(grbAdicionales);
            Controls.Add(grbTipoCabañas);
            Name = "frmRegistroCabañas";
            Text = "Registro cabañas";
            grbTipoCabañas.ResumeLayout(false);
            grbTipoCabañas.PerformLayout();
            grbAdicionales.ResumeLayout(false);
            mrgTipoPago.ResumeLayout(false);
            mrgTipoPago.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbTipoCabañas;
        private Label lblTipo;
        private ComboBox cbxTipo;
        private Label lstDias;
        private ComboBox comboBox1;
        private Label lstPersonas;
        private MaskedTextBox mtbDias;
        private GroupBox grbAdicionales;
        private CheckedListBox chkAdicionales;
        private GroupBox mrgTipoPago;
        private RadioButton optTarjeta;
        private RadioButton optEfectivo;
        private ComboBox comboBox2;
        private Label lblTarjeta;
        private GroupBox groupBox1;
        private TextBox txt;
        private TextBox txtNombre;
        private Label lblApellido;
        private Label lblNombre;
        private Button cmdAceptar;
        private Button cmdCancelar;
    }
}
