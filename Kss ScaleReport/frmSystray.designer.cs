namespace Kss_ScaleReport
{
    partial class frmSystray
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ctrlsmnuTrayppal1 = new Kss_ScaleReport.ctrlsmnuTrayppal();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ctrlsmnuTrayppal1
            // 
            this.ctrlsmnuTrayppal1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ctrlsmnuTrayppal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlsmnuTrayppal1.enuDlgPopupItemResult = Kss_ScaleReport.enuDlgPopupItemSelected.None;
            this.ctrlsmnuTrayppal1.Location = new System.Drawing.Point(0, 0);
            this.ctrlsmnuTrayppal1.Name = "ctrlsmnuTrayppal1";
            this.ctrlsmnuTrayppal1.Size = new System.Drawing.Size(265, 249);
            this.ctrlsmnuTrayppal1.TabIndex = 0;
            this.ctrlsmnuTrayppal1.Titulo = "Opciones de PAGO";
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSystray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 249);
            this.Controls.Add(this.ctrlsmnuTrayppal1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSystray";
            this.ShowInTaskbar = false;
            this.Text = "frmSystray";
            this.Load += new System.EventHandler(this.frmSystray_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlsmnuTrayppal ctrlsmnuTrayppal1;
        private System.Windows.Forms.Timer timer1;
    }
}