
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
            this.txtHsTotales = new System.Windows.Forms.TextBox();
            this.txtHsSemanales = new System.Windows.Forms.TextBox();
            this.txtDescMateria = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.tlMateriaDesktop = new System.Windows.Forms.TableLayoutPanel();
            this.lID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblIdPlan = new System.Windows.Forms.Label();
            this.btnSeleccionarIdPlan = new System.Windows.Forms.Button();
            this.tlMateriaDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHsTotales
            // 
            this.txtHsTotales.Location = new System.Drawing.Point(215, 2);
            this.txtHsTotales.Margin = new System.Windows.Forms.Padding(2);
            this.txtHsTotales.Name = "txtHsTotales";
            this.txtHsTotales.Size = new System.Drawing.Size(76, 20);
            this.txtHsTotales.TabIndex = 3;
            // 
            // txtHsSemanales
            // 
            this.txtHsSemanales.Location = new System.Drawing.Point(77, 81);
            this.txtHsSemanales.Margin = new System.Windows.Forms.Padding(2);
            this.txtHsSemanales.Name = "txtHsSemanales";
            this.txtHsSemanales.Size = new System.Drawing.Size(71, 20);
            this.txtHsSemanales.TabIndex = 2;
            // 
            // txtDescMateria
            // 
            this.txtDescMateria.Location = new System.Drawing.Point(77, 46);
            this.txtDescMateria.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescMateria.Name = "txtDescMateria";
            this.txtDescMateria.Size = new System.Drawing.Size(71, 20);
            this.txtDescMateria.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(77, 2);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(71, 20);
            this.txtId.TabIndex = 0;
            // 
            // tlMateriaDesktop
            // 
            this.tlMateriaDesktop.ColumnCount = 4;
            this.tlMateriaDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlMateriaDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlMateriaDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tlMateriaDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tlMateriaDesktop.Controls.Add(this.txtId, 1, 0);
            this.tlMateriaDesktop.Controls.Add(this.txtDescMateria, 1, 1);
            this.tlMateriaDesktop.Controls.Add(this.txtHsSemanales, 1, 2);
            this.tlMateriaDesktop.Controls.Add(this.txtHsTotales, 3, 0);
            this.tlMateriaDesktop.Controls.Add(this.lID, 0, 0);
            this.tlMateriaDesktop.Controls.Add(this.label2, 0, 1);
            this.tlMateriaDesktop.Controls.Add(this.label3, 0, 2);
            this.tlMateriaDesktop.Controls.Add(this.label4, 2, 0);
            this.tlMateriaDesktop.Controls.Add(this.label5, 2, 1);
            this.tlMateriaDesktop.Controls.Add(this.btnAceptar, 2, 3);
            this.tlMateriaDesktop.Controls.Add(this.btnCancelar, 3, 3);
            this.tlMateriaDesktop.Controls.Add(this.lblIdPlan, 3, 1);
            this.tlMateriaDesktop.Controls.Add(this.btnSeleccionarIdPlan, 3, 2);
            this.tlMateriaDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlMateriaDesktop.Location = new System.Drawing.Point(0, 0);
            this.tlMateriaDesktop.Margin = new System.Windows.Forms.Padding(2);
            this.tlMateriaDesktop.Name = "tlMateriaDesktop";
            this.tlMateriaDesktop.RowCount = 4;
            this.tlMateriaDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.33981F));
            this.tlMateriaDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.66019F));
            this.tlMateriaDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlMateriaDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlMateriaDesktop.Size = new System.Drawing.Size(357, 135);
            this.tlMateriaDesktop.TabIndex = 0;
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Location = new System.Drawing.Point(2, 0);
            this.lID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(18, 13);
            this.lID.TabIndex = 5;
            this.lID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripcion Materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Horas Semanales";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Horas Totales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Id Plan";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(152, 112);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(56, 19);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(215, 112);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 19);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblIdPlan
            // 
            this.lblIdPlan.AutoSize = true;
            this.lblIdPlan.Location = new System.Drawing.Point(216, 44);
            this.lblIdPlan.Name = "lblIdPlan";
            this.lblIdPlan.Size = new System.Drawing.Size(124, 26);
            this.lblIdPlan.TabIndex = 12;
            this.lblIdPlan.Text = "Debés seleccionar un id plan";
            // 
            // btnSeleccionarIdPlan
            // 
            this.btnSeleccionarIdPlan.Location = new System.Drawing.Point(216, 82);
            this.btnSeleccionarIdPlan.Name = "btnSeleccionarIdPlan";
            this.btnSeleccionarIdPlan.Size = new System.Drawing.Size(138, 23);
            this.btnSeleccionarIdPlan.TabIndex = 13;
            this.btnSeleccionarIdPlan.Text = "Seleccionar Id Plan";
            this.btnSeleccionarIdPlan.UseVisualStyleBackColor = true;
            this.btnSeleccionarIdPlan.Click += new System.EventHandler(this.btnSeleccionarIdPlan_Click);
            // 
            // MateriaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 135);
            this.Controls.Add(this.tlMateriaDesktop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MateriaDesktop";
            this.Text = "MateriaDesktop";
            this.tlMateriaDesktop.ResumeLayout(false);
            this.tlMateriaDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtHsTotales;
        private System.Windows.Forms.TextBox txtHsSemanales;
        private System.Windows.Forms.TextBox txtDescMateria;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TableLayoutPanel tlMateriaDesktop;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblIdPlan;
        private System.Windows.Forms.Button btnSeleccionarIdPlan;
    }
}