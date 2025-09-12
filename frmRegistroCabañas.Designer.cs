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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroCabañas));
            grbTipoCabañas = new GroupBox();
            cbxDias = new ComboBox();
            lstDias = new Label();
            cbxPersonas = new ComboBox();
            lstPersonas = new Label();
            cbxTipo = new ComboBox();
            lblTipo = new Label();
            grbAdicionales = new GroupBox();
            chkAdicionales = new CheckedListBox();
            mrgTipoPago = new GroupBox();
            lblTarjeta = new Label();
            cbxTarjetas = new ComboBox();
            optTarjeta = new RadioButton();
            optEfectivo = new RadioButton();
            groupBox1 = new GroupBox();
            mtxTelefono = new MaskedTextBox();
            txtNombre = new TextBox();
            lblTelefono = new Label();
            lblNombre = new Label();
            cmdAceptar = new Button();
            cmdCancelar = new Button();
            lstRegistro = new ListBox();
            grbTipoCabañas.SuspendLayout();
            grbAdicionales.SuspendLayout();
            mrgTipoPago.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grbTipoCabañas
            // 
            grbTipoCabañas.Controls.Add(cbxDias);
            grbTipoCabañas.Controls.Add(lstDias);
            grbTipoCabañas.Controls.Add(cbxPersonas);
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
            // cbxDias
            // 
            cbxDias.FormattingEnabled = true;
            cbxDias.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cbxDias.Location = new Point(481, 45);
            cbxDias.Name = "cbxDias";
            cbxDias.Size = new Size(151, 28);
            cbxDias.TabIndex = 2;
            cbxDias.SelectedIndexChanged += cbxDias_SelectedIndexChanged;
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
            // cbxPersonas
            // 
            cbxPersonas.FormattingEnabled = true;
            cbxPersonas.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            cbxPersonas.Location = new Point(280, 44);
            cbxPersonas.Name = "cbxPersonas";
            cbxPersonas.Size = new Size(151, 28);
            cbxPersonas.TabIndex = 1;
            cbxPersonas.SelectedIndexChanged += cbxPersonas_SelectedIndexChanged;
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
            cbxTipo.Items.AddRange(new object[] { "A ", "B" });
            cbxTipo.Location = new Point(51, 39);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(151, 28);
            cbxTipo.TabIndex = 0;
            cbxTipo.SelectedIndexChanged += cbxTipo_SelectedIndexChanged;
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
            mrgTipoPago.Controls.Add(cbxTarjetas);
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
            // cbxTarjetas
            // 
            cbxTarjetas.Enabled = false;
            cbxTarjetas.FormattingEnabled = true;
            cbxTarjetas.Items.AddRange(new object[] { "Card Red", "Card Green", "Card Blue " });
            cbxTarjetas.Location = new Point(200, 81);
            cbxTarjetas.Name = "cbxTarjetas";
            cbxTarjetas.Size = new Size(151, 28);
            cbxTarjetas.TabIndex = 3;
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
            optTarjeta.CheckedChanged += optTarjeta_CheckedChanged;
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
            groupBox1.Controls.Add(mtxTelefono);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(lblTelefono);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Location = new Point(25, 307);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(645, 131);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Titular de la Reserva";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // mtxTelefono
            // 
            mtxTelefono.Location = new Point(83, 86);
            mtxTelefono.Mask = "000-000-0000";
            mtxTelefono.Name = "mtxTelefono";
            mtxTelefono.Size = new Size(294, 27);
            mtxTelefono.TabIndex = 5;
            mtxTelefono.MaskInputRejected += mtxTelefono_MaskInputRejected;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(85, 34);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(291, 27);
            txtNombre.TabIndex = 4;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(6, 85);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(71, 20);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Télefono ";
            lblTelefono.Click += lblApellido_Click;
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
            cmdAceptar.Enabled = false;
            cmdAceptar.Location = new Point(567, 451);
            cmdAceptar.Name = "cmdAceptar";
            cmdAceptar.Size = new Size(94, 29);
            cmdAceptar.TabIndex = 4;
            cmdAceptar.Text = "Aceptar";
            cmdAceptar.UseVisualStyleBackColor = true;
            cmdAceptar.Click += cmdAceptar_Click;
            // 
            // cmdCancelar
            // 
            cmdCancelar.Location = new Point(456, 451);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(94, 29);
            cmdCancelar.TabIndex = 5;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // lstRegistro
            // 
            lstRegistro.FormattingEnabled = true;
            lstRegistro.Location = new Point(12, 520);
            lstRegistro.Name = "lstRegistro";
            lstRegistro.Size = new Size(694, 104);
            lstRegistro.TabIndex = 6;
            // 
            // frmRegistroCabañas
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(718, 646);
            Controls.Add(lstRegistro);
            Controls.Add(cmdCancelar);
            Controls.Add(cmdAceptar);
            Controls.Add(groupBox1);
            Controls.Add(mrgTipoPago);
            Controls.Add(grbAdicionales);
            Controls.Add(grbTipoCabañas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmRegistroCabañas";
            Text = "Registro cabañas";
            Load += frmRegistroCabañas_Load;
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
        private ComboBox cbxPersonas;
        private Label lstPersonas;
        private GroupBox grbAdicionales;
        private CheckedListBox chkAdicionales;
        private GroupBox mrgTipoPago;
        private RadioButton optTarjeta;
        private RadioButton optEfectivo;
        private ComboBox cbxTarjetas;
        private Label lblTarjeta;
        private GroupBox groupBox1;
        private TextBox txtNombre;
        private Label lblTelefono;
        private Label lblNombre;
        private Button cmdAceptar;
        private Button cmdCancelar;
        private ComboBox cbxDias;
        private ListBox lstRegistro;
        private MaskedTextBox mtxTelefono;
    }
}
