namespace WinFormsPreco
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_produtos = new System.Windows.Forms.TextBox();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.list_produto = new System.Windows.Forms.ListBox();
            this.list_preco = new System.Windows.Forms.ListBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.lbl_res = new System.Windows.Forms.Label();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produtos";
            // 
            // txt_produtos
            // 
            this.txt_produtos.Location = new System.Drawing.Point(108, 25);
            this.txt_produtos.Name = "txt_produtos";
            this.txt_produtos.Size = new System.Drawing.Size(157, 22);
            this.txt_produtos.TabIndex = 1;
            this.txt_produtos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(108, 53);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(157, 22);
            this.txt_preco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preco";
            // 
            // list_produto
            // 
            this.list_produto.FormattingEnabled = true;
            this.list_produto.ItemHeight = 16;
            this.list_produto.Items.AddRange(new object[] {
            "Lista Produtos"});
            this.list_produto.Location = new System.Drawing.Point(21, 130);
            this.list_produto.Name = "list_produto";
            this.list_produto.Size = new System.Drawing.Size(230, 228);
            this.list_produto.TabIndex = 4;
            this.list_produto.SelectedIndexChanged += new System.EventHandler(this.list_produto_SelectedIndexChanged);
            // 
            // list_preco
            // 
            this.list_preco.FormattingEnabled = true;
            this.list_preco.ItemHeight = 16;
            this.list_preco.Items.AddRange(new object[] {
            "Lista Preco"});
            this.list_preco.Location = new System.Drawing.Point(275, 130);
            this.list_preco.Name = "list_preco";
            this.list_preco.Size = new System.Drawing.Size(230, 228);
            this.list_preco.TabIndex = 5;
            // 
            // btn_remove
            // 
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.Location = new System.Drawing.Point(179, 381);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(174, 39);
            this.btn_remove.TabIndex = 6;
            this.btn_remove.Text = "remover";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_res
            // 
            this.lbl_res.AutoSize = true;
            this.lbl_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_res.ForeColor = System.Drawing.Color.Red;
            this.lbl_res.Location = new System.Drawing.Point(621, 210);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(189, 29);
            this.lbl_res.TabIndex = 7;
            this.lbl_res.Text = "Total de Vendas";
            // 
            // btn_enviar
            // 
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.Location = new System.Drawing.Point(292, 25);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(125, 39);
            this.btn_enviar.TabIndex = 8;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(573, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Clique sobre o produto na lista produto, e depois em remover para deletar um prod" +
    "uto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.list_preco);
            this.Controls.Add(this.list_produto);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_produtos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_produtos;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox list_produto;
        private System.Windows.Forms.ListBox list_preco;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Label label3;
    }
}

