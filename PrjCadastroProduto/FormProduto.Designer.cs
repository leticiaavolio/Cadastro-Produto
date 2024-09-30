namespace PrjCadastroProduto
{
    partial class FormProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduto));
            lblTitulo = new Label();
            lblFoto = new Label();
            lblNome = new Label();
            lblCusto = new Label();
            lblQuant = new Label();
            lblUnidade = new Label();
            lblDesc = new Label();
            lblVenda = new Label();
            pictureBox1 = new PictureBox();
            btnImg = new Button();
            txtNome = new TextBox();
            txtUni = new TextBox();
            txtQuant = new TextBox();
            txtCusto = new TextBox();
            txtVenda = new TextBox();
            txtDesc = new TextBox();
            btnCad = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Yu Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(640, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(226, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cadastro de Produtos";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblFoto
            // 
            lblFoto.AutoSize = true;
            lblFoto.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFoto.Location = new Point(381, 105);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(135, 21);
            lblFoto.TabIndex = 1;
            lblFoto.Text = "Foto do Produto:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.Location = new Point(381, 317);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(146, 21);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome do Produto:";
            // 
            // lblCusto
            // 
            lblCusto.AutoSize = true;
            lblCusto.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCusto.Location = new Point(778, 211);
            lblCusto.Name = "lblCusto";
            lblCusto.Size = new Size(123, 21);
            lblCusto.TabIndex = 3;
            lblCusto.Text = "Valor do Custo:";
            // 
            // lblQuant
            // 
            lblQuant.AutoSize = true;
            lblQuant.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuant.Location = new Point(778, 158);
            lblQuant.Name = "lblQuant";
            lblQuant.Size = new Size(100, 21);
            lblQuant.TabIndex = 4;
            lblQuant.Text = "Quantidade:";
            // 
            // lblUnidade
            // 
            lblUnidade.AutoSize = true;
            lblUnidade.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnidade.Location = new Point(778, 105);
            lblUnidade.Name = "lblUnidade";
            lblUnidade.Size = new Size(76, 21);
            lblUnidade.TabIndex = 5;
            lblUnidade.Text = "Unidade:";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesc.Location = new Point(778, 317);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(88, 21);
            lblDesc.TabIndex = 6;
            lblDesc.Text = "Descrição:";
            // 
            // lblVenda
            // 
            lblVenda.AutoSize = true;
            lblVenda.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVenda.Location = new Point(778, 264);
            lblVenda.Name = "lblVenda";
            lblVenda.Size = new Size(125, 21);
            lblVenda.TabIndex = 7;
            lblVenda.Text = "Valor da Venda:";
            lblVenda.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(539, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnImg
            // 
            btnImg.BackColor = SystemColors.ScrollBar;
            btnImg.Cursor = Cursors.Hand;
            btnImg.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnImg.ForeColor = SystemColors.WindowFrame;
            btnImg.Location = new Point(539, 256);
            btnImg.Name = "btnImg";
            btnImg.Size = new Size(152, 33);
            btnImg.TabIndex = 9;
            btnImg.Text = "Trocar Imagem";
            btnImg.UseVisualStyleBackColor = false;
            btnImg.Click += btnImg_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ScrollBar;
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Cursor = Cursors.IBeam;
            txtNome.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = SystemColors.WindowFrame;
            txtNome.Location = new Point(533, 314);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(216, 33);
            txtNome.TabIndex = 10;
            // 
            // txtUni
            // 
            txtUni.BackColor = SystemColors.ScrollBar;
            txtUni.BorderStyle = BorderStyle.FixedSingle;
            txtUni.Cursor = Cursors.IBeam;
            txtUni.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUni.ForeColor = SystemColors.WindowFrame;
            txtUni.Location = new Point(860, 103);
            txtUni.Name = "txtUni";
            txtUni.Size = new Size(216, 33);
            txtUni.TabIndex = 11;
            // 
            // txtQuant
            // 
            txtQuant.BackColor = SystemColors.ScrollBar;
            txtQuant.BorderStyle = BorderStyle.FixedSingle;
            txtQuant.Cursor = Cursors.IBeam;
            txtQuant.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuant.ForeColor = SystemColors.WindowFrame;
            txtQuant.Location = new Point(884, 156);
            txtQuant.Name = "txtQuant";
            txtQuant.Size = new Size(216, 33);
            txtQuant.TabIndex = 12;
            // 
            // txtCusto
            // 
            txtCusto.BackColor = SystemColors.ScrollBar;
            txtCusto.BorderStyle = BorderStyle.FixedSingle;
            txtCusto.Cursor = Cursors.IBeam;
            txtCusto.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCusto.ForeColor = SystemColors.WindowFrame;
            txtCusto.Location = new Point(907, 209);
            txtCusto.Name = "txtCusto";
            txtCusto.Size = new Size(216, 33);
            txtCusto.TabIndex = 13;
            // 
            // txtVenda
            // 
            txtVenda.BackColor = SystemColors.ScrollBar;
            txtVenda.BorderStyle = BorderStyle.FixedSingle;
            txtVenda.Cursor = Cursors.IBeam;
            txtVenda.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtVenda.ForeColor = SystemColors.WindowFrame;
            txtVenda.Location = new Point(909, 262);
            txtVenda.Name = "txtVenda";
            txtVenda.Size = new Size(216, 33);
            txtVenda.TabIndex = 14;
            // 
            // txtDesc
            // 
            txtDesc.BackColor = SystemColors.ScrollBar;
            txtDesc.BorderStyle = BorderStyle.FixedSingle;
            txtDesc.Cursor = Cursors.IBeam;
            txtDesc.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDesc.ForeColor = SystemColors.WindowFrame;
            txtDesc.Location = new Point(872, 314);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(216, 33);
            txtDesc.TabIndex = 15;
            // 
            // btnCad
            // 
            btnCad.BackColor = SystemColors.ScrollBar;
            btnCad.Cursor = Cursors.Hand;
            btnCad.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCad.ForeColor = SystemColors.WindowFrame;
            btnCad.Location = new Point(640, 391);
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(226, 33);
            btnCad.TabIndex = 16;
            btnCad.Text = "Cadastrar Produto";
            btnCad.UseVisualStyleBackColor = false;
            btnCad.Click += btnCad_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(433, 441);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(641, 141);
            dataGridView1.TabIndex = 17;
            // 
            // FormProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1507, 671);
            Controls.Add(dataGridView1);
            Controls.Add(btnCad);
            Controls.Add(txtDesc);
            Controls.Add(txtVenda);
            Controls.Add(txtCusto);
            Controls.Add(txtQuant);
            Controls.Add(txtUni);
            Controls.Add(txtNome);
            Controls.Add(btnImg);
            Controls.Add(pictureBox1);
            Controls.Add(lblVenda);
            Controls.Add(lblDesc);
            Controls.Add(lblUnidade);
            Controls.Add(lblQuant);
            Controls.Add(lblCusto);
            Controls.Add(lblNome);
            Controls.Add(lblFoto);
            Controls.Add(lblTitulo);
            Name = "FormProduto";
            Text = "FormProduto";
            Load += FormProduto_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblFoto;
        private Label lblNome;
        private Label lblCusto;
        private Label lblQuant;
        private Label lblUnidade;
        private Label lblDesc;
        private Label lblVenda;
        private PictureBox pictureBox1;
        private Button btnImg;
        private TextBox txtNome;
        private TextBox txtUni;
        private TextBox txtQuant;
        private TextBox txtCusto;
        private TextBox txtVenda;
        private TextBox txtDesc;
        private Button btnCad;
        private DataGridView dataGridView1;
    }
}