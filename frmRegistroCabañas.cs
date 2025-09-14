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
            if (MessageBox.Show("¿Desea cancelar el registro?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                 LimpiarControles();
            }

           
            
        }

        private void LimpiarControles()
        {
            txtNombre.Clear();
            mtxTelefono.Clear();
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
            mtxTelefono.Clear();
            cmdAceptar.Enabled = false;
            cbxTipo.Focus();
            lstRegistro.Items.Clear();

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
                cmdAceptar.Enabled = false;
            }
            else

            {
                cmdAceptar.Enabled = true;
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

        

        private void CalcularPago()

        {
            int PrecioBase = 0;
            int maxpersonas = 0;
            int personas = Convert.ToInt32(cbxPersonas.SelectedItem);
            Decimal PrecioDiario = 0;
            string Adicionales = "";

            if (cbxTipo.SelectedItem.ToString().Contains("A"))
            {
                    PrecioBase = 20;
                    maxpersonas = 4;
            }

            else if (cbxTipo.SelectedItem.ToString().Contains("B"))
            {
                PrecioBase = 34;
                maxpersonas = 8;
            }

            if (personas > maxpersonas)
            {
                MessageBox.Show("La cabaña tipo" + " " + cbxTipo.SelectedItem +
                    "permite un maximo de" + " " + maxpersonas + " " + "PERSONAS");
                return;


            }

            PrecioDiario = PrecioBase + personas;


            for (int i = 0; i < chkAdicionales.Items.Count; i++)
            {
                if (chkAdicionales.GetItemChecked(i))
                {
                    Adicionales = Adicionales + chkAdicionales.Items[i].ToString();

                    if (Adicionales.Contains("Cocina"))
                    {
                        PrecioDiario += 1m;
                    }

                    else if (Adicionales.Contains("Heladera"))
                    {
                        PrecioDiario += 1.5m;
                    }

                    else if (Adicionales.Contains("Television"))
                    {
                        PrecioDiario += 2m;
                    }

                    else if (Adicionales.Contains("Sin Adicionales"))

                    {
                        PrecioDiario += 0;
                        Adicionales = "Sin Adicionales";
                    }



                        int Dias = Convert.ToInt32(cbxDias.SelectedItem);

                    Decimal PrecioFinal = PrecioDiario * Dias;
                    string Recargo = "";
                    string formaPago = "Efectivo";

                    if ( optEfectivo.Checked)

                    {
                        formaPago = "Efectivo";
                        PrecioFinal = PrecioFinal + 0;

                        Recargo = "Sin Recargo";
                    }
                    if (optTarjeta.Checked)
                    {
                        formaPago = cbxTarjetas.SelectedItem.ToString();

                        if (formaPago == "Card Blue")
                        {
                            PrecioFinal = PrecioFinal * 1.20m;
                            Recargo = "20%";

                        }

                        else if ( formaPago == "Card Green")
                        {
                            PrecioFinal = PrecioFinal * 1.20m;
                            Recargo = "20%";
                        }

                        else if ( formaPago == "Card Red")
                        {
                            PrecioFinal = PrecioFinal * 1.10m;
                            Recargo = "10%";
                        }
                    }


                    //Prguntar sobre lstRegistro cuando apretas 2 adicionales


                    lstRegistro.Items.Add("Nombre:" + " " + txtNombre.Text);
                    lstRegistro.Items.Add("Télefono: " + " " + mtxTelefono.Text);
                    lstRegistro.Items.Add("Tipo de Cabaña: " + cbxTipo.SelectedItem);
                    lstRegistro.Items.Add("Personas: " + cbxPersonas.SelectedItem);
                    lstRegistro.Items.Add("Días: " + cbxDias.SelectedItem);
                    lstRegistro.Items.Add("Adicionales: " + Adicionales);
                    lstRegistro.Items.Add("Forma de pago: " + formaPago);
                    lstRegistro.Items.Add("Recargo: " + Recargo);
                    lstRegistro.Items.Add("Precio diario: U$S " + PrecioDiario);
                    lstRegistro.Items.Add("Precio total: U$S " + PrecioFinal);
                   








                }

                }
            }        

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void mtxTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtxTelefono.TextLength > 0)
            {
                cmdAceptar.Enabled = true;
            }
            else
            {
                cmdAceptar.Enabled = false;
            }
        }
    }
}
