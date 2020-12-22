using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p11aula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {    
            int lblDias;
            double TotalDiarias,TotalPagar,Diaria,
                TaxaQuinze,TaxaDez,TaxaCinco,
              TotTaxaQuinze,TotTaxaDez,TotTaxaCinco;

            lblDias = Convert.ToInt32(txtDias.Text);
            Diaria = 95.00;

            if(lblDias < 10) {

                TotalDiarias = lblDias * Diaria;
                TaxaQuinze = TotalDiarias * 0.15;
                TotTaxaQuinze = TaxaQuinze;
                TotalPagar = TotalDiarias + TotTaxaQuinze;
                lblRes.Text = ("Foram "+lblDias+" Dias De Hospedagem, O Valor Da Taxa De Serviço É R$ "+TotTaxaQuinze+" Reais!");
                lblRes2.Text = ("O Total a Ser Pago É R$ " + TotalPagar + " Reais!");

            } else if(lblDias == 10) {

                TotalDiarias = lblDias * Diaria;
                TaxaDez = TotalDiarias * 0.10;
                TotTaxaDez = TaxaDez;
                TotalPagar = TotalDiarias + TotTaxaDez;
                lblRes.Text = ("Foram "+lblDias+ " Dias De Hospedagem, O Valor Da Taxa De Serviço É R$ "+TotTaxaDez+" Reais!");
                lblRes2.Text = ("O Total a Ser Pago É R$ " + TotalPagar + " Reais!");

            } else {

                TotalDiarias = lblDias * Diaria;
                TaxaCinco = TotalDiarias * 0.05;
                TotTaxaCinco = TaxaCinco;
                TotalPagar = TotalDiarias + TotTaxaCinco;
                lblRes.Text = ("Foram "+lblDias+ " Dias De Hospedagem, O Valor Da Taxa De Serviço É R$ "+TotTaxaCinco+" Reais!");
                lblRes2.Text = ("O Total a Ser Pago É R$ " + TotalPagar + " Reais!");
            }

        }

        private void btbLimpar_Click(object sender, EventArgs e)
        {
            txtDias.Text = " ";
            lblRes.Text = " ";
            lblRes2.Text = " ";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
