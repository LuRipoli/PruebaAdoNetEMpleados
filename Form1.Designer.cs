namespace PruebaAdoNetEMpleados
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
            gbxEmpleados = new GroupBox();
            btnDatosEmpleado = new Button();
            btnEliminarEmpleado = new Button();
            btnRefresh = new Button();
            btnModificarEmpleado = new Button();
            txtModificarDniEmpleado = new TextBox();
            txtModificarApellidoEmpleado = new TextBox();
            txtModificarNombreEmpleado = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnAgregarEmpleado = new Button();
            txtAgregarDniEmpleado = new TextBox();
            txtAgregarApellidoEmpleado = new TextBox();
            txtAgregarNombreEmpleado = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvEmpleados = new DataGridView();
            btnSalir = new Button();
            gbxEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // gbxEmpleados
            // 
            gbxEmpleados.Controls.Add(btnDatosEmpleado);
            gbxEmpleados.Controls.Add(btnEliminarEmpleado);
            gbxEmpleados.Controls.Add(btnRefresh);
            gbxEmpleados.Controls.Add(btnModificarEmpleado);
            gbxEmpleados.Controls.Add(txtModificarDniEmpleado);
            gbxEmpleados.Controls.Add(txtModificarApellidoEmpleado);
            gbxEmpleados.Controls.Add(txtModificarNombreEmpleado);
            gbxEmpleados.Controls.Add(label6);
            gbxEmpleados.Controls.Add(label7);
            gbxEmpleados.Controls.Add(label8);
            gbxEmpleados.Controls.Add(label9);
            gbxEmpleados.Controls.Add(btnAgregarEmpleado);
            gbxEmpleados.Controls.Add(txtAgregarDniEmpleado);
            gbxEmpleados.Controls.Add(txtAgregarApellidoEmpleado);
            gbxEmpleados.Controls.Add(txtAgregarNombreEmpleado);
            gbxEmpleados.Controls.Add(label5);
            gbxEmpleados.Controls.Add(label4);
            gbxEmpleados.Controls.Add(label3);
            gbxEmpleados.Controls.Add(label2);
            gbxEmpleados.Controls.Add(label1);
            gbxEmpleados.Controls.Add(dgvEmpleados);
            gbxEmpleados.Location = new Point(12, 12);
            gbxEmpleados.Name = "gbxEmpleados";
            gbxEmpleados.Size = new Size(969, 426);
            gbxEmpleados.TabIndex = 0;
            gbxEmpleados.TabStop = false;
            gbxEmpleados.Text = "Empleados";
            // 
            // btnDatosEmpleado
            // 
            btnDatosEmpleado.Location = new Point(161, 19);
            btnDatosEmpleado.Name = "btnDatosEmpleado";
            btnDatosEmpleado.Size = new Size(183, 29);
            btnDatosEmpleado.TabIndex = 21;
            btnDatosEmpleado.Text = "Copiar Datos Empleado";
            btnDatosEmpleado.UseVisualStyleBackColor = true;
            btnDatosEmpleado.Click += btnDatosEmpleado_Click;
            // 
            // btnEliminarEmpleado
            // 
            btnEliminarEmpleado.Location = new Point(350, 19);
            btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            btnEliminarEmpleado.Size = new Size(273, 29);
            btnEliminarEmpleado.TabIndex = 20;
            btnEliminarEmpleado.Text = "Eliminar Empleado Seleccionado";
            btnEliminarEmpleado.UseVisualStyleBackColor = true;
            btnEliminarEmpleado.Click += btnEliminarEmpleado_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(629, 19);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 29);
            btnRefresh.TabIndex = 19;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnModificarEmpleado
            // 
            btnModificarEmpleado.Location = new Point(757, 371);
            btnModificarEmpleado.Name = "btnModificarEmpleado";
            btnModificarEmpleado.Size = new Size(195, 29);
            btnModificarEmpleado.TabIndex = 18;
            btnModificarEmpleado.Text = "Modificar Empleado";
            btnModificarEmpleado.UseVisualStyleBackColor = true;
            btnModificarEmpleado.Click += btnModificarEmpleado_Click;
            // 
            // txtModificarDniEmpleado
            // 
            txtModificarDniEmpleado.Location = new Point(827, 338);
            txtModificarDniEmpleado.Name = "txtModificarDniEmpleado";
            txtModificarDniEmpleado.Size = new Size(125, 27);
            txtModificarDniEmpleado.TabIndex = 17;
            // 
            // txtModificarApellidoEmpleado
            // 
            txtModificarApellidoEmpleado.Location = new Point(827, 304);
            txtModificarApellidoEmpleado.Name = "txtModificarApellidoEmpleado";
            txtModificarApellidoEmpleado.Size = new Size(125, 27);
            txtModificarApellidoEmpleado.TabIndex = 16;
            // 
            // txtModificarNombreEmpleado
            // 
            txtModificarNombreEmpleado.Location = new Point(827, 269);
            txtModificarNombreEmpleado.Name = "txtModificarNombreEmpleado";
            txtModificarNombreEmpleado.Size = new Size(125, 27);
            txtModificarNombreEmpleado.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(757, 338);
            label6.Name = "label6";
            label6.Size = new Size(32, 20);
            label6.TabIndex = 14;
            label6.Text = "Dni";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(757, 307);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 13;
            label7.Text = "Apellido";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(757, 272);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 12;
            label8.Text = "Nombre";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(757, 233);
            label9.Name = "label9";
            label9.Size = new Size(145, 20);
            label9.TabIndex = 11;
            label9.Text = "Modificar Empleado";
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.Location = new Point(757, 161);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(195, 29);
            btnAgregarEmpleado.TabIndex = 10;
            btnAgregarEmpleado.Text = "Agregar Empleado";
            btnAgregarEmpleado.UseVisualStyleBackColor = true;
            btnAgregarEmpleado.Click += btnAgregarEmpleado_Click;
            // 
            // txtAgregarDniEmpleado
            // 
            txtAgregarDniEmpleado.Location = new Point(827, 128);
            txtAgregarDniEmpleado.Name = "txtAgregarDniEmpleado";
            txtAgregarDniEmpleado.Size = new Size(125, 27);
            txtAgregarDniEmpleado.TabIndex = 9;
            // 
            // txtAgregarApellidoEmpleado
            // 
            txtAgregarApellidoEmpleado.Location = new Point(827, 94);
            txtAgregarApellidoEmpleado.Name = "txtAgregarApellidoEmpleado";
            txtAgregarApellidoEmpleado.Size = new Size(125, 27);
            txtAgregarApellidoEmpleado.TabIndex = 8;
            // 
            // txtAgregarNombreEmpleado
            // 
            txtAgregarNombreEmpleado.Location = new Point(827, 59);
            txtAgregarNombreEmpleado.Name = "txtAgregarNombreEmpleado";
            txtAgregarNombreEmpleado.Size = new Size(125, 27);
            txtAgregarNombreEmpleado.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(757, 128);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 6;
            label5.Text = "Dni";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(757, 97);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 5;
            label4.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(757, 62);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(757, 23);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 3;
            label2.Text = "Agregar Empleado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 23);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 2;
            label1.Text = "Lista de Empleados";
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(17, 51);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(722, 353);
            dgvEmpleados.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(854, 454);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(110, 29);
            btnSalir.TabIndex = 21;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 495);
            Controls.Add(btnSalir);
            Controls.Add(gbxEmpleados);
            Name = "Form1";
            Text = "Form1";
            gbxEmpleados.ResumeLayout(false);
            gbxEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxEmpleados;
        private Label label1;
        private DataGridView dgvEmpleados;
        private Label label3;
        private Label label2;
        private Button btnModificarEmpleado;
        private TextBox txtModificarDniEmpleado;
        private TextBox txtModificarApellidoEmpleado;
        private TextBox txtModificarNombreEmpleado;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnAgregarEmpleado;
        private TextBox txtAgregarDniEmpleado;
        private TextBox txtAgregarApellidoEmpleado;
        private TextBox txtAgregarNombreEmpleado;
        private Label label5;
        private Label label4;
        private Button btnEliminarEmpleado;
        private Button btnRefresh;
        private Button btnSalir;
        private Button btnDatosEmpleado;
    }
}
