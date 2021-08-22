
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
            this.tlSelectCurso = new System.Windows.Forms.TableLayoutPanel();
            this.dgvSelectCurso = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioCalendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tlSelectCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // tlSelectCurso
            // 
            this.tlSelectCurso.ColumnCount = 2;
            this.tlSelectCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlSelectCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlSelectCurso.Controls.Add(this.dgvSelectCurso, 0, 0);
            this.tlSelectCurso.Controls.Add(this.btnSeleccionar, 0, 1);
            this.tlSelectCurso.Controls.Add(this.btnSalir, 1, 1);
            this.tlSelectCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlSelectCurso.Location = new System.Drawing.Point(0, 0);
            this.tlSelectCurso.Name = "tlSelectCurso";
            this.tlSelectCurso.RowCount = 2;
            this.tlSelectCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlSelectCurso.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlSelectCurso.Size = new System.Drawing.Size(544, 384);
            this.tlSelectCurso.TabIndex = 0;
            // 
            // dgvSelectCurso
            // 
            this.dgvSelectCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IdMateria,
            this.IdComision,
            this.AnioCalendario,
            this.Cupo});
            this.tlSelectCurso.SetColumnSpan(this.dgvSelectCurso, 2);
            this.dgvSelectCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectCurso.Location = new System.Drawing.Point(3, 3);
            this.dgvSelectCurso.Name = "dgvSelectCurso";
            this.dgvSelectCurso.ReadOnly = true;
            this.dgvSelectCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectCurso.Size = new System.Drawing.Size(538, 349);
            this.dgvSelectCurso.TabIndex = 0;
            this.dgvSelectCurso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectCurso_CellContentClick);
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // IdMateria
            // 
            this.IdMateria.Frozen = true;
            this.IdMateria.HeaderText = "ID Materia";
            this.IdMateria.Name = "IdMateria";
            this.IdMateria.ReadOnly = true;
            // 
            // IdComision
            // 
            this.IdComision.Frozen = true;
            this.IdComision.HeaderText = "ID Comision";
            this.IdComision.Name = "IdComision";
            this.IdComision.ReadOnly = true;
            // 
            // AnioCalendario
            // 
            this.AnioCalendario.Frozen = true;
            this.AnioCalendario.HeaderText = "Año Calendario";
            this.AnioCalendario.Name = "AnioCalendario";
            this.AnioCalendario.ReadOnly = true;
            // 
            // Cupo
            // 
            this.Cupo.Frozen = true;
            this.Cupo.HeaderText = "Cupo";
            this.Cupo.Name = "Cupo";
            this.Cupo.ReadOnly = true;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.Location = new System.Drawing.Point(385, 358);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(466, 358);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // SelectCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 384);
            this.Controls.Add(this.tlSelectCurso);
            this.Name = "SelectCurso";
            this.Text = "SelectCurso";
            this.Load += new System.EventHandler(this.SelectCurso_Load);
            this.tlSelectCurso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectCurso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlSelectCurso;
        private System.Windows.Forms.DataGridView dgvSelectCurso;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioCalendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cupo;
    }
}