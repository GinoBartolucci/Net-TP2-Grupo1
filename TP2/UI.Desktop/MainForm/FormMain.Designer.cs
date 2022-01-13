
namespace UI.Desktop
{
    partial class FormMain
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.btnNotasAlumno = new System.Windows.Forms.Button();
            this.btnIncribirse = new System.Windows.Forms.Button();
            this.btnMateriasPlanAlumno = new System.Windows.Forms.Button();
            this.btnCursadoAlumno = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnListadoAlumnos = new System.Windows.Forms.Button();
            this.btnCargarNotas = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.324786F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.09402F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.324786F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.09402F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.324786F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.09402F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.324786F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.09402F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.324786F));
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblNombre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEspecialidad, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPlan, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNotasAlumno, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnIncribirse, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMateriasPlanAlumno, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCursadoAlumno, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnListadoAlumnos, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCargarNotas, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.08832F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.92593F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(595, 422);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnSalir, 2);
            this.btnSalir.Location = new System.Drawing.Point(517, 374);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(65, 3);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(484, 3);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(35, 13);
            this.lblEspecialidad.TabIndex = 9;
            this.lblEspecialidad.Text = "label3";
            this.lblEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlan
            // 
            this.lblPlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(346, 3);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(35, 13);
            this.lblPlan.TabIndex = 8;
            this.lblPlan.Text = "label2";
            this.lblPlan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNotasAlumno
            // 
            this.btnNotasAlumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNotasAlumno.Location = new System.Drawing.Point(50, 140);
            this.btnNotasAlumno.Name = "btnNotasAlumno";
            this.btnNotasAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnNotasAlumno.TabIndex = 10;
            this.btnNotasAlumno.Text = "Notas";
            this.btnNotasAlumno.UseVisualStyleBackColor = true;
            this.btnNotasAlumno.Click += new System.EventHandler(this.btnNotasAlumno_Click);
            // 
            // btnIncribirse
            // 
            this.btnIncribirse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIncribirse.Location = new System.Drawing.Point(188, 140);
            this.btnIncribirse.Name = "btnIncribirse";
            this.btnIncribirse.Size = new System.Drawing.Size(75, 23);
            this.btnIncribirse.TabIndex = 11;
            this.btnIncribirse.Text = "Incribirse";
            this.btnIncribirse.UseVisualStyleBackColor = true;
            this.btnIncribirse.Click += new System.EventHandler(this.btnIncribirse_Click);
            // 
            // btnMateriasPlanAlumno
            // 
            this.btnMateriasPlanAlumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMateriasPlanAlumno.Location = new System.Drawing.Point(316, 140);
            this.btnMateriasPlanAlumno.Name = "btnMateriasPlanAlumno";
            this.btnMateriasPlanAlumno.Size = new System.Drawing.Size(95, 23);
            this.btnMateriasPlanAlumno.TabIndex = 12;
            this.btnMateriasPlanAlumno.Text = "Materias Plan";
            this.btnMateriasPlanAlumno.UseVisualStyleBackColor = true;
            this.btnMateriasPlanAlumno.Click += new System.EventHandler(this.btnMateriasPlanAlumno_Click);
            // 
            // btnCursadoAlumno
            // 
            this.btnCursadoAlumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCursadoAlumno.Location = new System.Drawing.Point(464, 140);
            this.btnCursadoAlumno.Name = "btnCursadoAlumno";
            this.btnCursadoAlumno.Size = new System.Drawing.Size(75, 23);
            this.btnCursadoAlumno.TabIndex = 13;
            this.btnCursadoAlumno.Text = "Cursado";
            this.btnCursadoAlumno.UseVisualStyleBackColor = true;
            this.btnCursadoAlumno.Click += new System.EventHandler(this.btnCursadoAlumno_Click);
            // 
            // btnListadoAlumnos
            // 
            this.btnListadoAlumnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListadoAlumnos.Location = new System.Drawing.Point(41, 235);
            this.btnListadoAlumnos.Name = "btnListadoAlumnos";
            this.btnListadoAlumnos.Size = new System.Drawing.Size(93, 23);
            this.btnListadoAlumnos.TabIndex = 14;
            this.btnListadoAlumnos.Text = "Listado Alumnos";
            this.btnListadoAlumnos.UseVisualStyleBackColor = true;
            this.btnListadoAlumnos.Click += new System.EventHandler(this.btnListadoAlumnos_Click);
            // 
            // btnCargarNotas
            // 
            this.btnCargarNotas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargarNotas.Location = new System.Drawing.Point(179, 235);
            this.btnCargarNotas.Name = "btnCargarNotas";
            this.btnCargarNotas.Size = new System.Drawing.Size(92, 23);
            this.btnCargarNotas.TabIndex = 15;
            this.btnCargarNotas.Text = "Cargar Notas";
            this.btnCargarNotas.UseVisualStyleBackColor = true;
            this.btnCargarNotas.Click += new System.EventHandler(this.btnCargarNotas_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 422);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Academia";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Button btnNotasAlumno;
        private System.Windows.Forms.Button btnIncribirse;
        private System.Windows.Forms.Button btnMateriasPlanAlumno;
        private System.Windows.Forms.Button btnCursadoAlumno;
        private System.Windows.Forms.Button btnListadoAlumnos;
        private System.Windows.Forms.Button btnCargarNotas;
    }
}