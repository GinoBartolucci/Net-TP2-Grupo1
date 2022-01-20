
namespace UI.Desktop
{
    partial class DocentesCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocentesCursos));
            this.tscInscripcionesAlumnos = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.dvgInscripcionesAlumnos = new System.Windows.Forms.DataGridView();
            this.id_dictado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tscInscripcionesAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgInscripcionesAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // tscInscripcionesAlumnos
            // 
            this.tscInscripcionesAlumnos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tscInscripcionesAlumnos.Location = new System.Drawing.Point(0, 0);
            this.tscInscripcionesAlumnos.Name = "tscInscripcionesAlumnos";
            this.tscInscripcionesAlumnos.Size = new System.Drawing.Size(540, 25);
            this.tscInscripcionesAlumnos.TabIndex = 1;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click_1);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click_1);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click_1);
            // 
            // dvgInscripcionesAlumnos
            // 
            this.dvgInscripcionesAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgInscripcionesAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_dictado,
            this.id_curso,
            this.cargo,
            this.desc_Comision,
            this.desc_Materia});
            this.dvgInscripcionesAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgInscripcionesAlumnos.Location = new System.Drawing.Point(0, 25);
            this.dvgInscripcionesAlumnos.Name = "dvgInscripcionesAlumnos";
            this.dvgInscripcionesAlumnos.ReadOnly = true;
            this.dvgInscripcionesAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgInscripcionesAlumnos.Size = new System.Drawing.Size(540, 425);
            this.dvgInscripcionesAlumnos.TabIndex = 2;
            // 
            // id_dictado
            // 
            this.id_dictado.Frozen = true;
            this.id_dictado.HeaderText = "ID Dictado";
            this.id_dictado.Name = "id_dictado";
            this.id_dictado.ReadOnly = true;
            // 
            // id_curso
            // 
            this.id_curso.Frozen = true;
            this.id_curso.HeaderText = "ID Curso";
            this.id_curso.Name = "id_curso";
            this.id_curso.ReadOnly = true;
            // 
            // cargo
            // 
            this.cargo.Frozen = true;
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            this.cargo.ReadOnly = true;
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
            // DocentesCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.dvgInscripcionesAlumnos);
            this.Controls.Add(this.tscInscripcionesAlumnos);
            this.Name = "DocentesCursos";
            this.Text = "DocentesCursos";
            this.tscInscripcionesAlumnos.ResumeLayout(false);
            this.tscInscripcionesAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgInscripcionesAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tscInscripcionesAlumnos;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridView dvgInscripcionesAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_dictado;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_Materia;
    }
}