using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPreco
{
    public partial class Form1 : Form
    {
        public decimal res = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subtrair(list_produto.SelectedIndex);
            list_preco.Items.RemoveAt(list_produto.SelectedIndex);
            list_produto.Items.RemoveAt(list_produto.SelectedIndex);
        }
        public void Subtrair(int index)
        {
            string sub = list_preco.Items[index].ToString();
            res -= Decimal.Parse(sub);
            lbl_res.Text = res.ToString();
            LimpaCampos();
        }
        public void LimpaCampos()
        {
            txt_produtos.Text = "";
            txt_preco.Text = "";
            txt_produtos.Focus();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            if (txt_preco.Text != "" && txt_produtos.Text != "")
            {
                list_preco.Items.Add(txt_preco.Text);
                list_produto.Items.Add(txt_produtos.Text);
                res += Decimal.Parse(txt_preco.Text);
                lbl_res.Text = "R$" + res.ToString();
                LimpaCampos();
            }
            else
            {
                MessageBox.Show("Campo Produto ou Preço não Preenchido");
                txt_produtos.Focus();
            }
        }
        private void list_produto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
