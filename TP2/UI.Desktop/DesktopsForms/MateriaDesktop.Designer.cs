
namespace UI.Desktop.DesktopsForms
{
    partial class MateriaDesktop
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
            this.txtDescMateria = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.tlMateriaDesktop = new System.Windows.Forms.TableLayoutPanel();
            this.lID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPlan = new System.Windows.Forms.Label();
            this.btnSeleccionarPlan = new System.Windows.Forms.Button();
            this.txtHsSemanales = new System.Windows.Forms.NumericUpDown();
            this.txtHsTotales = new System.Windows.Forms.NumericUpDown();
            this.tlMateriaDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHsSemanales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHsTotales)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescMateria
            // 
            this.txtDescMateria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescMateria.Location = new System.Drawing.Point(113, 49);
            this.txtDescMateria.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescMateria.Name = "txtDescMateria";
            this.txtDescMateria.Size = new System.Drawing.Size(98, 20);
            this.txtDescMateria.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Location = new System.Drawing.Point(113, 8);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(98, 20);
            this.txtId.TabIndex = 0;
            // 
            // tlMateriaDesktop
            // 
            this.tlMateriaDesktop.ColumnCount = 4;
            this.tlMateriaDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlMateriaDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlMateriaDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlMateriaDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlMateriaDesktop.Controls.Add(this.txtId, 1, 0);
            this.tlMateriaDesktop.Controls.Add(this.txtDescMateria, 1, 1);
            this.tlMateriaDesktop.Controls.Add(this.lID, 0, 0);
            this.tlMateriaDesktop.Controls.Add(this.label2, 0, 1);
            this.tlMateriaDesktop.Controls.Add(this.label3, 0, 2);
            this.tlMateriaDesktop.Controls.Add(this.label4, 2, 0);
            this.tlMateriaDesktop.Controls.Add(this.btnAceptar, 2, 3);
            this.tlMateriaDesktop.Controls.Add(this.btnCancelar, 3, 3);
            this.tlMateriaDesktop.Controls.Add(this.lblPlan, 3, 1);
            this.tlMateriaDesktop.Controls.Add(this.btnSeleccionarPlan, 2, 1);
            this.tlMateriaDesktop.Controls.Add(this.txtHsSemanales, 1, 2);
            this.tlMateriaDesktop.Controls.Add(this.txtHsTotales, 3, 0);
            this.tlMateriaDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMateriaDesktop.Location = new System.Drawing.Point(0, 0);
            this.tlMateriaDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.tlMateriaDesktop.Name = "tlMateriaDesktop";
            this.tlMateriaDesktop.RowCount = 4;
            this.tlMateriaDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlMateriaDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.72973F));
            this.tlMateriaDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.64865F));
            this.tlMateriaDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.94595F));
            this.tlMateriaDesktop.Size = new System.Drawing.Size(433, 148);
            this.tlMateriaDesktop.TabIndex = 0;
            // 
            // lID
            // 
            this.lID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(45, 12);
            this.lID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(18, 13);
            this.lID.TabIndex = 5;
            this.lID.Text = "ID";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripcion Materia";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Horas Semanales";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Horas Totales";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Location = new System.Drawing.Point(237, 120);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(65, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(340, 120);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblPlan
            // 
            this.lblPlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(364, 52);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(28, 13);
            this.lblPlan.TabIndex = 12;
            this.lblPlan.Text = "Plan";
            // 
            // btnSeleccionarPlan
            // 
            this.btnSeleccionarPlan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSeleccionarPlan.Location = new System.Drawing.Point(219, 47);
            this.btnSeleccionarPlan.Name = "btnSeleccionarPlan";
            this.btnSeleccionarPlan.Size = new System.Drawing.Size(102, 23);
            this.btnSeleccionarPlan.TabIndex = 13;
            this.btnSeleccionarPlan.Text = "Seleccionar Plan";
            this.btnSeleccionarPlan.UseVisualStyleBackColor = true;
            this.btnSeleccionarPlan.Click += new System.EventHandler(this.btnSeleccionarIdPlan_Click);
            // 
            // txtHsSemanales
            // 
            this.txtHsSemanales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHsSemanales.Location = new System.Drawing.Point(111, 88);
            this.txtHsSemanales.Name = "txtHsSemanales";
            this.txtHsSemanales.Size = new System.Drawing.Size(102, 20);
            this.txtHsSemanales.TabIndex = 14;
            // 
            // txtHsTotales
            // 
            this.txtHsTotales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHsTotales.Location = new System.Drawing.Point(327, 8);
            this.txtHsTotales.Name = "txtHsTotales";
            this.txtHsTotales.Size = new System.Drawing.Size(102, 20);
            this.txtHsTotales.TabIndex = 15;
            // 
            // MateriaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 148);
            this.Controls.Add(this.tlMateriaDesktop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MateriaDesktop";
            this.Text = "MateriaDesktop";
            this.tlMateriaDesktop.ResumeLayout(false);
            this.tlMateriaDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHsSemanales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHsTotales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescMateria;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TableLayoutPanel tlMateriaDesktop;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleccionarPlan;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.NumericUpDown txtHsSemanales;
        private System.Windows.Forms.NumericUpDown txtHsTotales;
    }
}