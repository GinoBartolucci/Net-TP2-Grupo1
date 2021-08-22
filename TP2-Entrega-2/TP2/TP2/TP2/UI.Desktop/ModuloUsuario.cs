using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;
using System.Text.RegularExpressions;

namespace UI.Desktop
{
    public partial class ModuloUsuario : ApplicationForm
    {
        private ToolStrip tsModuloUsuario;
        private TableLayoutPanel tlModuloUsuario;
        private DataGridView dgvModuloUsuario;
        private Button btnActualizar;
        private Button btnSalir;
        private DataGridViewTextBoxColumn id_modulo;
        private DataGridViewTextBoxColumn id_usuario;
        private DataGridViewCheckBoxColumn alta;
        private DataGridViewCheckBoxColumn baja;
        private DataGridViewCheckBoxColumn modificacion;
        private DataGridViewTextBoxColumn consulta;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbEliminar;
        private ToolStripContainer tscModuloUsuario;

        public ModuloUsuario()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloUsuario));
            this.tscModuloUsuario = new System.Windows.Forms.ToolStripContainer();
            this.tlModuloUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.dgvModuloUsuario = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsModuloUsuario = new System.Windows.Forms.ToolStrip();
            this.id_modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.baja = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.modificacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tscModuloUsuario.ContentPanel.SuspendLayout();
            this.tscModuloUsuario.TopToolStripPanel.SuspendLayout();
            this.tscModuloUsuario.SuspendLayout();
            this.tlModuloUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuloUsuario)).BeginInit();
            this.tsModuloUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscModuloUsuario
            // 
            // 
            // tscModuloUsuario.ContentPanel
            // 
            this.tscModuloUsuario.ContentPanel.Controls.Add(this.tlModuloUsuario);
            this.tscModuloUsuario.ContentPanel.Size = new System.Drawing.Size(800, 419);
            this.tscModuloUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscModuloUsuario.Location = new System.Drawing.Point(0, 0);
            this.tscModuloUsuario.Name = "tscModuloUsuario";
            this.tscModuloUsuario.Size = new System.Drawing.Size(800, 450);
            this.tscModuloUsuario.TabIndex = 0;
            this.tscModuloUsuario.Text = "toolStripContainer1";
            // 
            // tscModuloUsuario.TopToolStripPanel
            // 
            this.tscModuloUsuario.TopToolStripPanel.Controls.Add(this.tsModuloUsuario);
            // 
            // tlModuloUsuario
            // 
            this.tlModuloUsuario.ColumnCount = 2;
            this.tlModuloUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlModuloUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlModuloUsuario.Controls.Add(this.dgvModuloUsuario, 0, 0);
            this.tlModuloUsuario.Controls.Add(this.btnActualizar, 0, 1);
            this.tlModuloUsuario.Controls.Add(this.btnSalir, 1, 1);
            this.tlModuloUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlModuloUsuario.Location = new System.Drawing.Point(0, 0);
            this.tlModuloUsuario.Name = "tlModuloUsuario";
            this.tlModuloUsuario.RowCount = 2;
            this.tlModuloUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlModuloUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlModuloUsuario.Size = new System.Drawing.Size(800, 419);
            this.tlModuloUsuario.TabIndex = 0;
            // 
            // dgvModuloUsuario
            // 
            this.dgvModuloUsuario.AllowUserToAddRows = false;
            this.dgvModuloUsuario.AllowUserToDeleteRows = false;
            this.dgvModuloUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModuloUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_modulo,
            this.id_usuario,
            this.alta,
            this.baja,
            this.modificacion,
            this.consulta});
            this.tlModuloUsuario.SetColumnSpan(this.dgvModuloUsuario, 2);
            this.dgvModuloUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModuloUsuario.Location = new System.Drawing.Point(3, 3);
            this.dgvModuloUsuario.Name = "dgvModuloUsuario";
            this.dgvModuloUsuario.ReadOnly = true;
            this.dgvModuloUsuario.RowHeadersWidth = 51;
            this.dgvModuloUsuario.RowTemplate.Height = 24;
            this.dgvModuloUsuario.Size = new System.Drawing.Size(794, 384);
            this.dgvModuloUsuario.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(634, 393);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(82, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(722, 393);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsModuloUsuario
            // 
            this.tsModuloUsuario.Dock = System.Windows.Forms.DockStyle.None;
            this.tsModuloUsuario.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsModuloUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsModuloUsuario.Location = new System.Drawing.Point(4, 0);
            this.tsModuloUsuario.Name = "tsModuloUsuario";
            this.tsModuloUsuario.Size = new System.Drawing.Size(139, 31);
            this.tsModuloUsuario.TabIndex = 0;
            // 
            // id_modulo
            // 
            this.id_modulo.HeaderText = "ID Modulo";
            this.id_modulo.MinimumWidth = 6;
            this.id_modulo.Name = "id_modulo";
            this.id_modulo.ReadOnly = true;
            this.id_modulo.Width = 125;
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "ID Usuario";
            this.id_usuario.MinimumWidth = 6;
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            this.id_usuario.Width = 125;
            // 
            // alta
            // 
            this.alta.HeaderText = "Alta";
            this.alta.MinimumWidth = 6;
            this.alta.Name = "alta";
            this.alta.ReadOnly = true;
            this.alta.Width = 125;
            // 
            // baja
            // 
            this.baja.HeaderText = "Baja";
            this.baja.MinimumWidth = 6;
            this.baja.Name = "baja";
            this.baja.ReadOnly = true;
            this.baja.Width = 125;
            // 
            // modificacion
            // 
            this.modificacion.HeaderText = "Modificacion";
            this.modificacion.MinimumWidth = 6;
            this.modificacion.Name = "modificacion";
            this.modificacion.ReadOnly = true;
            this.modificacion.Width = 125;
            // 
            // consulta
            // 
            this.consulta.HeaderText = "Consulta";
            this.consulta.MinimumWidth = 6;
            this.consulta.Name = "consulta";
            this.consulta.ReadOnly = true;
            this.consulta.Width = 125;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(29, 28);
            this.tsbNuevo.Text = "toolStripButton1";
            this.tsbNuevo.ToolTipText = "Nuevo";
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(29, 28);
            this.tsbEditar.Text = "toolStripButton1";
            this.tsbEditar.ToolTipText = "Editar";
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(29, 28);
            this.tsbEliminar.Text = "toolStripButton1";
            this.tsbEliminar.ToolTipText = "Eliminar";
            // 
            // ModuloUsuarioDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tscModuloUsuario);
            this.Name = "ModuloUsuarioDesktop";
            this.Load += new System.EventHandler(this.ModuloUsuarioDesktop_Load);
            this.tscModuloUsuario.ContentPanel.ResumeLayout(false);
            this.tscModuloUsuario.TopToolStripPanel.ResumeLayout(false);
            this.tscModuloUsuario.TopToolStripPanel.PerformLayout();
            this.tscModuloUsuario.ResumeLayout(false);
            this.tscModuloUsuario.PerformLayout();
            this.tlModuloUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuloUsuario)).EndInit();
            this.tsModuloUsuario.ResumeLayout(false);
            this.tsModuloUsuario.PerformLayout();
            this.ResumeLayout(false);

        }
        //Constructor para las altas
        public void Listar()
        {
            ModuloUsuarioLogic mul = new ModuloUsuarioLogic();
            this.dgvModuloUsuario.DataSource = mul.GetAll();
        }

        private void ModuloUsuario_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
