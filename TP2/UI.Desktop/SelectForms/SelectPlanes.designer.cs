
namespace UI.Desktop
{
    partial class SelectPlanes
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
            this.tlEspecialidadesLista = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvSelectPlanes = new System.Windows.Forms.DataGridView();
            this.id_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlEspecialidadesLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // tlEspecialidadesLista
            // 
            this.tlEspecialidadesLista.ColumnCount = 2;
            this.tlEspecialidadesLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlEspecialidadesLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlEspecialidadesLista.Controls.Add(this.btnSalir, 1, 1);
            this.tlEspecialidadesLista.Controls.Add(this.btnSeleccionar, 0, 1);
            this.tlEspecialidadesLista.Controls.Add(this.dgvSelectPlanes, 0, 0);
            this.tlEspecialidadesLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlEspecialidadesLista.Location = new System.Drawing.Point(0, 0);
            this.tlEspecialidadesLista.Margin = new System.Windows.Forms.Padding(2);
            this.tlEspecialidadesLista.Name = "tlEspecialidadesLista";
            this.tlEspecialidadesLista.RowCount = 2;
            this.tlEspecialidadesLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlEspecialidadesLista.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlEspecialidadesLista.Size = new System.Drawing.Size(350, 366);
            this.tlEspecialidadesLista.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(273, 341);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.Location = new System.Drawing.Point(194, 341);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 13;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvSelectPlanes
            // 
            this.dgvSelectPlanes.AllowUserToAddRows = false;
            this.dgvSelectPlanes.AllowUserToDeleteRows = false;
            this.dgvSelectPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectPlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_plan,
            this.desc_plan,
            this.desc_especialidad});
            this.tlEspecialidadesLista.SetColumnSpan(this.dgvSelectPlanes, 2);
            this.dgvSelectPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectPlanes.Location = new System.Drawing.Point(3, 3);
            this.dgvSelectPlanes.MultiSelect = false;
            this.dgvSelectPlanes.Name = "dgvSelectPlanes";
            this.dgvSelectPlanes.ReadOnly = true;
            this.dgvSelectPlanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectPlanes.Size = new System.Drawing.Size(344, 333);
            this.dgvSelectPlanes.TabIndex = 15;
            // 
            // id_plan
            // 
            this.id_plan.HeaderText = "ID";
            this.id_plan.Name = "id_plan";
            this.id_plan.ReadOnly = true;
            // 
            // desc_plan
            // 
            this.desc_plan.HeaderText = "Plan";
            this.desc_plan.Name = "desc_plan";
            this.desc_plan.ReadOnly = true;
            // 
            // desc_especialidad
            // 
            this.desc_especialidad.HeaderText = "Especialidad";
            this.desc_especialidad.Name = "desc_especialidad";
            this.desc_especialidad.ReadOnly = true;
            // 
            // SelectPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 366);
            this.Controls.Add(this.tlEspecialidadesLista);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SelectPlanes";
            this.Text = "SelectPlanes";
            this.Load += new System.EventHandler(this.SelectPlanes_Load);
            this.tlEspecialidadesLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectPlanes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlEspecialidadesLista;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvSelectPlanes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_especialidad;
    }
}