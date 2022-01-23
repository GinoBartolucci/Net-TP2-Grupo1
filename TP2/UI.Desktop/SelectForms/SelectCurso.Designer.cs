
namespace UI.Desktop.SelectForms
{
    partial class SelectCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectCurso));
            this.tblSelectCurso = new System.Windows.Forms.TableLayoutPanel();
            this.dgvSelectCurso = new System.Windows.Forms.DataGridView();
            this.id_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio_especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioCalendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.tsCurso = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tblSelectCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectCurso)).BeginInit();
            this.tsCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblSelectCurso
            // 
            this.tblSelectCurso.ColumnCount = 2;
            this.tblSelectCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSelectCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblSelectCurso.Controls.Add(this.dgvSelectCurso, 0, 0);
            this.tblSelectCurso.Controls.Add(this.btnSalir, 1, 1);
            this.tblSelectCurso.Controls.Add(this.btnSeleccionar, 0, 1);
            this.tblSelectCurso.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tblSelectCurso.Location = new System.Drawing.Point(0, 28);
            this.tblSelectCurso.Name = "tblSelectCurso";
            this.tblSelectCurso.RowCount = 2;
            this.tblSelectCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSelectCurso.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSelectCurso.Size = new System.Drawing.Size(752, 552);
            this.tblSelectCurso.TabIndex = 0;
            // 
            // dgvSelectCurso
            // 
            this.dgvSelectCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_curso,
            this.descPlan,
            this.anio_especialidad,
            this.AnioCalendario,
            this.descComision,
            this.descMateria,
            this.Cupo});
            this.tblSelectCurso.SetColumnSpan(this.dgvSelectCurso, 2);
            this.dgvSelectCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectCurso.Location = new System.Drawing.Point(3, 3);
            this.dgvSelectCurso.MultiSelect = false;
            this.dgvSelectCurso.Name = "dgvSelectCurso";
            this.dgvSelectCurso.ReadOnly = true;
            this.dgvSelectCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectCurso.Size = new System.Drawing.Size(746, 517);
            this.dgvSelectCurso.TabIndex = 0;
            // 
            // id_curso
            // 
            this.id_curso.Frozen = true;
            this.id_curso.HeaderText = "ID";
            this.id_curso.Name = "id_curso";
            this.id_curso.ReadOnly = true;
            // 
            // descPlan
            // 
            this.descPlan.HeaderText = "Plan";
            this.descPlan.Name = "descPlan";
            this.descPlan.ReadOnly = true;
            // 
            // anio_especialidad
            // 
            this.anio_especialidad.HeaderText = "Año Especialidad";
            this.anio_especialidad.Name = "anio_especialidad";
            this.anio_especialidad.ReadOnly = true;
            // 
            // AnioCalendario
            // 
            this.AnioCalendario.HeaderText = "Año Dictado";
            this.AnioCalendario.Name = "AnioCalendario";
            this.AnioCalendario.ReadOnly = true;
            // 
            // descComision
            // 
            this.descComision.HeaderText = "Comision";
            this.descComision.Name = "descComision";
            this.descComision.ReadOnly = true;
            // 
            // descMateria
            // 
            this.descMateria.HeaderText = "Materia";
            this.descMateria.Name = "descMateria";
            this.descMateria.ReadOnly = true;
            // 
            // Cupo
            // 
            this.Cupo.HeaderText = "Cupo";
            this.Cupo.Name = "Cupo";
            this.Cupo.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(674, 526);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.Location = new System.Drawing.Point(593, 526);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // tsCurso
            // 
            this.tsCurso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsCurso.Location = new System.Drawing.Point(0, 0);
            this.tsCurso.Name = "tsCurso";
            this.tsCurso.Size = new System.Drawing.Size(752, 25);
            this.tsCurso.TabIndex = 1;
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
            // 
            // SelectCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 580);
            this.Controls.Add(this.tsCurso);
            this.Controls.Add(this.tblSelectCurso);
            this.Name = "SelectCurso";
            this.Text = "SelectCurso";
            this.Load += new System.EventHandler(this.SelectCurso_Load);
            this.tblSelectCurso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectCurso)).EndInit();
            this.tsCurso.ResumeLayout(false);
            this.tsCurso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblSelectCurso;
        private System.Windows.Forms.DataGridView dgvSelectCurso;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn descPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio_especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioCalendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn descComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn descMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cupo;
        private System.Windows.Forms.ToolStrip tsCurso;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
    }
}