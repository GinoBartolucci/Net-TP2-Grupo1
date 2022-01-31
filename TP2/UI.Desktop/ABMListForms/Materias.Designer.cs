
namespace UI.Desktop.ABMListForms
{
    partial class Materias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materias));
            this.ReporteAlumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tcMaterias = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.idMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HsSemanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HsTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsMaterias = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteAlumnoBindingSource)).BeginInit();
            this.tcMaterias.ContentPanel.SuspendLayout();
            this.tcMaterias.TopToolStripPanel.SuspendLayout();
            this.tcMaterias.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.tsMaterias.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReporteAlumnoBindingSource
            // 
            this.ReporteAlumnoBindingSource.DataSource = typeof(Business.Entities.ReporteAlumno);
            // 
            // tcMaterias
            // 
            // 
            // tcMaterias.ContentPanel
            // 
            this.tcMaterias.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.tcMaterias.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tcMaterias.ContentPanel.Size = new System.Drawing.Size(649, 456);
            this.tcMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMaterias.Location = new System.Drawing.Point(0, 0);
            this.tcMaterias.Margin = new System.Windows.Forms.Padding(2);
            this.tcMaterias.Name = "tcMaterias";
            this.tcMaterias.Size = new System.Drawing.Size(649, 481);
            this.tcMaterias.TabIndex = 0;
            this.tcMaterias.Text = "toolStripContainer1";
            // 
            // tcMaterias.TopToolStripPanel
            // 
            this.tcMaterias.TopToolStripPanel.Controls.Add(this.tsMaterias);
            this.tcMaterias.TopToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_TopToolStripPanel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 468F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.Controls.Add(this.btnSeleccionar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnActualizar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvMaterias, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.97938F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.020618F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(649, 456);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSeleccionar.Location = new System.Drawing.Point(391, 424);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSalir.Location = new System.Drawing.Point(572, 424);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnActualizar.Location = new System.Drawing.Point(480, 424);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMateria,
            this.DescMateria,
            this.HsSemanales,
            this.HsTotales,
            this.desc_especialidad,
            this.desc_plan});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvMaterias, 3);
            this.dgvMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterias.Location = new System.Drawing.Point(2, 2);
            this.dgvMaterias.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.RowTemplate.Height = 24;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(645, 403);
            this.dgvMaterias.TabIndex = 2;
            // 
            // idMateria
            // 
            this.idMateria.Frozen = true;
            this.idMateria.HeaderText = "ID Materia";
            this.idMateria.Name = "idMateria";
            this.idMateria.ReadOnly = true;
            // 
            // DescMateria
            // 
            this.DescMateria.Frozen = true;
            this.DescMateria.HeaderText = "Descripcion Materia";
            this.DescMateria.Name = "DescMateria";
            this.DescMateria.ReadOnly = true;
            // 
            // HsSemanales
            // 
            this.HsSemanales.Frozen = true;
            this.HsSemanales.HeaderText = "Horas Semanales";
            this.HsSemanales.Name = "HsSemanales";
            this.HsSemanales.ReadOnly = true;
            // 
            // HsTotales
            // 
            this.HsTotales.Frozen = true;
            this.HsTotales.HeaderText = "Horas Totales";
            this.HsTotales.Name = "HsTotales";
            this.HsTotales.ReadOnly = true;
            // 
            // desc_especialidad
            // 
            this.desc_especialidad.Frozen = true;
            this.desc_especialidad.HeaderText = "Especialidad";
            this.desc_especialidad.Name = "desc_especialidad";
            // 
            // desc_plan
            // 
            this.desc_plan.Frozen = true;
            this.desc_plan.HeaderText = "Plan";
            this.desc_plan.Name = "desc_plan";
            this.desc_plan.ReadOnly = true;
            // 
            // tsMaterias
            // 
            this.tsMaterias.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMaterias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsMaterias.Location = new System.Drawing.Point(3, 0);
            this.tsMaterias.Name = "tsMaterias";
            this.tsMaterias.Size = new System.Drawing.Size(58, 25);
            this.tsMaterias.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "toolStripButton1";
            this.tsbNuevo.ToolTipText = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "toolStripButton2";
            this.tsbEditar.ToolTipText = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "toolStripButton3";
            this.tsbEliminar.ToolTipText = "Eliminar";
            this.tsbEliminar.Visible = false;
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 481);
            this.Controls.Add(this.tcMaterias);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Materias";
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.Materias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteAlumnoBindingSource)).EndInit();
            this.tcMaterias.ContentPanel.ResumeLayout(false);
            this.tcMaterias.TopToolStripPanel.ResumeLayout(false);
            this.tcMaterias.TopToolStripPanel.PerformLayout();
            this.tcMaterias.ResumeLayout(false);
            this.tcMaterias.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.tsMaterias.ResumeLayout(false);
            this.tsMaterias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcMaterias;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.ToolStrip tsMaterias;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsSemanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_plan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.BindingSource ReporteAlumnoBindingSource;
    }
}