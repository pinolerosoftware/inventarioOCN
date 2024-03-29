﻿namespace Presentacion.Formularios
{
    partial class FrmMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarca));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcDatosAreas = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.txtMarca = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gMarca = new DevExpress.XtraGrid.GridControl();
            this.gvMarca = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatosAreas)).BeginInit();
            this.gcDatosAreas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcDatosAreas);
            this.layoutControl1.Controls.Add(this.gMarca);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(810, 580);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcDatosAreas
            // 
            this.gcDatosAreas.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcDatosAreas.AppearanceCaption.Options.UseFont = true;
            this.gcDatosAreas.Controls.Add(this.layoutControl2);
            this.gcDatosAreas.Location = new System.Drawing.Point(12, 12);
            this.gcDatosAreas.Name = "gcDatosAreas";
            this.gcDatosAreas.Size = new System.Drawing.Size(241, 556);
            this.gcDatosAreas.TabIndex = 5;
            this.gcDatosAreas.Text = "Datos de las marca";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.groupControl2);
            this.layoutControl2.Controls.Add(this.txtMarca);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(2, 21);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(237, 533);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.btnCancelar);
            this.groupControl2.Controls.Add(this.btnGuardar);
            this.groupControl2.Controls.Add(this.btnEliminar);
            this.groupControl2.Controls.Add(this.btnModificar);
            this.groupControl2.Controls.Add(this.btnNuevo);
            this.groupControl2.Location = new System.Drawing.Point(12, 57);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(213, 464);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Botones de Accion";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(46, 213);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 37);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Tag = "5";
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.BotonAccionClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(46, 170);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 37);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Tag = "4";
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.BotonAccionClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Appearance.Options.UseFont = true;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(46, 127);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 37);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Tag = "3";
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.BotonAccionClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModificar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Appearance.Options.UseFont = true;
            this.btnModificar.Enabled = false;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(46, 81);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 40);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Tag = "2";
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.Click += new System.EventHandler(this.BotonAccionClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNuevo.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Appearance.Options.UseFont = true;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(46, 41);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(108, 37);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Tag = "1";
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.BotonAccionClick);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(12, 31);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Properties.Appearance.Options.UseFont = true;
            this.txtMarca.Properties.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(213, 22);
            this.txtMarca.StyleController = this.layoutControl2;
            this.txtMarca.TabIndex = 5;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(237, 533);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtMarca;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(217, 45);
            this.layoutControlItem4.Text = "Marca";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(40, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.groupControl2;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 45);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(217, 468);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // gMarca
            // 
            this.gMarca.Location = new System.Drawing.Point(257, 12);
            this.gMarca.MainView = this.gvMarca;
            this.gMarca.Name = "gMarca";
            this.gMarca.Size = new System.Drawing.Size(541, 556);
            this.gMarca.TabIndex = 4;
            this.gMarca.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMarca});
            // 
            // gvMarca
            // 
            this.gvMarca.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMarca.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvMarca.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMarca.Appearance.Row.Options.UseFont = true;
            this.gvMarca.GridControl = this.gMarca;
            this.gvMarca.Name = "gvMarca";
            this.gvMarca.OptionsBehavior.Editable = false;
            this.gvMarca.OptionsView.ShowAutoFilterRow = true;
            this.gvMarca.OptionsView.ShowGroupPanel = false;
            this.gvMarca.Click += new System.EventHandler(this.gvArea_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(810, 580);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gMarca;
            this.layoutControlItem1.Location = new System.Drawing.Point(245, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(545, 560);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcDatosAreas;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(245, 560);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 580);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmMarca";
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.FrmArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDatosAreas)).EndInit();
            this.gcDatosAreas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.GroupControl gcDatosAreas;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtMarca;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.GridControl gMarca;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMarca;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnModificar;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
    }
}