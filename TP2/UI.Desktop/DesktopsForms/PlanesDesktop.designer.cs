
namespace UI.Desktop
{
    partial class PlanesDesktop
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
            this.tlPlan = new System.Windows.Forms.TableLayoutPanel();
            this.lblText = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSeleccionarEspecialidad = new System.Windows.Forms.Button();
            this.lbNombreEspecialidad = new System.Windows.Forms.Label();
            this.tlPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlPlan
            // 
            this.tlPlan.ColumnCount = 4;
            this.tlPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.19816F));
            this.tlPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.71889F));
            this.tlPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.08295F));
            this.tlPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPlan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlPlan.Controls.Add(this.lblText, 1, 1);
            this.tlPlan.Controls.Add(this.lblDesc, 1, 2);
            this.tlPlan.Controls.Add(this.lblEspecialidad, 1, 3);
            this.tlPlan.Controls.Add(this.btnSalir, 3, 5);
            this.tlPlan.Controls.Add(this.btnAceptar, 2, 5);
            this.tlPlan.Controls.Add(this.txtDesc, 2, 2);
            this.tlPlan.Controls.Add(this.txtID, 2, 1);
            this.tlPlan.Controls.Add(this.btnSeleccionarEspecialidad, 1, 4);
            this.tlPlan.Controls.Add(this.lbNombreEspecialidad, 2, 3);
            this.tlPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPlan.Location = new System.Drawing.Point(0, 0);
            this.tlPlan.Margin = new System.Windows.Forms.Padding(2);
            this.tlPlan.Name = "tlPlan";
            this.tlPlan.RowCount = 6;
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00001F));
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlPlan.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPlan.Size = new System.Drawing.Size(331, 196);
            this.tlPlan.TabIndex = 0;
            this.tlPlan.Paint += new System.Windows.Forms.PaintEventHandler(this.tlPlan_Paint);
            // 
            // lblText
            // 
            this.lblText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(55, 33);
            this.lblText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(78, 33);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "ID:";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(55, 66);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(78, 33);
            this.lblDesc.TabIndex = 8;
            this.lblDesc.Text = "Descripcion:";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(55, 99);
            this.lblEspecialidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(78, 33);
            this.lblEspecialidad.TabIndex = 10;
            this.lblEspecialidad.Text = "Especialidad:";
            this.lblEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(254, 171);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(174, 171);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDesc.Location = new System.Drawing.Point(137, 72);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(112, 20);
            this.txtDesc.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.Location = new System.Drawing.Point(137, 39);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(112, 20);
            this.txtID.TabIndex = 7;
            // 
            // btnSeleccionarEspecialidad
            // 
            this.btnSeleccionarEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlPlan.SetColumnSpan(this.btnSeleccionarEspecialidad, 2);
            this.btnSeleccionarEspecialidad.Location = new System.Drawing.Point(79, 137);
            this.btnSeleccionarEspecialidad.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeleccionarEspecialidad.Name = "btnSeleccionarEspecialidad";
            this.btnSeleccionarEspecialidad.Size = new System.Drawing.Size(145, 23);
            this.btnSeleccionarEspecialidad.TabIndex = 14;
            this.btnSeleccionarEspecialidad.Text = "Seleccionar Especialidad";
            this.btnSeleccionarEspecialidad.UseVisualStyleBackColor = true;
            this.btnSeleccionarEspecialidad.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lbNombreEspecialidad
            // 
            this.lbNombreEspecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNombreEspecialidad.AutoSize = true;
            this.lbNombreEspecialidad.Location = new System.Drawing.Point(137, 99);
            this.lbNombreEspecialidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombreEspecialidad.Name = "lbNombreEspecialidad";
            this.lbNombreEspecialidad.Size = new System.Drawing.Size(112, 33);
            this.lbNombreEspecialidad.TabIndex = 15;
            this.lbNombreEspecialidad.Text = "No selecciono ninguna Especialidad";
            this.lbNombreEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlanesDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 196);
            this.Controls.Add(this.tlPlan);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlanesDesktop";
            this.Text = "PlanDesktop";
            this.tlPlan.ResumeLayout(false);
            this.tlPlan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlPlan;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSeleccionarEspecialidad;
        private System.Windows.Forms.Label lbNombreEspecialidad;
    }
}