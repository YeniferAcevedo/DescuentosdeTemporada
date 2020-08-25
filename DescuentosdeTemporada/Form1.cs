using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DescuentosdeTemporada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorCompra = double.Parse(txtValorCompra.Text);
            double valorDescuento;
            double valorFinal;
            string descuento;

            switch (cmbTemporada.SelectedItem){
                case "Escolar":

                    if (valorCompra <= 100000){
                        descuento = "0%";
                        valorFinal = valorCompra;
                        lblDescuento.Text = descuento;
                        lblValorFinal.Text = Convert.ToString(string.Format("{0:n0}", valorFinal));
                    }
                    else if (valorCompra > 100001 && valorCompra <= 300000){
                        descuento = "10%";
                        valorDescuento = valorCompra * 0.1 - valorCompra;
                        valorFinal = valorDescuento * (-1);
                        lblDescuento.Text = descuento;
                        lblValorFinal.Text = Convert.ToString(string.Format("{0:n0}", valorFinal));
                    }
                    else if (valorCompra > 300000){
                        descuento = "15%";
                        valorDescuento = valorCompra * 0.15 - valorCompra;
                        valorFinal = valorDescuento * (-1);
                        lblDescuento.Text = descuento;
                        lblValorFinal.Text = Convert.ToString(string.Format("{0:n0}", valorFinal));
                    }
                    lblDescuento.Visible = true;
                    lblValorFinal.Visible = true;
                    break;

                case "Halloween":
                    if (valorCompra > 50 && valorCompra <= 30000){
                        descuento = "0%";
                        valorFinal = valorCompra;
                        lblDescuento.Text = descuento;
                        lblValorFinal.Text = Convert.ToString(string.Format("{0:n0}", valorFinal));    
                    }
                    else if (valorCompra > 30001 && valorCompra <= 200000){
                        descuento = "2%";
                        valorDescuento = valorCompra * 0.02 - valorCompra;
                        valorFinal = valorDescuento * (-1);
                        lblDescuento.Text = descuento;
                        lblValorFinal.Text = Convert.ToString(string.Format("{0:n0}", valorFinal));
                    }
                    else if (valorCompra > 200001){
                        descuento = "5%";
                        valorDescuento = valorCompra * 0.05 - valorCompra;
                        valorFinal = valorDescuento * (-1);
                        lblDescuento.Text = descuento;
                        lblValorFinal.Text = Convert.ToString(string.Format("{0:n0}", valorFinal));
                    }
                    lblDescuento.Visible = true;
                    lblValorFinal.Visible = true;
                    break;

                case "Diciembre":
                    if (valorCompra > 50 && valorCompra <= 300000){
                        descuento = "0%";
                        valorFinal = valorCompra;
                        lblDescuento.Text = descuento;
                        lblValorFinal.Text = Convert.ToString(string.Format("{0:n0}", valorFinal));
                    }
                    else if (valorCompra > 300001 && valorCompra <= 500000){
                        descuento = "5%";
                        valorDescuento = valorCompra * 0.05 - valorCompra;
                        valorFinal = valorDescuento * (-1);
                        lblDescuento.Text = descuento;
                        lblValorFinal.Text = Convert.ToString(string.Format("{0:n0}", valorFinal));
                    }
                    else if (valorCompra > 500001){
                        descuento = "10%";
                        valorDescuento = valorCompra * 0.1 - valorCompra;
                        valorFinal = valorDescuento * (-1);
                        lblDescuento.Text = descuento;
                        lblValorFinal.Text = Convert.ToString(string.Format("{0:n0}", valorFinal)); 
                    }
                    lblDescuento.Visible = true;
                    lblValorFinal.Visible = true;
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTemporada.SelectedIndex = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValorCompra.Text = string.Empty;
            cmbTemporada.Text = string.Empty;
            lblDescuento.Text = " ";
            lblValorFinal.Text = " ";
            txtValorCompra.Focus();
        }
    }
}

