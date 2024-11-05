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
    public partial class EventosForm : Form
    {
        public EventosForm()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {

            //EVENTO para voltar a tela inicial
            TelaIncialForm telaIncialForm = new TelaIncialForm();
            telaIncialForm.Show();
            this.Hide();
        }

        private void BtnEve1_Click(object sender, EventArgs e)
        {
            //primeiro evento tela de edicao
            FormEdicaoEvento1 formEdicaoEvento1 = new FormEdicaoEvento1();  
            formEdicaoEvento1.Show();

        }

        private void BtnEve2_Click(object sender, EventArgs e)
        {
           //evento dois
           FormEdicaoEvento2 form  = new FormEdicaoEvento2();
           form.Show();

        }

        private void BtnEve3_Click(object sender, EventArgs e)
        {
            //evento tres 
            FormEdicaoEvento3 form = new FormEdicaoEvento3();
            form.Show();
        }

        private void BtnEve4_Click(object sender, EventArgs e)
        {
            //evento quatro
            FormEdicaoEvento4 form = new FormEdicaoEvento4();
            form.Show();
        }

        private void BtnEve5_Click(object sender, EventArgs e)
        {
            //evento quinto
            FormEdicaoEvento5  form = new FormEdicaoEvento5();
            form.Show();
        }

        private void BtnEve6_Click(object sender, EventArgs e)
        {
            //evento sexto
            FormEdicaoEvento6 form = new FormEdicaoEvento6();
            form.Show();
        }

        private void BtnEve7_Click(object sender, EventArgs e)
        {
            //evento sete
            FormEdicaoEvento7 form  = new FormEdicaoEvento7();
            form.Show();
        }
    }
}
