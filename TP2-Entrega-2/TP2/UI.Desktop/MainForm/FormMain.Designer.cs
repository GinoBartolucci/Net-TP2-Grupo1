
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEspecialidades = new System.Windows.Forms.Button();
            this.btnModulos = new System.Windows.Forms.Button();
            this.btnComisiones = new System.Windows.Forms.Button();
            this.btnPlanes = new System.Windows.Forms.Button();
            this.btnInscripcionesAlumnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUsuarios.Location = new System.Drawing.Point(46, 130);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUsuarios.Size = new System.Drawing.Size(82, 33);
            this.btnUsuarios.TabIndex = 0;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnUsuarios, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEspecialidades, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnModulos, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnComisiones, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPlanes, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnInscripcionesAlumnos, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(595, 422);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnSalir, 2);
            this.btnSalir.Location = new System.Drawing.Point(517, 396);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEspecialidades
            // 
            this.btnEspecialidades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEspecialidades.Location = new System.Drawing.Point(181, 130);
            this.btnEspecialidades.Name = "btnEspecialidades";
            this.btnEspecialidades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEspecialidades.Size = new System.Drawing.Size(88, 33);
            this.btnEspecialidades.TabIndex = 2;
            this.btnEspecialidades.Text = "Especialidades";
            this.btnEspecialidades.UseVisualStyleBackColor = true;
            this.btnEspecialidades.Click += new System.EventHandler(this.btnEspecialidades_Click);
            // 
            // btnModulos
            // 
            this.btnModulos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModulos.Location = new System.Drawing.Point(322, 130);
            this.btnModulos.Name = "btnModulos";
            this.btnModulos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnModulos.Size = new System.Drawing.Size(82, 33);
            this.btnModulos.TabIndex = 3;
            this.btnModulos.Text = "Modulos";
            this.btnModulos.UseVisualStyleBackColor = true;
            this.btnModulos.Click += new System.EventHandler(this.btnModulos_Click);
            // 
            // btnComisiones
            // 
            this.btnComisiones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnComisiones.Location = new System.Drawing.Point(460, 130);
            this.btnComisiones.Name = "btnComisiones";
            this.btnComisiones.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnComisiones.Size = new System.Drawing.Size(82, 33);
            this.btnComisiones.TabIndex = 4;
            this.btnComisiones.Text = "Comisiones";
            this.btnComisiones.UseVisualStyleBackColor = true;
            this.btnComisiones.Click += new System.EventHandler(this.btnComisiones_Click);
            // 
            // btnPlanes
            // 
            this.btnPlanes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlanes.Location = new System.Drawing.Point(46, 218);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPlanes.Size = new System.Drawing.Size(82, 33);
            this.btnPlanes.TabIndex = 5;
            this.btnPlanes.Text = "Planes";
            this.btnPlanes.UseVisualStyleBackColor = true;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // btnInscripcionesAlumnos
            // 
            this.btnInscripcionesAlumnos.Location = new System.Drawing.Point(178, 218);
            this.btnInscripcionesAlumnos.Name = "btnInscripcionesAlumnos";
            this.btnInscripcionesAlumnos.Size = new System.Drawing.Size(91, 33);
            this.btnInscripcionesAlumnos.TabIndex = 6;
            this.btnInscripcionesAlumnos.Text = "Inscripciones Alumnos";
            this.btnInscripcionesAlumnos.UseVisualStyleBackColor = true;
            this.btnInscripcionesAlumnos.Click += new System.EventHandler(this.btnInscripcionesAlumnos_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEspecialidades;
        private System.Windows.Forms.Button btnModulos;
        private System.Windows.Forms.Button btnComisiones;
        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.Button btnInscripcionesAlumnos;
    }
}