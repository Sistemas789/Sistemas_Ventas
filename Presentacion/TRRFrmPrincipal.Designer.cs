namespace Presentacion
{
    partial class TRRFrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TRRFrmPrincipal));
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.RIBtnClientes = new Telerik.WinControls.UI.RadImageButtonElement();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.RIBtnProveedor = new Telerik.WinControls.UI.RadImageButtonElement();
            this.radRibbonBarGroup3 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.RIBtnPaises = new Telerik.WinControls.UI.RadImageButtonElement();
            this.radRibbonBarGroup4 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.RIBtnAlmacen = new Telerik.WinControls.UI.RadImageButtonElement();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1});
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.Text = "Exit";
            this.radRibbonBar1.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radRibbonBar1.LocalizationSettings.LayoutModeText = "Simplified Layout";
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.Text = "Options";
            this.radRibbonBar1.OptionsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // 
            // 
            this.radRibbonBar1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radRibbonBar1.Size = new System.Drawing.Size(876, 164);
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "TRRFrmPrincipal";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1,
            this.radRibbonBarGroup2,
            this.radRibbonBarGroup3,
            this.radRibbonBarGroup4});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Mantenimiento";
            this.ribbonTab1.UseMnemonic = false;
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 732);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(876, 26);
            this.radStatusStrip1.SizingGrip = false;
            this.radStatusStrip1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 568);
            this.panel1.TabIndex = 2;
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.RIBtnClientes});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "Cliente";
            // 
            // RIBtnClientes
            // 
            this.RIBtnClientes.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.RIBtnClientes.AutoSize = false;
            this.RIBtnClientes.Bounds = new System.Drawing.Rectangle(0, 0, 55, 65);
            this.RIBtnClientes.CustomFontStyle = System.Drawing.FontStyle.Regular;
            this.RIBtnClientes.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText;
            this.RIBtnClientes.Image = ((System.Drawing.Image)(resources.GetObject("RIBtnClientes.Image")));
            this.RIBtnClientes.Name = "RIBtnClientes";
            this.RIBtnClientes.Padding = new System.Windows.Forms.Padding(2, 4, 2, 0);
            this.RIBtnClientes.Shape = null;
            this.RIBtnClientes.Text = "";
            // 
            // radRibbonBarGroup2
            // 
            this.radRibbonBarGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.RIBtnProveedor});
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Text = "Proveedor";
            // 
            // RIBtnProveedor
            // 
            this.RIBtnProveedor.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.RIBtnProveedor.AutoSize = false;
            this.RIBtnProveedor.Bounds = new System.Drawing.Rectangle(0, 0, 55, 65);
            this.RIBtnProveedor.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText;
            this.RIBtnProveedor.Image = ((System.Drawing.Image)(resources.GetObject("RIBtnProveedor.Image")));
            this.RIBtnProveedor.Name = "RIBtnProveedor";
            this.RIBtnProveedor.Text = "";
            this.RIBtnProveedor.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radRibbonBarGroup3
            // 
            this.radRibbonBarGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.RIBtnPaises});
            this.radRibbonBarGroup3.Name = "radRibbonBarGroup3";
            this.radRibbonBarGroup3.Text = "Pais";
            // 
            // RIBtnPaises
            // 
            this.RIBtnPaises.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.RIBtnPaises.AutoSize = false;
            this.RIBtnPaises.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.RIBtnPaises.Bounds = new System.Drawing.Rectangle(0, 0, 55, 65);
            this.RIBtnPaises.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText;
            this.RIBtnPaises.Image = ((System.Drawing.Image)(resources.GetObject("RIBtnPaises.Image")));
            this.RIBtnPaises.Name = "RIBtnPaises";
            this.RIBtnPaises.Text = "";
            // 
            // radRibbonBarGroup4
            // 
            this.radRibbonBarGroup4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.RIBtnAlmacen});
            this.radRibbonBarGroup4.Name = "radRibbonBarGroup4";
            this.radRibbonBarGroup4.Text = "Almacén";
            // 
            // RIBtnAlmacen
            // 
            this.RIBtnAlmacen.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.RIBtnAlmacen.AutoSize = false;
            this.RIBtnAlmacen.Bounds = new System.Drawing.Rectangle(0, 0, 55, 65);
            this.RIBtnAlmacen.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText;
            this.RIBtnAlmacen.Image = ((System.Drawing.Image)(resources.GetObject("RIBtnAlmacen.Image")));
            this.RIBtnAlmacen.Name = "RIBtnAlmacen";
            this.RIBtnAlmacen.Text = "";
            this.RIBtnAlmacen.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.RIBtnAlmacen.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // TRRFrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 758);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radRibbonBar1);
            this.Name = "TRRFrmPrincipal";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "TRRFrmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadImageButtonElement RIBtnClientes;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadImageButtonElement RIBtnProveedor;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup3;
        private Telerik.WinControls.UI.RadImageButtonElement RIBtnPaises;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup4;
        private Telerik.WinControls.UI.RadImageButtonElement RIBtnAlmacen;
    }
}
