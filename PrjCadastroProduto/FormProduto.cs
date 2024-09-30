using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjCadastroProduto
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }
        Image fotoProduto;
        string NomeP;
        string UnidadeP;
        string QuantP;
        string CustoP;
        string VendaP;
        string DescP;

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de Imagem(*.jpg; *.jpeg; *.png) | *.jpg; *.jpeg; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fotoProduto = Image.FromFile(ofd.FileName);
                pictureBox1.Image = fotoProduto;
            }
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Nome", "Nome");
            dataGridView1.Columns.Add("Unidade", "Unidade");
            dataGridView1.Columns.Add("Quantidade", "Quantidade");
            dataGridView1.Columns.Add("Custo", "Valor de Custo");
            dataGridView1.Columns.Add("Venda", "Valor de Venda");
            dataGridView1.Columns.Add("Descrição", "Descrição");

        }
        private void btnCad_Click(object sender, EventArgs e)
        {
            NomeP = txtNome.Text;
            UnidadeP = txtUni.Text;
            QuantP = txtQuant.Text;
            CustoP = txtCusto.Text;
            VendaP = txtVenda.Text;
            DescP = txtDesc.Text;

            dataGridView1.Rows.Add(NomeP, UnidadeP, QuantP, CustoP, VendaP, DescP);
        }
    }
}
