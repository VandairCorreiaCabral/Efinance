using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfinanceFront
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void estadosUFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmEstado();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.Manual;

            int x = (this.Width - f.Width) / 2;

            int y = (this.Height - f.Height) / 2;

            f.Location = new Point(x, y);

            f.Show();
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            var f = new FrmCidade();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.Manual;

            int x = (this.Width - f.Width) / 2;

            int y = (this.Height - f.Height) / 2;

            f.Location = new Point(x, y);

            f.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmCliente();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.Manual;

            int x = (this.Width - f.Width) / 2;

            int y = (this.Height - f.Height) / 2;

            f.Location = new Point(x, y);

            f.Show();
        }
    }
}
