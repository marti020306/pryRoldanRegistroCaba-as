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
            //limpiar checklist
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
           

            CalcularPago();
        }

        private void cbxPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDias.SelectedIndex <= 0)
            {
                cmdAceptar.Enabled = true;
            }
            else
            {
                cmdAceptar.Enabled = false;
            }
        }

        private void frmRegistroCabañas_Load(object sender, EventArgs e)
        {
            cbxTipo.SelectedIndex = 0;
            cbxPersonas.SelectedIndex = 0;
            cbxDias.SelectedIndex = 0;
            optEfectivo.Checked = true;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.TextLength > 0)
            {
                cmdAceptar.Enabled = true;
            }
            else
            {
                cmdAceptar.Enabled = false;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.TextLength > 0)
            {
                cmdAceptar.Enabled = true;
            }
            else
            {
                cmdAceptar.Enabled = false;
            }
        }

        private void CalcularPago()

        {
           int PrecioBase = 0;
           int maxpersonas = 0;
           int personas = Convert.ToInt32(cbxPersonas.SelectedItem);


           if (cbxTipo.SelectedItem.ToString().Contains("A"))
            {
                PrecioBase = 20;
                maxpersonas = 4;
            }

           else if ( cbxTipo.SelectedItem.ToString().Contains("B"))
            {
                PrecioBase = 34;
                maxpersonas = 8;
            }

           if ( personas > maxpersonas)
            {
                MessageBox.Show("La cabaña tipo" + " "+ cbxTipo.SelectedItem+
                    "permite un maximo de"+ " " + maxpersonas + " "+ "PERSONAS");
                return;
                

            }

        }
    }
}
