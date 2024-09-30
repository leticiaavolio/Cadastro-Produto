namespace PrjCadastroProduto
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 43);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { produtoToolStripMenuItem });
            cadastroToolStripMenuItem.Font = new Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            cadastroToolStripMenuItem.Image = (Image)resources.GetObject("cadastroToolStripMenuItem.Image");
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(162, 39);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.Font = new Font("Yu Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            produtoToolStripMenuItem.Image = (Image)resources.GetObject("produtoToolStripMenuItem.Image");
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            produtoToolStripMenuItem.Size = new Size(229, 30);
            produtoToolStripMenuItem.Text = "Produto";
            produtoToolStripMenuItem.Click += produtoToolStripMenuItem_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMenu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
    }
}