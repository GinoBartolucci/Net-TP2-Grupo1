
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
            this.tblSelectCurso = new System.Windows.Forms.TableLayoutPanel();
            this.dgvSelectCurso = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioCalendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblSelectCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectCurso)).BeginInit();
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
            this.tblSelectCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSelectCurso.Location = new System.Drawing.Point(0, 0);
            this.tblSelectCurso.Name = "tblSelectCurso";
            this.tblSelectCurso.RowCount = 2;
            this.tblSelectCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSelectCurso.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSelectCurso.Size = new System.Drawing.Size(682, 283);
            this.tblSelectCurso.TabIndex = 0;
            // 
            // dgvSelectCurso
            // 
            this.dgvSelectCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdComision,
            this.IdMateria,
            this.AnioCalendario,
            this.Cupo});
            this.tblSelectCurso.SetColumnSpan(this.dgvSelectCurso, 2);
            this.dgvSelectCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectCurso.Location = new System.Drawing.Point(3, 3);
            this.dgvSelectCurso.MultiSelect = false;
            this.dgvSelectCurso.Name = "dgvSelectCurso";
            this.dgvSelectCurso.ReadOnly = true;
            this.dgvSelectCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectCurso.Size = new System.Drawing.Size(676, 248);
            this.dgvSelectCurso.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(604, 257);
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
            this.btnSeleccionar.Location = new System.Drawing.Point(523, 257);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // IdComision
            // 
            this.IdComision.HeaderText = "ID Comision";
            this.IdComision.Name = "IdComision";
            this.IdComision.ReadOnly = true;
            // 
            // IdMateria
            // 
            this.IdMateria.HeaderText = "ID Materia";
            this.IdMateria.Name = "IdMateria";
            this.IdMateria.ReadOnly = true;
            // 
            // AnioCalendario
            // 
            this.AnioCalendario.HeaderText = "Año Calendario";
            this.AnioCalendario.Name = "AnioCalendario";
            this.AnioCalendario.ReadOnly = true;
            // 
            // Cupo
            // 
            this.Cupo.HeaderText = "Cupo";
            this.Cupo.Name = "Cupo";
            this.Cupo.ReadOnly = true;
            // 
            // SelectCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 283);
            this.Controls.Add(this.tblSelectCurso);
            this.Name = "SelectCurso";
            this.Text = "SelectCurso";
            this.Load += new System.EventHandler(this.SelectCurso_Load);
            this.tblSelectCurso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblSelectCurso;
        private System.Windows.Forms.DataGridView dgvSelectCurso;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioCalendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cupo;
    }
}