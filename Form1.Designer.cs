namespace TIA2_CRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPersonID = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            btnInsertar = new Button();
            this.btnActualizar = new Button();
            this.btnEliminar = new Button();
            this.btnBuscar = new Button();
            this.btnLimpiar = new Button();
            btnVertodos = new Button();
            dgvPersons = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPersons).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 77);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "PersonID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 117);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "LastName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 155);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 2;
            label3.Text = "FirstName";
            // 
            // txtPersonID
            // 
            txtPersonID.Location = new Point(333, 74);
            txtPersonID.Name = "txtPersonID";
            txtPersonID.Size = new Size(181, 23);
            txtPersonID.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(333, 114);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(181, 23);
            txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(333, 152);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(181, 23);
            txtFirstName.TabIndex = 5;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(170, 391);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 6;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new Point(251, 391);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new Size(75, 23);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new Point(332, 391);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new Point(413, 391);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new Point(494, 391);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnVertodos
            // 
            btnVertodos.Location = new Point(575, 391);
            btnVertodos.Name = "btnVertodos";
            btnVertodos.Size = new Size(75, 23);
            btnVertodos.TabIndex = 11;
            btnVertodos.Text = "Ver Todos";
            btnVertodos.UseVisualStyleBackColor = true;
            // 
            // dgvPersons
            // 
            dgvPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersons.Location = new Point(204, 218);
            dgvPersons.Name = "dgvPersons";
            dgvPersons.Size = new Size(417, 150);
            dgvPersons.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPersons);
            Controls.Add(btnVertodos);
            Controls.Add(this.btnLimpiar);
            Controls.Add(this.btnBuscar);
            Controls.Add(this.btnEliminar);
            Controls.Add(this.btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtPersonID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvPersons).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPersonID;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Button btnInsertar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnVertodos;
        private DataGridView dgvPersons;
    }
}
