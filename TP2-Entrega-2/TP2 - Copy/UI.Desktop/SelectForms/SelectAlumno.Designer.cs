
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
            this.tlSelectAlumno = new System.Windows.Forms.TableLayoutPanel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvSelectAlumno = new System.Windows.Forms.DataGridView();
            this.tlSelectAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // tlSelectAlumno
            // 
            this.tlSelectAlumno.ColumnCount = 2;
            this.tlSelectAlumno.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlSelectAlumno.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlSelectAlumno.Controls.Add(this.btnSeleccionar, 0, 1);
            this.tlSelectAlumno.Controls.Add(this.btnSalir, 1, 1);
            this.tlSelectAlumno.Controls.Add(this.dgvSelectAlumno, 0, 0);
            this.tlSelectAlumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlSelectAlumno.Location = new System.Drawing.Point(0, 0);
            this.tlSelectAlumno.Name = "tlSelectAlumno";
            this.tlSelectAlumno.RowCount = 2;
            this.tlSelectAlumno.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlSelectAlumno.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlSelectAlumno.Size = new System.Drawing.Size(325, 458);
            this.tlSelectAlumno.TabIndex = 0;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(3, 432);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 0;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(247, 432);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dgvSelectAlumno
            // 
            this.dgvSelectAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlSelectAlumno.SetColumnSpan(this.dgvSelectAlumno, 2);
            this.dgvSelectAlumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectAlumno.Location = new System.Drawing.Point(3, 3);
            this.dgvSelectAlumno.Name = "dgvSelectAlumno";
            this.dgvSelectAlumno.ReadOnly = true;
            this.dgvSelectAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectAlumno.Size = new System.Drawing.Size(319, 423);
            this.dgvSelectAlumno.TabIndex = 2;
            // 
            // SelectAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 458);
            this.Controls.Add(this.tlSelectAlumno);
            this.Name = "SelectAlumno";
            this.Text = "SelectAlumno";
            this.tlSelectAlumno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectAlumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlSelectAlumno;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvSelectAlumno;
    }
}