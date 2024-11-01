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
    public partial class MapaForm : Form
    {
        public MapaForm()
        {
            InitializeComponent();
        }

        private void PictureMapaEtecZL_Click(object sender, EventArgs e)
        {

        }

        private void PainelMapaEtecZL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TituloMapaEtecZL_Click(object sender, EventArgs e)
        {

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            //EVENTO para voltar a tela inicial
            TelaIncialForm telaIncialForm = new TelaIncialForm();
            telaIncialForm.Show();
            this.Hide();
        }
    }
}
