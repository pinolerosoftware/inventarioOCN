﻿namespace Presentacion
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnArea = new DevExpress.XtraBars.BarButtonItem();
            this.btnCategorias = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductos = new DevExpress.XtraBars.BarButtonItem();
            this.btnUusarios = new DevExpress.XtraBars.BarButtonItem();
            this.btnUbicacion = new DevExpress.XtraBars.BarButtonItem();
            this.btnEntrada = new DevExpress.XtraBars.BarButtonItem();
            this.btnSalida = new DevExpress.XtraBars.BarButtonItem();
            this.btnInventario = new DevExpress.XtraBars.BarButtonItem();
            this.btnRoles = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.bstUsuario = new DevExpress.XtraBars.BarStaticItem();
            this.btnMarca = new DevExpress.XtraBars.BarButtonItem();
            this.btnAbout = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnArea,
            this.btnCategorias,
            this.btnProductos,
            this.btnUusarios,
            this.btnUbicacion,
            this.btnEntrada,
            this.btnSalida,
            this.btnInventario,
            this.btnRoles,
            this.barButtonItem1,
            this.barStaticItem1,
            this.bstUsuario,
            this.btnMarca,
            this.btnAbout});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 16;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage1,
            this.ribbonPage3});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1202, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // btnArea
            // 
            this.btnArea.Caption = "Area";
            this.btnArea.Id = 1;
            this.btnArea.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnArea.ImageOptions.Image")));
            this.btnArea.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnArea.ImageOptions.LargeImage")));
            this.btnArea.Name = "btnArea";
            this.btnArea.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnArea_ItemClick);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Caption = "Categoria";
            this.btnCategorias.Id = 2;
            this.btnCategorias.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCategorias.ImageOptions.Image")));
            this.btnCategorias.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCategorias.ImageOptions.LargeImage")));
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCategorias_ItemClick);
            // 
            // btnProductos
            // 
            this.btnProductos.Caption = "Productos";
            this.btnProductos.Id = 3;
            this.btnProductos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.ImageOptions.Image")));
            this.btnProductos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProductos.ImageOptions.LargeImage")));
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductos_ItemClick);
            // 
            // btnUusarios
            // 
            this.btnUusarios.Caption = "Usuarios";
            this.btnUusarios.Id = 4;
            this.btnUusarios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUusarios.ImageOptions.Image")));
            this.btnUusarios.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUusarios.ImageOptions.LargeImage")));
            this.btnUusarios.Name = "btnUusarios";
            this.btnUusarios.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnUusarios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUusarios_ItemClick);
            // 
            // btnUbicacion
            // 
            this.btnUbicacion.Caption = "Ubicaciones";
            this.btnUbicacion.Id = 5;
            this.btnUbicacion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUbicacion.ImageOptions.Image")));
            this.btnUbicacion.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUbicacion.ImageOptions.LargeImage")));
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUbicacion_ItemClick);
            // 
            // btnEntrada
            // 
            this.btnEntrada.Caption = "Nueva Entrada";
            this.btnEntrada.Id = 6;
            this.btnEntrada.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEntrada.ImageOptions.Image")));
            this.btnEntrada.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEntrada.ImageOptions.LargeImage")));
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEntrada_ItemClick);
            // 
            // btnSalida
            // 
            this.btnSalida.Caption = "Nueva Salida";
            this.btnSalida.Id = 7;
            this.btnSalida.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalida.ImageOptions.Image")));
            this.btnSalida.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSalida.ImageOptions.LargeImage")));
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalida_ItemClick);
            // 
            // btnInventario
            // 
            this.btnInventario.Caption = "Inventario";
            this.btnInventario.Id = 8;
            this.btnInventario.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.ImageOptions.Image")));
            this.btnInventario.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInventario.ImageOptions.LargeImage")));
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInventario_ItemClick);
            // 
            // btnRoles
            // 
            this.btnRoles.Caption = "Roles";
            this.btnRoles.Id = 9;
            this.btnRoles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRoles.ImageOptions.Image")));
            this.btnRoles.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRoles.ImageOptions.LargeImage")));
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnRoles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRoles_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 13;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Usuario : ";
            this.barStaticItem1.Id = 11;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bstUsuario
            // 
            this.bstUsuario.Caption = "barStaticItem2";
            this.bstUsuario.Id = 12;
            this.bstUsuario.Name = "bstUsuario";
            this.bstUsuario.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnMarca
            // 
            this.btnMarca.Caption = "Marca";
            this.btnMarca.Id = 14;
            this.btnMarca.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMarca.ImageOptions.Image")));
            this.btnMarca.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMarca.ImageOptions.LargeImage")));
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMarca_ItemClick);
            // 
            // btnAbout
            // 
            this.btnAbout.Caption = "About";
            this.btnAbout.Id = 15;
            this.btnAbout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.ImageOptions.Image")));
            this.btnAbout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.ImageOptions.LargeImage")));
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAbout_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Movimiento de Inventario";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnEntrada);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Entrada";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnSalida);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Salida";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnInventario);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Movimientos";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Catalogos";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCategorias);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnProductos);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUbicacion);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMarca);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Productos";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnArea);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Acceso";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Sistema";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnUusarios);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Usuarios";
            this.ribbonPageGroup6.Visible = false;
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnRoles);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Roles";
            this.ribbonPageGroup7.Visible = false;
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnAbout);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "About";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.bstUsuario);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 703);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1202, 32);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 735);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.Name = "FrmMenu";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnArea;
        private DevExpress.XtraBars.BarButtonItem btnCategorias;
        private DevExpress.XtraBars.BarButtonItem btnProductos;
        private DevExpress.XtraBars.BarButtonItem btnUusarios;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnUbicacion;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem btnEntrada;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnSalida;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnInventario;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnRoles;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem bstUsuario;
        private DevExpress.XtraBars.BarButtonItem btnMarca;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem btnAbout;
    }
}