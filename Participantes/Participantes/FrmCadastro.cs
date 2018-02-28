using Participantes.Banco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Participantes
{
    public partial class FrmCadastro : Form
    {
        private SpeedDB banco;
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            banco = new SpeedDB();
            dgvParticipantes.DataSource = banco.Load_DataParticipantes();
            cbPais.DataSource = banco.Load_DataPais();
            cbPais.DisplayMember = "NOME";
            cbPais.ValueMember = "cPais";
            cbPais.SelectedIndex = 30;
            Dictionary<int,string> documentoSource = new Dictionary<int,string>();
            documentoSource.Add(0, "CPF");
            documentoSource.Add(1, "CNPJ");
            cbDocumento.DataSource = new BindingSource(documentoSource, null);
            cbDocumento.DisplayMember = "Value";
            cbDocumento.ValueMember = "Key";
            cbDocumento.SelectedIndex = 0;
            txbCNPJ.Visible = false;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            PARTICIPANTES participante = new PARTICIPANTES();
            participante.COD_PART = "015001";
            participante.NOME= tbName.Text;
            participante.COD_PAIS= cbPais.SelectedValue.ToString();
            if (cbDocumento.SelectedIndex == 0)
            {
                participante.CPF = txbCPF.Text;
            } else
            {
                participante.CNPJ = txbCNPJ.Text;
            }
            participante.IE = "";
            participante.COD_MUN = "";
            participante.SUFRAMA = "";
            participante.END = "Avenida Grecia";
            participante.NUM = "";
            participante.COMPL = "";
            participante.BAIRRO = "";

            banco.Insert_intoDB(participante);
            dgvParticipantes.DataSource = banco.Load_DataParticipantes();
        }

        private void cbDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDocumento.SelectedIndex == 0)
            {
                txbCNPJ.Visible = false;
                txbCNPJ.Text = "";
                txbCPF.Visible = true;
            }
            else {
                txbCNPJ.Visible = true;
                txbCPF.Text = "";
                txbCPF.Visible = false;
            }
        }

        private void txbCNPJ_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
