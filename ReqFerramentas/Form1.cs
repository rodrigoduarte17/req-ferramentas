using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReqFerramentas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            frmColaboradores frm = new frmColaboradores();
            frm.ShowDialog();
        }

        private void btnFerramentas_Click(object sender, EventArgs e)
        {
            frmFerramentas frm = new frmFerramentas();
            frm.ShowDialog();
        }

        private void btnRequisicoes_Click(object sender, EventArgs e)
        {
            frmRequesicoes frm = new frmRequesicoes();
            frm.ShowDialog();
        }
    }
}
