
namespace UI.Desktop.SelectForms
{
    partial class SelectAlumno
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
            this.tblSelectAlumno = new System.Windows.Forms.TableLayoutPanel();
            this.dgvSelectAlumno = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSelectAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // tblSelectAlumno
            // 
            this.tblSelectAlumno.ColumnCount = 2;
            this.tblSelectAlumno.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSelectAlumno.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblSelectAlumno.Controls.Add(this.dgvSelectAlumno, 0, 0);
            this.tblSelectAlumno.Controls.Add(this.btnSalir, 1, 1);
            this.tblSelectAlumno.Controls.Add(this.btnSeleccionar, 0, 1);
            this.tblSelectAlumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSelectAlumno.Location = new System.Drawing.Point(0, 0);
            this.tblSelectAlumno.Name = "tblSelectAlumno";
            this.tblSelectAlumno.RowCount = 2;
            this.tblSelectAlumno.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSelectAlumno.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSelectAlumno.Size = new System.Drawing.Size(968, 372);
            this.tblSelectAlumno.TabIndex = 0;
            // 
            // dgvSelectAlumno
            // 
            this.dgvSelectAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.Direccion,
            this.Email,
            this.FechaNacimiento,
            this.Legajo,
            this.IdPlan});
            this.tblSelectAlumno.SetColumnSpan(this.dgvSelectAlumno, 2);
            this.dgvSelectAlumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectAlumno.Location = new System.Drawing.Point(3, 3);
            this.dgvSelectAlumno.MultiSelect = false;
            this.dgvSelectAlumno.Name = "dgvSelectAlumno";
            this.dgvSelectAlumno.ReadOnly = true;
            this.dgvSelectAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectAlumno.Size = new System.Drawing.Size(962, 337);
            this.dgvSelectAlumno.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(890, 346);
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
            this.btnSeleccionar.Location = new System.Drawing.Point(809, 346);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            // 
            // IdPlan
            // 
            this.IdPlan.HeaderText = "ID Plan";
            this.IdPlan.Name = "IdPlan";
            this.IdPlan.ReadOnly = true;
            // 
            // SelectAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 372);
            this.Controls.Add(this.tblSelectAlumno);
            this.Name = "SelectAlumno";
            this.Text = "SelectAlumno";
            this.Load += new System.EventHandler(this.SelectAlumno_Load);
            this.tblSelectAlumno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectAlumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblSelectAlumno;
        private System.Windows.Forms.DataGridView dgvSelectAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPlan;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}