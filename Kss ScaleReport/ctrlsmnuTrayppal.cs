using DevComponents.DotNetBar;
using System;
using Kss_ScaleReport;

namespace Kss_ScaleReport
{
    public partial class ctrlsmnuTrayppal : ctrlBase
    {
        public ctrlsmnuTrayppal()
        {
            InitializeComponent();
            Titulo = "TOOLS";
        }
        public event EventHandler config_expanded;
        private void onCOnfig_Expanded(bool isExpanded, EventArgs e)
        {
            config_expanded?.Invoke(isExpanded, e);
        }
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            frmPassword frm = new frmPassword(true);
            frm.ShowDialog(this);
            if (frm.esAccess)
                new frmMain().Show();
            frm = null;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {

            frmPassword frm = new frmPassword(false);
            frm.ShowDialog(this);
            //if (frm.esAccess)
            //    ksslib_c.Utiles.KssCodigo.CerrarAplicacion();
            frm.Dispose();
            frm = null;
        }
        private void btnPruebasCOM_Click_1(object sender, EventArgs e)
        {
            //Usar password

            //frmPassword frm = new frmPassword(true);
            //frm.ShowDialog(this);
            //if (frm.esAccess)
            //    new frmComportTest().Show();
            //frm.Dispose();
            //frm = null;
        }
         
        
        private void Config_ExpandChange(object sender, EventArgs e)
        {
            onCOnfig_Expanded(buttonItem1.Expanded, e);
            if (buttonItem1.Expanded)
            {
                frmPassword frm = new frmPassword(false);
                frm.ShowDialog(this);
                //buttonItem1.Expanded = false;
                if (frm.esAccess)
                {
                    buttonItem1.Expanded = true;
                    if (buttonItem1.Expanded)
                        txtBoxes_format();
                }
                else
                { buttonItem1.Expanded = false; }
                frm = null;
            }

        }
        private void ctrlsmnuTrayppal_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                //Program.ScaleReport_Config.Reload();
                //txtBoxes_format();
            }
        }
        void txtBoxes_format()
        {
            //txtTasaDolar.Text = Program.ScaleReport_Config.factorDolar.ToString("0,00");
            //txtTasaPetro.Text = Program.ScaleReport_Config.factorPetro.ToString("0,000");
            //txtTasaPetro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //txtTasaDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //txtTasaDolar.TextBox.Font = new System.Drawing.Font("Consolas", 12);
            //txtTasaPetro.TextBox.Font = new System.Drawing.Font("Consolas", 12);
            //txtTasaDolar.ButtonCustom.Visible = true;
            //txtTasaPetro.ButtonCustom.Visible = true;
            //this.txtTasaDolar.ButtonCustom.Symbol = "";
            //this.txtTasaPetro.ButtonCustom.Symbol = "";
            //this.txtTasaDolar.ButtonCustom.SymbolColor = System.Drawing.Color.DarkBlue;
            //this.txtTasaPetro.ButtonCustom.SymbolColor = System.Drawing.Color.DarkBlue;
        }
        

        
    }
}
