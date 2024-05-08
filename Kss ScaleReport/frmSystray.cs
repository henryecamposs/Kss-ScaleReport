using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kss_ScaleReport
{
    public partial class frmSystray : Form
    {
        public Point ubicacion { get; internal set; }

        public frmSystray()
        {
            InitializeComponent();
        }

        private void frmSystray_Load(object sender, EventArgs e)

        {
            this.ctrlsmnuTrayppal1.Disposed += CtrlsmnuTrayppal1_Disposed;
            ctrlsmnuTrayppal1.config_expanded += CtrlsmnuTrayppal1_config_expanded;
            Location = ubicacion;
            timer1.Start();

        }

        private void CtrlsmnuTrayppal1_config_expanded(object sender, EventArgs e)
        {
            if ((bool)sender) timer1.Stop(); else timer1.Start();
        }

        private void CtrlsmnuTrayppal1_Disposed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
