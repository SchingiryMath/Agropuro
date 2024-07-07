using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Projeto_Agropuro.Telas.PaginaClientes
{
    public partial class ClienteInicial : Form
    {
        Thread t1;
        public ClienteInicial()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e) //Botão Aparecer
        {
            guna2Panel2.Show();
            guna2ImageButton1.Hide();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e) //Botão Esconder
        {
            
            guna2Panel2.Hide();
            guna2ImageButton1.Show();
        }
    }
}
