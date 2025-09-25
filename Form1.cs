namespace PruebaAdoNetEMpleados
{
    public partial class Form1 : Form
    {
        RepoEmpleados repoE = new RepoEmpleados();
        private int? auxId; //variable para guardar el id del empleado que quiero modificar
        public Form1()
        {
            InitializeComponent();
            Refrescar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Refrescar()
        {
            dgvEmpleados.DataSource = null; // limpiar primero
            dgvEmpleados.DataSource = repoE.ListarEmpleados();
        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dgvEmpleados.Rows[dgvEmpleados.CurrentRow.Index].Cells[0].Value.ToString());//agarro la fila de mi datagrid y me fijo si puedo agarrar el valor del id
            }
            catch
            {
                return null;
            }


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void CargarDatos(int? Id) //esta funcion es para usar con el modificar
        {
            var Empleado = repoE.ListarEmpleados().FirstOrDefault(a => a.IdEmpleado == Id); //busco un dato en mi lista de empleados que coincida con el id que tengo

            if (Empleado != null)
            {
                txtModificarNombreEmpleado.Text = Empleado.Nombre;
                txtModificarApellidoEmpleado.Text = Empleado.Apellido;   //agarro y le actualizo la info a los textbox con el obj empleado q coincide con el id q agarre
                txtModificarDniEmpleado.Text = Empleado.Dni;
            }
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.auxId != null)
                {
                    Empleado empleado = new Empleado(); //creo un objeto empleado
                    empleado.IdEmpleado = (int)this.auxId; //le asigno el id del empleado que quiero modificar
                    empleado.Nombre = txtModificarNombreEmpleado.Text; //le asigno el nombre del textbox
                    empleado.Apellido = txtModificarApellidoEmpleado.Text; //le asigno el apellido del textbox
                    empleado.Dni = txtModificarDniEmpleado.Text; //le asigno el dni del textbox
                    repoE.ModificarEmpleado(empleado); //llamo a la funcion modificar y le paso el objeto empleado que acabo de crear y llenar con datos
                    Refrescar();
                }
                else
                {
                    MessageBox.Show("Elegi un empleado mongui");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el empleado: " + ex.Message);
            }
        }

        private void btnDatosEmpleado_Click(object sender, EventArgs e) //copio los datos del empleado q toque para modificarlo mas facil
        {
            this.auxId = GetId();
            if (this.auxId != null)
                CargarDatos(this.auxId);
            else
                MessageBox.Show("Elegi un empleado mongui");
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            this.auxId = GetId();

            if (this.auxId != null)
            {
                repoE.EliminarEmpleado((int)this.auxId); //mando el id a borrar a la funcion de mi repo pero modifico el tipo porq paso de un int? a un int normal
                Refrescar(); //creo q no hace falta aclarar jajajjaja
            }
            else
            {
                MessageBox.Show("Elegi un empleado mongui");
            }
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado empleado = new Empleado(); //creo un objeto empleado
                empleado.Nombre = txtAgregarNombreEmpleado.Text; //le asigno el nombre del textbox
                empleado.Apellido = txtAgregarApellidoEmpleado.Text; //le asigno el apellido del textbox
                empleado.Dni = txtAgregarDniEmpleado.Text; //le asigno el dni del textbox
                repoE.AgregarEmpleado(empleado); //llamo a la funcion agregar y le paso el objeto empleado que acabo de crear y llenar con datos
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el empleado: " + ex.Message);
            }
        }
    }
}
