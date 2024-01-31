
namespace WindowsFormsApp15
{
    partial class RegistroActividadComercial
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
            this.txtActiCom = new System.Windows.Forms.Label();
            this.txtActivCom = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAñadirACTI = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuarActi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBuscarActi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtActiCom
            // 
            this.txtActiCom.AutoSize = true;
            this.txtActiCom.Location = new System.Drawing.Point(48, 75);
            this.txtActiCom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtActiCom.Name = "txtActiCom";
            this.txtActiCom.Size = new System.Drawing.Size(127, 16);
            this.txtActiCom.TabIndex = 0;
            this.txtActiCom.Text = "Actividad Comercial";
            // 
            // txtActivCom
            // 
            this.txtActivCom.Location = new System.Drawing.Point(189, 72);
            this.txtActivCom.Margin = new System.Windows.Forms.Padding(4);
            this.txtActivCom.Name = "txtActivCom";
            this.txtActivCom.Size = new System.Drawing.Size(366, 22);
            this.txtActivCom.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Image = global::WindowsFormsApp15.Properties.Resources.eliminar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(417, 340);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnElimActi_Click);
            // 
            // btnAñadirACTI
            // 
            this.btnAñadirACTI.Image = global::WindowsFormsApp15.Properties.Resources.nueva_pagina;
            this.btnAñadirACTI.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirACTI.Location = new System.Drawing.Point(75, 340);
            this.btnAñadirACTI.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirACTI.Name = "btnAñadirACTI";
            this.btnAñadirACTI.Size = new System.Drawing.Size(106, 28);
            this.btnAñadirACTI.TabIndex = 6;
            this.btnAñadirACTI.Text = "NUEVO";
            this.btnAñadirACTI.UseVisualStyleBackColor = true;
            this.btnAñadirACTI.Click += new System.EventHandler(this.btnAñadACTI_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 31);
            this.label2.TabIndex = 52;
            this.label2.Text = "ACTIVIDAD COMERCIAL";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 124);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(691, 208);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridFomat);
            // 
            // btnGuarActi
            // 
            this.btnGuarActi.Image = global::WindowsFormsApp15.Properties.Resources.salvar16png;
            this.btnGuarActi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuarActi.Location = new System.Drawing.Point(598, 340);
            this.btnGuarActi.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuarActi.Name = "btnGuarActi";
            this.btnGuarActi.Size = new System.Drawing.Size(124, 28);
            this.btnGuarActi.TabIndex = 53;
            this.btnGuarActi.Text = "GUARDAR";
            this.btnGuarActi.UseVisualStyleBackColor = true;
            this.btnGuarActi.Click += new System.EventHandler(this.btnGuardActClick);
            // 
            // button2
            // 
            this.button2.Image = global::WindowsFormsApp15.Properties.Resources.editar16;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(231, 340);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "EDITAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnEditarActiClick);
            // 
            // btnBuscarActi
            // 
            this.btnBuscarActi.Image = global::WindowsFormsApp15.Properties.Resources.lupa16;
            this.btnBuscarActi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarActi.Location = new System.Drawing.Point(588, 67);
            this.btnBuscarActi.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarActi.Name = "btnBuscarActi";
            this.btnBuscarActi.Size = new System.Drawing.Size(134, 33);
            this.btnBuscarActi.TabIndex = 2;
            this.btnBuscarActi.Text = "BUSCAR";
            this.btnBuscarActi.UseVisualStyleBackColor = true;
            this.btnBuscarActi.Click += new System.EventHandler(this.btnBuscarAct);
            // 
            // RegistroActividadComercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(771, 411);
            this.Controls.Add(this.btnGuarActi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAñadirACTI);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscarActi);
            this.Controls.Add(this.txtActivCom);
            this.Controls.Add(this.txtActiCom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistroActividadComercial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroActividadComercial";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtActiCom;
        private System.Windows.Forms.TextBox txtActivCom;
        private System.Windows.Forms.Button btnBuscarActi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAñadirACTI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuarActi;
    }
}