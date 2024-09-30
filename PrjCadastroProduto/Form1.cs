namespace PrjCadastroProduto
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduto objProduto = new FormProduto();
            objProduto.ShowDialog();
        }
    }
}