
namespace UI.Desktop
{
    partial class Comisiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comisiones));
            this.tcComisiones = new System.Windows.Forms.ToolStripContainer();
            this.tlComisiones = new System.Windows.Forms.TableLayoutPanel();
            this.dgvComisiones = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tsComisiones = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEdiar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idplan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcComisiones.ContentPanel.SuspendLayout();
            this.tcComisiones.TopToolStripPanel.SuspendLayout();
            this.tcComisiones.SuspendLayout();
            this.tlComisiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).BeginInit();
            this.tsComisiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcComisiones
            // 
            // 
            // tcComisiones.ContentPanel
            // 
            this.tcComisiones.ContentPanel.Controls.Add(this.tlComisiones);
            this.tcComisiones.ContentPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcComisiones.ContentPanel.Size = new System.Drawing.Size(558, 386);
            this.tcComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcComisiones.Location = new System.Drawing.Point(0, 0);
            this.tcComisiones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tcComisiones.Name = "tcComisiones";
            this.tcComisiones.Size = new System.Drawing.Size(558, 413);
            this.tcComisiones.TabIndex = 0;
            this.tcComisiones.Text = "toolStripContainer1";
            // 
            // tcComisiones.TopToolStripPanel
            // 
            this.tcComisiones.TopToolStripPanel.Controls.Add(this.tsComisiones);
            // 
            // tlComisiones
            // 
            this.tlComisiones.ColumnCount = 2;
            this.tlComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlComisiones.Controls.Add(this.dgvComisiones, 0, 0);
            this.tlComisiones.Controls.Add(this.btnSalir, 1, 1);
            this.tlComisiones.Controls.Add(this.btnActualizar, 0, 1);
            this.tlComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlComisiones.Location = new System.Drawing.Point(0, 0);
            this.tlComisiones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlComisiones.Name = "tlComisiones";
            this.tlComisiones.RowCount = 2;
            this.tlComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlComisiones.Size = new System.Drawing.Size(558, 386);
            this.tlComisiones.TabIndex = 0;
            // 
            // dgvComisiones
            // 
            this.dgvComisiones.AllowUserToAddRows = false;
            this.dgvComisiones.AllowUserToDeleteRows = false;
            this.dgvComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComisiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.descripcion,
            this.anioEspecialidad,
            this.idplan});
            this.tlComisiones.SetColumnSpan(this.dgvComisiones, 2);
            this.dgvComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComisiones.Location = new System.Drawing.Point(2, 2);
            this.dgvComisiones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvComisiones.MultiSelect = false;
            this.dgvComisiones.Name = "dgvComisiones";
            this.dgvComisiones.ReadOnly = true;
            this.dgvComisiones.RowHeadersWidth = 51;
            this.dgvComisiones.RowTemplate.Height = 24;
            this.dgvComisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComisiones.Size = new System.Drawing.Size(554, 355);
            this.dgvComisiones.TabIndex = 0;
            this.dgvComisiones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComisiones_CellContentClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(481, 361);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(402, 361);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // tsComisiones
            // 
            this.tsComisiones.Dock = System.Windows.Forms.DockStyle.None;
            this.tsComisiones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsComisiones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEdiar,
            this.tsbEliminar});
            this.tsComisiones.Location = new System.Drawing.Point(7, 0);
            this.tsComisiones.Name = "tsComisiones";
            this.tsComisiones.Size = new System.Drawing.Size(84, 27);
            this.tsComisiones.TabIndex = 1;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(24, 24);
            this.tsbNuevo.Text = "toolStripButton1";
            this.tsbNuevo.ToolTipText = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEdiar
            // 
            this.tsbEdiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdiar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdiar.Image")));
            this.tsbEdiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdiar.Name = "tsbEdiar";
            this.tsbEdiar.Size = new System.Drawing.Size(24, 24);
            this.tsbEdiar.Text = "toolStripButton1";
            this.tsbEdiar.ToolTipText = "Editar";
            this.tsbEdiar.Click += new System.EventHandler(this.tsbEdiar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(24, 24);
            this.tsbEliminar.Text = "toolStripButton1";
            this.tsbEliminar.ToolTipText = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 125;
            // 
            // anioEspecialidad
            // 
            this.anioEspecialidad.HeaderText = "AnioEspecialidad";
            this.anioEspecialidad.MinimumWidth = 6;
            this.anioEspecialidad.Name = "anioEspecialidad";
            this.anioEspecialidad.ReadOnly = true;
            this.anioEspecialidad.Width = 125;
            // 
            // idplan
            // 
            this.idplan.HeaderText = "Plan";
            this.idplan.MinimumWidth = 6;
            this.idplan.Name = "idplan";
            this.idplan.ReadOnly = true;
            this.idplan.Width = 125;
            // 
            // Comisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 413);
            this.Controls.Add(this.tcComisiones);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Comisiones";
            this.Text = "Comisiones";
            this.Load += new System.EventHandler(this.Comisiones_Load);
            this.tcComisiones.ContentPanel.ResumeLayout(false);
            this.tcComisiones.TopToolStripPanel.ResumeLayout(false);
            this.tcComisiones.TopToolStripPanel.PerformLayout();
            this.tcComisiones.ResumeLayout(false);
            this.tcComisiones.PerformLayout();
            this.tlComisiones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).EndInit();
            this.tsComisiones.ResumeLayout(false);
            this.tsComisiones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcComisiones;
        private System.Windows.Forms.ToolStrip tsComisiones;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEdiar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.TableLayoutPanel tlComisiones;
        private System.Windows.Forms.DataGridView dgvComisiones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idplan;
    }
}