using Participantes.Banco;
using Participantes.Controles;
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
            //Carrega source Participantes
            banco = new SpeedDB();
            dgvParticipantes.DataSource = banco.Load_DataParticipantes();

            //Carrega Source Pais
            cbPais.DataSource = banco.Load_DataPais();
            cbPais.DisplayMember = "NOME";
            cbPais.ValueMember = "cPais";
            cbPais.SelectedIndex = 30;

            //Carrega Source UF
            cbUF.DataSource = banco.Load_DataUF();
            cbUF.DisplayMember = "SIGLA";
            cbUF.ValueMember = "cUF";
            cbUF.SelectedIndex = 22;

            //Carrega Source Mun
            cbMun.DataSource = banco.Load_MunByUF("43");
            cbMun.DisplayMember = "NOME";
            cbMun.ValueMember = "cMun";
            cbMun.SelectedIndex = 325;

            //Cria Source Documentos
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
            ParticipantesController validador = new ParticipantesController();

            try
            {
                PARTICIPANTES participante = new PARTICIPANTES();
                if (cbDocumento.SelectedIndex == 0)
                {
                    if (validador.isCPFCNPJ(txbCPF.Text, true))
                    {
                        participante.CPF = txbCPF.Text;
                        /*
                         Validação: o valor informado no campo COD_PART deve existir em, pelo menos, um registro dos demais blocos.
                         O código de participante, campo COD_PART, é de livre atribuição do estabelecimento,
                         observado o disposto no item 2.4.2.1 do Ato COTEPE/ICMS nº 09, de 18 de abril de 2008.
                        */
                        participante.COD_PART = "0150" + participante.CPF;
                    }
                    else
                    {
                        throw new Exception("CPF não é válido. Corrija e tente de novo!");
                    }
                }
                else
                {
                    if (validador.isCPFCNPJ(txbCNPJ.Text, true))
                    {
                        participante.CNPJ = txbCNPJ.Text;
                        participante.COD_PART = "0150" + participante.CNPJ;
                    }
                    else
                    {
                        throw new Exception("CNPJ não é válido. Corrija e tente de novo!");
                    }
                }
                participante.NOME = tbName.Text;

                participante.COD_PAIS = cbPais.SelectedValue.ToString();
                /*
                 * Campo 08 (COD_MUN) - Validação: o valor informado no campo deve existir na Tabela de Municípios do IBGE
                 * (combinação do código da UF e o código de município), possuindo 7 dígitos.
                 * Obrigatório se campo COD_PAIS for igual a “01058” ou “1058”(Brasil). 
                 * Se for exterior, informar campo “vazio” ou preencher com o código “9999999”
                 */
                participante.COD_MUN = participante.COD_PAIS == "1058" ? cbMun.SelectedValue.ToString() : "9999999";

                if (String.IsNullOrEmpty(txbIE.Text) || validador.ValidarInscricaoEstadual(cbUF.Text, txbIE.Text))
                {
                    participante.IE = txbIE.Text;
                }
                else
                {
                    throw new Exception("Inscrição Estadual não é válida para a UF selecionada. Corrija e tente de novo!");
                }
                participante.SUFRAMA = "";
                participante.END = txbEnd.Text;
                participante.NUM = txbNum.Text;
                participante.COMPL = txbCompl.Text;
                participante.BAIRRO = txbBairro.Text;

                banco.Insert_intoDB(participante);
                dgvParticipantes.DataSource = banco.Load_DataParticipantes();
            }
            catch (Exception ex) {
                MessageBox.Show("Erro: " + ex.Message);
            }
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

        private void txbNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPais.SelectedValue.ToString() == "1058")
            {
                //mostra UF
                lbUF.Visible = true;
                cbUF.Visible = true;

                //mostra Municipio
                lbMun.Visible = true;
                cbMun.Visible = true;
            }
            else
            {
                //Esconde UF
                lbUF.Visible = false;
                cbUF.Visible = false;

                //Esconde Municipio
                lbMun.Visible = false;
                cbMun.Visible = false;
            }
        }

        private void cbUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMun.DataSource = banco.Load_MunByUF(cbUF.SelectedValue.ToString());
            cbMun.DisplayMember = "NOME";
            cbMun.ValueMember = "cMun";
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            string str;

            str = dgvParticipantes.Rows[dgvParticipantes.SelectedCells[0].RowIndex].Cells["COD_PART"].Value.ToString();

            banco.Exclude_fromDB(str);
            
            dgvParticipantes.DataSource = banco.Load_DataParticipantes();
        }
    }
}
