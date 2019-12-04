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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Cliente = new Form2();
            Cliente.ShowDialog();
            this.Close();
        }

        private void Btn_Produtos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 Product = new Form3();
            Product.ShowDialog();
            this.Close();
        }
    }
}
