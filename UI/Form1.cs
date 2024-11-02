using BLL;
using Entity;
using Entity.model;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TareaBusiness tareaBusiness = new TareaBusiness();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                TareaEntity tarea = new TareaEntity
                {
                    DescripcionTarea = txtDescripcion.Text,
                    FechaTarea = dtpFecha.Value
                };
                tareaBusiness.AgregarTarea(tarea);
                MessageBox.Show("Tarea agregada correctamente");
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
            finally
            {
                ActualizarGrid();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                TareaEntity tareaMod = new TareaEntity
                {
                    Id = Convert.ToInt32(txtIdMod.Text),
                    DescripcionTarea = txtDescripMod.Text,
                    FechaTarea = dtpFechaMod.Value
                };
                tareaBusiness.ModificarTarea(tareaMod);
                MessageBox.Show("La tarea se modificó correctamente");
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
            finally
            {
                ActualizarGrid();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                tareaBusiness.Eliminar(Convert.ToInt32(txtIdEliminar.Text));
                MessageBox.Show("La tarea se ha eliminado correctametne");
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
            finally
            {
                ActualizarGrid();
            }
        }

        private void ActualizarGrid()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tareaBusiness.ListarTareas();
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
    }
}
