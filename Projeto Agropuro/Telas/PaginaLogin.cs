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
using Projeto_Agropuro.Telas;

namespace Projeto_Agropuro
{
    public partial class PaginaLogin : Form
    {
        string EmailC = "matheussschingiry@gmail.com";
        string SenhaC = "Picapau02";
        Thread t1;
        public PaginaLogin()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e) //há conta no BD
        {
            this.Close();
            t1 = new Thread(abrirjanela);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void guna2Button2_Click(object sender, EventArgs e) //não há conta no BD
        {
        }

        private void abrirjanela(object obj)
        {
            Application.Run(new PaginaInicial());
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2ResizeBox1_Click(object sender, EventArgs e)
        {

        }

        private void PaginaLogin_Load(object sender, EventArgs e)
        {

        }

        private void ValidacaoEmail(string email)
        {

        }
    }
}
