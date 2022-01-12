
namespace UI.Desktop.ABMListForms
{
    partial class InscripcionesAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InscripcionesAlumnos));
            this.tcInscripcionesAlumnos = new System.Windows.Forms.ToolStripContainer();
            this.tlInscripcionesAlumnos = new System.Windows.Forms.TableLayoutPanel();
            this.dvgInscripcionesAlumnos = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tscInscripcionesAlumnos = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.id_alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_inscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcInscripcionesAlumnos.ContentPanel.SuspendLayout();
            this.tcInscripcionesAlumnos.TopToolStripPanel.SuspendLayout();
            this.tcInscripcionesAlumnos.SuspendLayout();
            this.tlInscripcionesAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgInscripcionesAlumnos)).BeginInit();
            this.tscInscripcionesAlumnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcInscripcionesAlumnos
            // 
            // 
            // tcInscripcionesAlumnos.ContentPanel
            // 
            this.tcInscripcionesAlumnos.ContentPanel.Controls.Add(this.tlInscripcionesAlumnos);
            this.tcInscripcionesAlumnos.ContentPanel.Size = new System.Drawing.Size(946, 425);
            this.tcInscripcionesAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcInscripcionesAlumnos.Location = new System.Drawing.Point(0, 0);
            this.tcInscripcionesAlumnos.Name = "tcInscripcionesAlumnos";
            this.tcInscripcionesAlumnos.Size = new System.Drawing.Size(946, 450);
            this.tcInscripcionesAlumnos.TabIndex = 0;
            this.tcInscripcionesAlumnos.Text = "toolStripContainer1";
            // 
            // tcInscripcionesAlumnos.TopToolStripPanel
            // 
            this.tcInscripcionesAlumnos.TopToolStripPanel.Controls.Add(this.tscInscripcionesAlumnos);
            // 
            // tlInscripcionesAlumnos
            // 
            this.tlInscripcionesAlumnos.ColumnCount = 2;
            this.tlInscripcionesAlumnos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlInscripcionesAlumnos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlInscripcionesAlumnos.Controls.Add(this.dvgInscripcionesAlumnos, 0, 0);
            this.tlInscripcionesAlumnos.Controls.Add(this.btnActualizar, 0, 1);
            this.tlInscripcionesAlumnos.Controls.Add(this.btnSalir, 1, 1);
            this.tlInscripcionesAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlInscripcionesAlumnos.Location = new System.Drawing.Point(0, 0);
            this.tlInscripcionesAlumnos.Name = "tlInscripcionesAlumnos";
            this.tlInscripcionesAlumnos.RowCount = 2;
            this.tlInscripcionesAlumnos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlInscripcionesAlumnos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlInscripcionesAlumnos.Size = new System.Drawing.Size(946, 425);
            this.tlInscripcionesAlumnos.TabIndex = 0;
            // 
            // dvgInscripcionesAlumnos
            // 
            this.dvgInscripcionesAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgInscripcionesAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_alumno,
            this.id_inscripcion,
            this.legajo,
            this.nombreApellido,
            this.id_curso,
            this.desc_Comision,
            this.desc_Materia,
            this.condicion,
            this.nota});
            this.tlInscripcionesAlumnos.SetColumnSpan(this.dvgInscripcionesAlumnos, 2);
            this.dvgInscripcionesAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgInscripcionesAlumnos.Location = new System.Drawing.Point(3, 3);
            this.dvgInscripcionesAlumnos.Name = "dvgInscripcionesAlumnos";
            this.dvgInscripcionesAlumnos.ReadOnly = true;
            this.dvgInscripcionesAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgInscripcionesAlumnos.Size = new System.Drawing.Size(940, 390);
            this.dvgInscripcionesAlumnos.TabIndex = 0;
            this.dvgInscripcionesAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgInscripcionesAlumnos_CellContentClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(787, 399);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(868, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tscInscripcionesAlumnos
            // 
            this.tscInscripcionesAlumnos.Dock = System.Windows.Forms.DockStyle.None;
            this.tscInscripcionesAlumnos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tscInscripcionesAlumnos.Location = new System.Drawing.Point(3, 0);
            this.tscInscripcionesAlumnos.Name = "tscInscripcionesAlumnos";
            this.tscInscripcionesAlumnos.Size = new System.Drawing.Size(81, 25);
            this.tscInscripcionesAlumnos.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // id_alumno
            // 
            this.id_alumno.Frozen = true;
            this.id_alumno.HeaderText = "ID Alumno";
            this.id_alumno.Name = "id_alumno";
            this.id_alumno.ReadOnly = true;
            // 
            // id_inscripcion
            // 
            this.id_inscripcion.Frozen = true;
            this.id_inscripcion.HeaderText = "ID Inscripcion";
            this.id_inscripcion.Name = "id_inscripcion";
            this.id_inscripcion.ReadOnly = true;
            // 
            // legajo
            // 
            this.legajo.Frozen = true;
            this.legajo.HeaderText = "Legajo";
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
            // 
            // nombreApellido
            // 
            this.nombreApellido.Frozen = true;
            this.nombreApellido.HeaderText = "Nombre";
            this.nombreApellido.Name = "nombreApellido";
            this.nombreApellido.ReadOnly = true;
            // 
            // id_curso
            // 
            this.id_curso.Frozen = true;
            this.id_curso.HeaderText = "ID Curso";
            this.id_curso.Name = "id_curso";
            this.id_curso.ReadOnly = true;
            // 
            // desc_Comision
            // 
            this.desc_Comision.Frozen = true;
            this.desc_Comision.HeaderText = "Comision";
            this.desc_Comision.Name = "desc_Comision";
            this.desc_Comision.ReadOnly = true;
            // 
            // desc_Materia
            // 
            this.desc_Materia.Frozen = true;
            this.desc_Materia.HeaderText = "Materia";
            this.desc_Materia.Name = "desc_Materia";
            this.desc_Materia.ReadOnly = true;
            // 
            // condicion
            // 
            this.condicion.Frozen = true;
            this.condicion.HeaderText = "Condicion";
            this.condicion.Name = "condicion";
            this.condicion.ReadOnly = true;
            // 
            // nota
            // 
            this.nota.Frozen = true;
            this.nota.HeaderText = "Nota";
            this.nota.Name = "nota";
            this.nota.ReadOnly = true;
            // 
            // InscripcionesAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.tcInscripcionesAlumnos);
            this.Name = "InscripcionesAlumnos";
            this.Text = "Inscripciones Alumnos Lista";
            this.Load += new System.EventHandler(this.InscripcionesAlumnos_Load);
            this.tcInscripcionesAlumnos.ContentPanel.ResumeLayout(false);
            this.tcInscripcionesAlumnos.TopToolStripPanel.ResumeLayout(false);
            this.tcInscripcionesAlumnos.TopToolStripPanel.PerformLayout();
            this.tcInscripcionesAlumnos.ResumeLayout(false);
            this.tcInscripcionesAlumnos.PerformLayout();
            this.tlInscripcionesAlumnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgInscripcionesAlumnos)).EndInit();
            this.tscInscripcionesAlumnos.ResumeLayout(false);
            this.tscInscripcionesAlumnos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcInscripcionesAlumnos;
        private System.Windows.Forms.ToolStrip tscInscripcionesAlumnos;
        private System.Windows.Forms.TableLayoutPanel tlInscripcionesAlumnos;
        private System.Windows.Forms.DataGridView dvgInscripcionesAlumnos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_inscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
    }
}