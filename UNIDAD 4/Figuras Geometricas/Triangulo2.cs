using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Figuras_Geometricas
{
    public partial class frmTriangulo : Form
    {
        Equilatero objequilatero = new Equilatero();
        Escaleno objescaleno = new Escaleno();
        Isoseles objisoseles = new Isoseles();
        public frmTriangulo()
        {

            InitializeComponent();
            txtLado.Enabled=false;
            txtLado2.Enabled = false;
            txtLado3.Enabled = false;
            txtAltura.Enabled = false;

                
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if(cmbTipo.Text=="Equilatero")
            {
                objequilatero.Tipo = (cmbTipo.Text);
                objequilatero.Lado = Convert.ToDouble(txtLado.Text);
                objequilatero.Altura = Convert.ToDouble(txtAltura.Text);
                objequilatero.CalcularPerimetro();
                objequilatero.CalcularArea();
                lblPerimetro.Text =objequilatero.Perimetro.ToString();
                lblArea.Text =objequilatero.Area.ToString();
            }
            else if(cmbTipo.Text=="Isoseles")
            {
                objisoseles.Tipo = (cmbTipo.Text);
                objisoseles.Lado = Convert.ToDouble(txtLado.Text);
                objisoseles.Lado2 = Convert.ToDouble(txtLado2.Text);
                objisoseles.Altura = Convert.ToDouble(txtAltura.Text);
                objisoseles.CalcularPerimetro();
                objisoseles.CalcularArea();
                lblPerimetro.Text =objisoseles.Perimetro.ToString();
                lblArea.Text = objisoseles.Area.ToString();
            }
            else if (cmbTipo.Text == "Escaleno")
            {
                objescaleno.Tipo = (cmbTipo.Text);
                objescaleno.Lado= Convert.ToDouble(txtLado.Text);
                objescaleno.Lado2 = Convert.ToDouble(txtLado2.Text);
                objescaleno.Lado3 = Convert.ToDouble(txtLado3.Text);
                objescaleno.Altura = Convert.ToDouble(txtAltura.Text);
                objescaleno.CalcularPerimetro();
                objescaleno.CalcularArea();
                lblPerimetro.Text =objescaleno.Perimetro.ToString();
                lblArea.Text =objescaleno.Area.ToString();
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cmbTipo.Text)
            {
                case "Equilatero":
                    txtLado.Enabled = true;
                    txtAltura.Enabled = true;
                    txtLado2.Enabled = false;
                    txtLado3.Enabled = false;
                    txtLado.Text = "";
                    txtLado2.Text = "";
                    txtLado3.Text = "";
                    txtAltura.Text = "";
                    lblArea.Text = "";
                    lblPerimetro.Text = "";                            
                    break;
                case "Escaleno":
                    txtLado.Enabled = true;
                    txtAltura.Enabled = true;
                    txtLado2.Enabled = true;
                    txtLado3.Enabled = true;
                    txtLado.Text = "";
                    txtLado2.Text = "";
                    txtLado3.Text = "";
                    txtAltura.Text = "";
                    lblArea.Text = "";
                    lblPerimetro.Text = "";
                    break;
                case "Isoseles":
                    txtLado.Enabled = true;
                    txtAltura.Enabled = true;
                    txtLado2.Enabled = true;
                    txtLado3.Enabled = false;
                    txtLado.Text = "";
                    txtLado2.Text = "";
                    txtLado3.Text = "";
                    txtAltura.Text = "";
                    lblArea.Text = "";
                    lblPerimetro.Text = "";
                    break;

            }
        }

        private void txtLado2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

