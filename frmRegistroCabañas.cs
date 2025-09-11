namespace pryRoldanRegistroCabañas
{
    public partial class frmRegistroCabañas : Form
    {
        public frmRegistroCabañas()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            cbxTipo.SelectedIndex = 0;
            cbxPersonas.SelectedIndex = 0;
            cbxDias.SelectedIndex = 0;
            // Limpiar todos los ítems seleccionados en el CheckedListBox
            for (int i = 0; i < chkAdicionales.Items.Count; i++)
            {
                chkAdicionales.SetItemChecked(i, false);
            }
            optEfectivo.Checked = true;
            optTarjeta.Checked = false;
            cbxTarjetas.Enabled = false;
            txtNombre.Clear();
            txtApellido.Clear();
            cmdAceptar.Enabled = false;
            cbxTipo.Focus();
        }

        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (optTarjeta.Checked != false)
            {
                cbxTarjetas.Enabled = true;
            }
            else
            {
                cbxTarjetas.Enabled = false;
                cbxTarjetas.SelectedIndex = -1;
            }
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipo.SelectedIndex != -1)
            {
                chkAdicionales.Enabled = true;
                cmdAceptar.Enabled = true;
            }
            else
            {
                chkAdicionales.Enabled = false;
                cmdAceptar.Enabled = false;
            }
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (cbxTipo.SelectedIndex == 0)
            {

            }
        }
    }
}
