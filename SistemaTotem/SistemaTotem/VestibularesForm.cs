using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTotem
{
    public partial class VestibularesForm : Form
    {
        public VestibularesForm()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //EVENTO para voltar a tela inicial
            TelaIncialForm telaIncialForm = new TelaIncialForm();
            telaIncialForm.Show();
            this.Hide();
        }

        private void BtnVest3_Click(object sender, EventArgs e)
        {
            //vestibular provão paulista
            FormVest2 telaVest = new FormVest2();
            telaVest.Show();
            //this.Hide();
        }

        private void BtnVest1_Click(object sender, EventArgs e)
        {
            //ENEM
             FormVest1 telaVest = new FormVest1();
             telaVest.Show();
             //this.Hide();
        }

        private void BtnVest4_Click(object sender, EventArgs e)
        {
            // fuvest
            FormVest3 telaVest = new FormVest3();
            telaVest.Show();

        }
    }
}
