namespace Kss_ScaleReport
{
    partial class ctrlsmnuTrayppal
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.chkNGActive = new DevComponents.DotNetBar.CheckBoxItem();
            this.chkNGPrint = new DevComponents.DotNetBar.CheckBoxItem();
            this.chkNGAll = new DevComponents.DotNetBar.CheckBoxItem();
            this.chkNGNDebit = new DevComponents.DotNetBar.CheckBoxItem();
            this.labelItem3 = new DevComponents.DotNetBar.LabelItem();
            this.txtTasaDolar = new DevComponents.DotNetBar.TextBoxItem();
            this.labelItem4 = new DevComponents.DotNetBar.LabelItem();
            this.txtTasaPetro = new DevComponents.DotNetBar.TextBoxItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer10 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem7 = new DevComponents.DotNetBar.ButtonItem();
            this.SuspendLayout();
            // 
            // itemPanel1
            // 
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemPanel1.DragDropSupport = true;
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.itemPanel1.Location = new System.Drawing.Point(30, 0);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.ReserveLeftSpace = false;
            this.itemPanel1.Size = new System.Drawing.Size(155, 206);
            this.itemPanel1.TabIndex = 17;
            this.itemPanel1.Text = "itemPanel1";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.FixedSize = new System.Drawing.Size(0, 300);
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.buttonItem3,
            this.buttonItem4,
            this.buttonItem7});
            // 
            // 
            // 
            this.itemContainer1.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem1
            // 
            this.buttonItem1.AutoCollapseOnClick = false;
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.FixedSize = new System.Drawing.Size(150, 50);
            this.buttonItem1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonItem1.ImagePaddingHorizontal = 50;
            this.buttonItem1.ImagePaddingVertical = 100;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.PersonalizedMenus = DevComponents.DotNetBar.ePersonalizedMenus.Both;
            this.buttonItem1.RibbonWordWrap = false;
            this.buttonItem1.Stretch = true;
            this.buttonItem1.Symbol = "";
            this.buttonItem1.SymbolColor = System.Drawing.Color.Firebrick;
            this.buttonItem1.SymbolSize = 20F;
            this.buttonItem1.Text = "<font color=\"#BA1419\" size=\"16\">CONFIG</font>";
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            this.buttonItem1.ExpandChange += new System.EventHandler(this.Config_ExpandChange);
            // 
            // chkNGActive
            // 
            this.chkNGActive.AutoCollapseOnClick = false;
            this.chkNGActive.Name = "chkNGActive";
            this.chkNGActive.Text = "ACTIVE";
            this.chkNGActive.TextColor = System.Drawing.Color.White;
            // 
            // chkNGPrint
            // 
            this.chkNGPrint.AutoCollapseOnClick = false;
            this.chkNGPrint.Name = "chkNGPrint";
            this.chkNGPrint.Text = "PRINT";
            this.chkNGPrint.TextColor = System.Drawing.Color.White;
            // 
            // chkNGAll
            // 
            this.chkNGAll.AutoCollapseOnClick = false;
            this.chkNGAll.Name = "chkNGAll";
            this.chkNGAll.Text = "NG ALL";
            this.chkNGAll.TextColor = System.Drawing.Color.White;
            // 
            // chkNGNDebit
            // 
            this.chkNGNDebit.AutoCollapseOnClick = false;
            this.chkNGNDebit.Name = "chkNGNDebit";
            this.chkNGNDebit.Text = "N. DEBIT";
            this.chkNGNDebit.TextColor = System.Drawing.Color.White;
            // 
            // labelItem3
            // 
            this.labelItem3.AutoCollapseOnClick = false;
            this.labelItem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItem3.ForeColor = System.Drawing.Color.White;
            this.labelItem3.Height = 30;
            this.labelItem3.Name = "labelItem3";
            this.labelItem3.Text = "Tasa $:";
            this.labelItem3.Width = 60;
            // 
            // txtTasaDolar
            // 
            this.txtTasaDolar.AutoCollapseOnClick = false;
            this.txtTasaDolar.FocusHighlightEnabled = true;
            this.txtTasaDolar.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.txtTasaDolar.MaxLength = 15;
            this.txtTasaDolar.Name = "txtTasaDolar";
            this.txtTasaDolar.ShowSubItems = false;
            this.txtTasaDolar.Text = "0,00";
            this.txtTasaDolar.TextBoxHeight = 25;
            this.txtTasaDolar.TextBoxWidth = 105;
            this.txtTasaDolar.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // labelItem4
            // 
            this.labelItem4.AutoCollapseOnClick = false;
            this.labelItem4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItem4.ForeColor = System.Drawing.Color.White;
            this.labelItem4.Height = 30;
            this.labelItem4.Name = "labelItem4";
            this.labelItem4.Text = "Petro:";
            this.labelItem4.Width = 60;
            // 
            // txtTasaPetro
            // 
            this.txtTasaPetro.AutoCollapseOnClick = false;
            this.txtTasaPetro.FocusHighlightEnabled = true;
            this.txtTasaPetro.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.txtTasaPetro.MaxLength = 15;
            this.txtTasaPetro.Name = "txtTasaPetro";
            this.txtTasaPetro.ShowSubItems = false;
            this.txtTasaPetro.Text = "0,00";
            this.txtTasaPetro.TextBoxHeight = 25;
            this.txtTasaPetro.TextBoxWidth = 105;
            this.txtTasaPetro.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // buttonItem3
            // 
            this.buttonItem3.AccessKeyEnabled = false;
            this.buttonItem3.AutoExpandOnClick = true;
            this.buttonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem3.FixedSize = new System.Drawing.Size(150, 50);
            this.buttonItem3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonItem3.ImagePaddingHorizontal = 50;
            this.buttonItem3.ImagePaddingVertical = 100;
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.PersonalizedMenus = DevComponents.DotNetBar.ePersonalizedMenus.Both;
            this.buttonItem3.RibbonWordWrap = false;
            this.buttonItem3.Stretch = true;
            this.buttonItem3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer10});
            this.buttonItem3.Symbol = "";
            this.buttonItem3.SymbolColor = System.Drawing.Color.Firebrick;
            this.buttonItem3.SymbolSize = 20F;
            this.buttonItem3.Text = "<font color=\"#BA1419\" size=\"16\">TICKETS</font>";
            // 
            // itemContainer10
            // 
            // 
            // 
            // 
            this.itemContainer10.BackgroundStyle.BackColor = System.Drawing.Color.DarkBlue;
            this.itemContainer10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer10.FixedSize = new System.Drawing.Size(150, 100);
            this.itemContainer10.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer10.Name = "itemContainer10";
            this.itemContainer10.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem5,
            this.buttonItem6});
            // 
            // 
            // 
            this.itemContainer10.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer10.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonItem5
            // 
            this.buttonItem5.FixedSize = new System.Drawing.Size(180, 40);
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.Symbol = "En espera";
            this.buttonItem5.SymbolColor = System.Drawing.Color.White;
            this.buttonItem5.Text = "buttonItem5";
            // 
            // buttonItem6
            // 
            this.buttonItem6.FixedSize = new System.Drawing.Size(180, 40);
            this.buttonItem6.Name = "buttonItem6";
            this.buttonItem6.Symbol = "Despachados";
            this.buttonItem6.SymbolColor = System.Drawing.Color.White;
            // 
            // buttonItem4
            // 
            this.buttonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem4.FixedSize = new System.Drawing.Size(150, 50);
            this.buttonItem4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonItem4.ImagePaddingHorizontal = 50;
            this.buttonItem4.ImagePaddingVertical = 100;
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.RibbonWordWrap = false;
            this.buttonItem4.Stretch = true;
            this.buttonItem4.Symbol = "";
            this.buttonItem4.SymbolColor = System.Drawing.Color.Firebrick;
            this.buttonItem4.SymbolSize = 20F;
            this.buttonItem4.Text = "<font color=\"#BA1419\" size=\"16\">SCAN</font>";
            this.buttonItem4.Click += new System.EventHandler(this.btnPruebasCOM_Click_1);
            // 
            // buttonItem7
            // 
            this.buttonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem7.FixedSize = new System.Drawing.Size(150, 50);
            this.buttonItem7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonItem7.ImagePaddingHorizontal = 50;
            this.buttonItem7.ImagePaddingVertical = 100;
            this.buttonItem7.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem7.Name = "buttonItem7";
            this.buttonItem7.RibbonWordWrap = false;
            this.buttonItem7.Stretch = true;
            this.buttonItem7.Symbol = "EXIT";
            this.buttonItem7.SymbolColor = System.Drawing.Color.Red;
            this.buttonItem7.SymbolSize = 18F;
            this.buttonItem7.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ctrlsmnuTrayppal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemPanel1);
            this.Name = "ctrlsmnuTrayppal";
            this.Size = new System.Drawing.Size(185, 206);
            this.Load += new System.EventHandler(this.ctrlsmnuTrayppal_Load);
            this.Controls.SetChildIndex(this.itemPanel1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.CheckBoxItem chkNGActive;
        private DevComponents.DotNetBar.CheckBoxItem chkNGPrint;
        private DevComponents.DotNetBar.CheckBoxItem chkNGAll;
        private DevComponents.DotNetBar.CheckBoxItem chkNGNDebit;
        private DevComponents.DotNetBar.LabelItem labelItem3;
        private DevComponents.DotNetBar.TextBoxItem txtTasaDolar;
        private DevComponents.DotNetBar.LabelItem labelItem4;
        private DevComponents.DotNetBar.TextBoxItem txtTasaPetro;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ItemContainer itemContainer10;
        private DevComponents.DotNetBar.ButtonItem buttonItem5;
        private DevComponents.DotNetBar.ButtonItem buttonItem6;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private DevComponents.DotNetBar.ButtonItem buttonItem7;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
    }
}
