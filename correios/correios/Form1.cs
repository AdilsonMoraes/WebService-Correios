using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace correios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultaCep_Click(object sender, EventArgs e)
        {
            var Cep = new Cep();
            var Endereco = new Endereco();

            Cep.Codigo = txtCEP.Text.Replace("-", "");

            using (var correios = new Correio.AtendeClienteClient())
            {
                var consulta = correios.consultaCEP(Cep.Codigo);

                if (consulta != null)
                {
                    Endereco.EnderecoCompleto = consulta.end + "," + consulta.complemento + "," + consulta.bairro + "," + consulta.cidade + "," + consulta.uf;
                    Endereco.EnderecoCompleto = Endereco.EnderecoCompleto.Replace(",", System.Environment.NewLine);
                    lblResult.Text = Endereco.EnderecoCompleto;
                }
                else
                {
                    lblResult.Text = "CEP não encontrado.";
                }

            };

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtCEP.Text = "";
            lblResult.Text = "";
        }
    }

    public class Cep
    {
        public string Codigo { get; set; }
    }

    public class Endereco
    {
        public string EnderecoCompleto { get; set; }
    }

}
