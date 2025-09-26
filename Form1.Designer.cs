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
            groupBox1 = new GroupBox();
            btnModificarSecretaria = new Button();
            txtModificarSecretaria = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            btnCopiarDatosSecretaria = new Button();
            btnEliminarSecretariaSeleccionada = new Button();
            RefreshSecretarias = new Button();
            btnAgregarSecretaria = new Button();
            txtAgregarSecretariaFechaDeNacimiento = new TextBox();
            txtAgregarSecretariaNacionalidad = new TextBox();
            txtAgregarSecretariaNombre = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            dgvSecretarias = new DataGridView();
            txtModificarSecretariaNacionalidad = new TextBox();
            txtModificarSecretariaNacimiento = new TextBox();
            gbxEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSecretarias).BeginInit();
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
            dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(1002, 383);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(110, 29);
            btnSalir.TabIndex = 21;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtModificarSecretariaNacimiento);
            groupBox1.Controls.Add(txtModificarSecretariaNacionalidad);
            groupBox1.Controls.Add(btnModificarSecretaria);
            groupBox1.Controls.Add(txtModificarSecretaria);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(btnCopiarDatosSecretaria);
            groupBox1.Controls.Add(btnEliminarSecretariaSeleccionada);
            groupBox1.Controls.Add(RefreshSecretarias);
            groupBox1.Controls.Add(btnAgregarSecretaria);
            groupBox1.Controls.Add(txtAgregarSecretariaFechaDeNacimiento);
            groupBox1.Controls.Add(txtAgregarSecretariaNacionalidad);
            groupBox1.Controls.Add(txtAgregarSecretariaNombre);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(dgvSecretarias);
            groupBox1.Location = new Point(12, 444);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(969, 426);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Secretarias";
            // 
            // btnModificarSecretaria
            // 
            btnModificarSecretaria.Location = new Point(757, 358);
            btnModificarSecretaria.Name = "btnModificarSecretaria";
            btnModificarSecretaria.Size = new Size(195, 29);
            btnModificarSecretaria.TabIndex = 27;
            btnModificarSecretaria.Text = "Agregar Secretaria";
            btnModificarSecretaria.UseVisualStyleBackColor = true;
            // 
            // txtModificarSecretaria
            // 
            txtModificarSecretaria.Location = new Point(827, 256);
            txtModificarSecretaria.Name = "txtModificarSecretaria";
            txtModificarSecretaria.Size = new Size(125, 27);
            txtModificarSecretaria.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(757, 325);
            label10.Name = "label10";
            label10.Size = new Size(140, 20);
            label10.TabIndex = 25;
            label10.Text = "Año De Nacimiento";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(757, 294);
            label11.Name = "label11";
            label11.Size = new Size(98, 20);
            label11.TabIndex = 24;
            label11.Text = "Nacionalidad";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(757, 259);
            label12.Name = "label12";
            label12.Size = new Size(64, 20);
            label12.TabIndex = 23;
            label12.Text = "Nombre";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(757, 220);
            label13.Name = "label13";
            label13.Size = new Size(143, 20);
            label13.TabIndex = 22;
            label13.Text = "Modificar Secretaria";
            // 
            // btnCopiarDatosSecretaria
            // 
            btnCopiarDatosSecretaria.Location = new Point(161, 19);
            btnCopiarDatosSecretaria.Name = "btnCopiarDatosSecretaria";
            btnCopiarDatosSecretaria.Size = new Size(183, 29);
            btnCopiarDatosSecretaria.TabIndex = 21;
            btnCopiarDatosSecretaria.Text = "Copiar Datos Secretaria";
            btnCopiarDatosSecretaria.UseVisualStyleBackColor = true;
            // 
            // btnEliminarSecretariaSeleccionada
            // 
            btnEliminarSecretariaSeleccionada.Location = new Point(350, 19);
            btnEliminarSecretariaSeleccionada.Name = "btnEliminarSecretariaSeleccionada";
            btnEliminarSecretariaSeleccionada.Size = new Size(273, 29);
            btnEliminarSecretariaSeleccionada.TabIndex = 20;
            btnEliminarSecretariaSeleccionada.Text = "Eliminar Secretaria Seleccionada";
            btnEliminarSecretariaSeleccionada.UseVisualStyleBackColor = true;
            // 
            // RefreshSecretarias
            // 
            RefreshSecretarias.Location = new Point(629, 19);
            RefreshSecretarias.Name = "RefreshSecretarias";
            RefreshSecretarias.Size = new Size(110, 29);
            RefreshSecretarias.TabIndex = 19;
            RefreshSecretarias.Text = "Refresh";
            RefreshSecretarias.UseVisualStyleBackColor = true;
            // 
            // btnAgregarSecretaria
            // 
            btnAgregarSecretaria.Location = new Point(757, 161);
            btnAgregarSecretaria.Name = "btnAgregarSecretaria";
            btnAgregarSecretaria.Size = new Size(195, 29);
            btnAgregarSecretaria.TabIndex = 10;
            btnAgregarSecretaria.Text = "Agregar Secretaria";
            btnAgregarSecretaria.UseVisualStyleBackColor = true;
            // 
            // txtAgregarSecretariaFechaDeNacimiento
            // 
            txtAgregarSecretariaFechaDeNacimiento.Location = new Point(896, 128);
            txtAgregarSecretariaFechaDeNacimiento.Name = "txtAgregarSecretariaFechaDeNacimiento";
            txtAgregarSecretariaFechaDeNacimiento.Size = new Size(56, 27);
            txtAgregarSecretariaFechaDeNacimiento.TabIndex = 9;
            // 
            // txtAgregarSecretariaNacionalidad
            // 
            txtAgregarSecretariaNacionalidad.Location = new Point(861, 94);
            txtAgregarSecretariaNacionalidad.Name = "txtAgregarSecretariaNacionalidad";
            txtAgregarSecretariaNacionalidad.Size = new Size(91, 27);
            txtAgregarSecretariaNacionalidad.TabIndex = 8;
            // 
            // txtAgregarSecretariaNombre
            // 
            txtAgregarSecretariaNombre.Location = new Point(827, 59);
            txtAgregarSecretariaNombre.Name = "txtAgregarSecretariaNombre";
            txtAgregarSecretariaNombre.Size = new Size(125, 27);
            txtAgregarSecretariaNombre.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(757, 128);
            label14.Name = "label14";
            label14.Size = new Size(140, 20);
            label14.TabIndex = 6;
            label14.Text = "Año De Nacimiento";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(757, 97);
            label15.Name = "label15";
            label15.Size = new Size(98, 20);
            label15.TabIndex = 5;
            label15.Text = "Nacionalidad";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(757, 62);
            label16.Name = "label16";
            label16.Size = new Size(64, 20);
            label16.TabIndex = 4;
            label16.Text = "Nombre";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(757, 23);
            label17.Name = "label17";
            label17.Size = new Size(133, 20);
            label17.TabIndex = 3;
            label17.Text = "Agregar Secretaria";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(17, 23);
            label18.Name = "label18";
            label18.Size = new Size(136, 20);
            label18.TabIndex = 2;
            label18.Text = "Lista de Secretarias";
            // 
            // dgvSecretarias
            // 
            dgvSecretarias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSecretarias.Location = new Point(17, 51);
            dgvSecretarias.Name = "dgvSecretarias";
            dgvSecretarias.RowHeadersWidth = 51;
            dgvSecretarias.Size = new Size(722, 353);
            dgvSecretarias.TabIndex = 1;
            // 
            // txtModificarSecretariaNacionalidad
            // 
            txtModificarSecretariaNacionalidad.Location = new Point(861, 291);
            txtModificarSecretariaNacionalidad.Name = "txtModificarSecretariaNacionalidad";
            txtModificarSecretariaNacionalidad.Size = new Size(91, 27);
            txtModificarSecretariaNacionalidad.TabIndex = 28;
            // 
            // txtModificarSecretariaNacimiento
            // 
            txtModificarSecretariaNacimiento.Location = new Point(896, 322);
            txtModificarSecretariaNacimiento.Name = "txtModificarSecretariaNacimiento";
            txtModificarSecretariaNacimiento.Size = new Size(56, 27);
            txtModificarSecretariaNacimiento.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 875);
            Controls.Add(groupBox1);
            Controls.Add(btnSalir);
            Controls.Add(gbxEmpleados);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbxEmpleados.ResumeLayout(false);
            gbxEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSecretarias).EndInit();
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
        private GroupBox groupBox1;
        private Button btnCopiarDatosSecretaria;
        private Button btnEliminarSecretariaSeleccionada;
        private Button RefreshSecretarias;
        private Button btnAgregarSecretaria;
        private TextBox txtAgregarSecretariaFechaDeNacimiento;
        private TextBox txtAgregarSecretariaNacionalidad;
        private TextBox txtAgregarSecretariaNombre;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private DataGridView dgvSecretarias;
        private Button btnModificarSecretaria;
        private TextBox txtModificarSecretaria;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtModificarSecretariaNacimiento;
        private TextBox txtModificarSecretariaNacionalidad;
    }
}
