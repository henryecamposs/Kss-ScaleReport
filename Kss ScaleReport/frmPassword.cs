using System;
using System.Threading;
using System.Windows.Forms;

namespace Kss_ScaleReport
{
    public partial class frmPassword : Form
    {
        private bool esAdmin;
       public bool esAccess { get; private set; }

        public frmPassword(bool esAdmin)
        {
            InitializeComponent();
            this.esAdmin = esAdmin;
            this.Shown += FrmPassword_Shown;
        }

        private void FrmPassword_Shown(object sender, EventArgs e)
        {
            txtpass.Focus();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //esAccess = esAdmin ? txtpass.Text.Equals(Program.vPOS_Config.vPOSAdminPassword) : txtpass.Text.Equals(Program.vPOS_Config.vPOSUserPassword);
            //if (!esAccess)
            //{
            //    Application.DoEvents();
            //    txtpass.BackColor = System.Drawing.Color.Red;
            //    Thread.Sleep (1000);
            //}
            this.Close();
        }

        private void frmPassword_Load(object sender, EventArgs e)
        {
            txtpass.Focus();
            
            Top = Owner.Top; Left = Owner.Left - Width - 30;

        }

        private void frmPassword_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData) {


                case Keys.Enter:
                    bunifuFlatButton3_Click(bunifuFlatButton3, new EventArgs());
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }
           
        }
    }
}
