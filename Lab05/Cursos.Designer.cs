
namespace Lab05
{
    partial class Cursos
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
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.btnEliminar2 = new System.Windows.Forms.Button();
            this.btnModificar2 = new System.Windows.Forms.Button();
            this.btnInsertar2 = new System.Windows.Forms.Button();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.btnListar2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.txtDepartamentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCursosID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(12, 180);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.RowHeadersVisible = false;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(463, 274);
            this.dgvListado.TabIndex = 13;
            this.dgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentClick);
            this.dgvListado.SelectionChanged += new System.EventHandler(this.dgvListado_SelectionChanged);
            // 
            // btnEliminar2
            // 
            this.btnEliminar2.Location = new System.Drawing.Point(380, 132);
            this.btnEliminar2.Name = "btnEliminar2";
            this.btnEliminar2.Size = new System.Drawing.Size(95, 23);
            this.btnEliminar2.TabIndex = 12;
            this.btnEliminar2.Text = "Eliminar";
            this.btnEliminar2.UseVisualStyleBackColor = true;
            this.btnEliminar2.Click += new System.EventHandler(this.btnEliminar2_Click);
            // 
            // btnModificar2
            // 
            this.btnModificar2.Location = new System.Drawing.Point(380, 103);
            this.btnModificar2.Name = "btnModificar2";
            this.btnModificar2.Size = new System.Drawing.Size(95, 23);
            this.btnModificar2.TabIndex = 11;
            this.btnModificar2.Text = "Modificar";
            this.btnModificar2.UseVisualStyleBackColor = true;
            this.btnModificar2.Click += new System.EventHandler(this.btnModificar2_Click);
            // 
            // btnInsertar2
            // 
            this.btnInsertar2.Location = new System.Drawing.Point(380, 74);
            this.btnInsertar2.Name = "btnInsertar2";
            this.btnInsertar2.Size = new System.Drawing.Size(95, 23);
            this.btnInsertar2.TabIndex = 10;
            this.btnInsertar2.Text = "Insertar";
            this.btnInsertar2.UseVisualStyleBackColor = true;
            this.btnInsertar2.Click += new System.EventHandler(this.btnInsertar2_Click);
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.Location = new System.Drawing.Point(380, 45);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(95, 23);
            this.btnBuscar2.TabIndex = 9;
            this.btnBuscar2.Text = "Buscar";
            this.btnBuscar2.UseVisualStyleBackColor = true;
            // 
            // btnListar2
            // 
            this.btnListar2.Location = new System.Drawing.Point(380, 16);
            this.btnListar2.Name = "btnListar2";
            this.btnListar2.Size = new System.Drawing.Size(95, 23);
            this.btnListar2.TabIndex = 8;
            this.btnListar2.Text = "Listar";
            this.btnListar2.UseVisualStyleBackColor = true;
            this.btnListar2.Click += new System.EventHandler(this.btnListar2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCredits);
            this.groupBox2.Controls.Add(this.txtDepartamentID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCursosID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 159);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Persona";
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(10, 118);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(154, 20);
            this.txtCredits.TabIndex = 9;
            // 
            // txtDepartamentID
            // 
            this.txtDepartamentID.Location = new System.Drawing.Point(208, 77);
            this.txtDepartamentID.Name = "txtDepartamentID";
            this.txtDepartamentID.Size = new System.Drawing.Size(133, 20);
            this.txtDepartamentID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "departamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Credido:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(9, 77);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(154, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Titulo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCursosID
            // 
            this.txtCursosID.Location = new System.Drawing.Point(10, 37);
            this.txtCursosID.Name = "txtCursosID";
            this.txtCursosID.Size = new System.Drawing.Size(100, 20);
            this.txtCursosID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 466);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.btnEliminar2);
            this.Controls.Add(this.btnModificar2);
            this.Controls.Add(this.btnInsertar2);
            this.Controls.Add(this.btnBuscar2);
            this.Controls.Add(this.btnListar2);
            this.Controls.Add(this.groupBox2);
            this.Name = "Cursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button btnEliminar2;
        private System.Windows.Forms.Button btnModificar2;
        private System.Windows.Forms.Button btnInsertar2;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.Button btnListar2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.TextBox txtDepartamentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCursosID;
        private System.Windows.Forms.Label label1;
    }
}