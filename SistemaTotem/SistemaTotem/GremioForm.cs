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
    public partial class GremioForm : Form
    {
        public GremioForm()
        {
            InitializeComponent();
        }

        private void GremioForm_Load(object sender, EventArgs e)
        {

        }

        private void Foto10_Click(object sender, EventArgs e)
        {
            EdicaoMembrosGremio10 edicaoMembrosGremio10 = new EdicaoMembrosGremio10();
            edicaoMembrosGremio10.Show();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //EVENTO para voltar a tela inicial
           TelaIncialForm telaIncialForm = new TelaIncialForm();
           telaIncialForm.Show();
           this.Hide();

        }

        private void Membro1_Click(object sender, EventArgs e)
        {
            //evento editar membro
            EdicaoMembroGremio edicaoMembroGremio = new EdicaoMembroGremio();
            edicaoMembroGremio.Show();
        }

        private void Membro2_Click(object sender, EventArgs e)
        {
            EdicaoMembrosGremio2 edicaoMembrosGremio2 = new EdicaoMembrosGremio2();
            edicaoMembrosGremio2.Show();
        }

        private void Membro3_Click(object sender, EventArgs e)
        {
            EdicaoMembrosGremio3 ed = new EdicaoMembrosGremio3();
            ed.Show();
        }

        private void Membro4_Click(object sender, EventArgs e)
        {
            EdicaoMembrosGremio4 ed = new EdicaoMembrosGremio4();
            ed.Show();
        }

        private void Membro5_Click(object sender, EventArgs e)
        {
            EdicaoMembrosGremio5cs edicaoMembrosGremio5Cs = new EdicaoMembrosGremio5cs();
            edicaoMembrosGremio5Cs.Show();
        }

        private void Membro6_Click(object sender, EventArgs e)
        {
            EdicaoMembrosGremio6 ed = new EdicaoMembrosGremio6();
            ed.Show();
        }

        private void Membro7_Click(object sender, EventArgs e)
        {
            EdicaoMembrosGremio7 ed = new EdicaoMembrosGremio7();
            ed.Show();
        }

        private void Membro8_Click(object sender, EventArgs e)
        {
           EdicaoMembroGremio8 ed  = new EdicaoMembroGremio8();
           ed.Show();
        }

        private void Membro9_Click(object sender, EventArgs e)
        {
            EdicaoMembrosGremio9 ed = new EdicaoMembrosGremio9();
            ed.Show();
        }
    }
}
