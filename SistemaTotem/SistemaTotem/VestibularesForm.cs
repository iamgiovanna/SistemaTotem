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
    }
}
