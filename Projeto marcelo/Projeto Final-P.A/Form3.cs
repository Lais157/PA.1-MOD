using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final_P.A
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            CadPdtTipo.SelectedIndex = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult Fechar;
            Fechar = MessageBox.Show("Deseja fechar a Matrix?", "Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(Fechar.ToString().ToLower() == "yes")
            {
                this.Hide();
                Form1 TelaInicial = new Form1();
                TelaInicial.ShowDialog();
                this.Close();
            }  
        }

        private void CadPdtLimpar_Click(object sender, EventArgs e)
        {
            CadPdtTipo.SelectedIndex = 0;
            CadPdtCodBarras.Clear();
            CadPdtDescriçao.Clear();
            CadPdtEstoque.Clear();
            CadPdtNome.Clear();
            CadPdtPreço.Clear();
            CadPdtUnidade.Clear();

        }

        private void CadPdtCadastrar_Click(object sender, EventArgs e)
        {
            string codBarras, nome, descricao, preco, estoque, unidade, tipo;
            codBarras = CadPdtCodBarras.Text;
            nome = CadPdtNome.Text;
            descricao = CadPdtDescriçao.Text;
            preco = CadPdtPreço.Text;
            estoque = CadPdtEstoque.Text;
            unidade = CadPdtUnidade.Text;
            tipo = CadPdtTipo.Text;
            bool exeption = false;
            if(exeption == false)
            {
                try
                {

                    if (string.IsNullOrWhiteSpace(codBarras))
                    {
                            throw new Exception("Campo Codigo de Barras Vazio");
                    }
                    try
                    {
                        Int64.Parse(codBarras);
                    }
                    catch
                    {
                        throw new Exception("Codigo de Barras Invalido");
                    }
                    if(codBarras.Length != 13)
                    {
                        throw new Exception("Codigo de Barras deve ter 13 Digitos");
                    }
                    if (string.IsNullOrWhiteSpace(nome))
                    {
                            throw new Exception("Campo Nome Vazio");
                    }
                    if (string.IsNullOrWhiteSpace(descricao))
                    {
                            throw new Exception("Campo Descrição Vazia");
                    }
                    if (string.IsNullOrWhiteSpace(preco))
                    {
                        throw new Exception("Campo Preço Vazio");
                    }
                    try
                    {
                        double.Parse(preco);
                    }
                    catch
                    {
                        throw new Exception("Campo Preço Invalido");
                    }
                    if (string.IsNullOrWhiteSpace(estoque))
                    {
                        throw new Exception("Campo Estoque Vazio");
                    }
                    try
                    {
                        int.Parse(estoque);
                    }
                    catch
                    {
                        throw new Exception("Campo Estoque Invalido");
                    }
                    if (string.IsNullOrWhiteSpace(unidade))
                    {
                        throw new Exception("Campo Unidade Vazio");
                    }
                    try
                    {
                        int.Parse(unidade);
                    }
                    catch
                    {
                        throw new Exception("Campo Unidade Invalido");
                    }
                    if (tipo == "Nenhum" || string.IsNullOrWhiteSpace(tipo))
                    {
                        throw new Exception("Campo Tipo Vazio");
                    }

                    MessageBox.Show("O Cadastro foi Realizado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CadPdtTipo.SelectedIndex = 0;
                    CadPdtCodBarras.Clear();
                    CadPdtDescriçao.Clear();
                    CadPdtEstoque.Clear();
                    CadPdtNome.Clear();
                    CadPdtPreço.Clear();
                    CadPdtUnidade.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Encontrei um Erro!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
