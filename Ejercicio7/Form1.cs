namespace Ejercicio7
{
    public partial class Form1 : Form
    {
        List<Vehiculo> Vehiculos = new List<Vehiculo>() {
            new Vehiculo(1, "Jonda", "chancho", 2022, 100, 100),
            new Vehiculo(2, "Totoya", "Car 420", 1999, 42, 42),
            new Vehiculo(3, "Folks Vagen", "German 73", 1973, 5, 10)
        };

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = Vehiculos;
            dataGridView1.ReadOnly = true;
        }

        private void groupBoxVehiculo_Enter(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

        }

        private void textBoxManiobrabilidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxFabricante.Text = Vehiculos[e.RowIndex].Fabricante;
            textBoxModelo.Text = Vehiculos[e.RowIndex].Modelo;
            textBoxAnio.Text = Vehiculos[e.RowIndex].Anio.ToString();
            textBoxVelocidad.Text = Vehiculos[e.RowIndex].Velocidad.ToString();
            textBoxManiobrabilidad.Text = Vehiculos[e.RowIndex].Maniobrabilidad.ToString();
            textBoxiD.Text = Vehiculos[e.RowIndex].Id.ToString();
            dataGridView1.Update();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            Vehiculos[Convert.ToInt32(textBoxiD.Text) -1].Fabricante = textBoxFabricante.Text;
            Vehiculos[Convert.ToInt32(textBoxiD.Text) - 1].Modelo = textBoxModelo.Text;
            Vehiculos[Convert.ToInt32(textBoxiD.Text) - 1].Anio = Convert.ToInt32(textBoxAnio.Text);
            Vehiculos[Convert.ToInt32(textBoxiD.Text) - 1].Velocidad = Convert.ToInt32(textBoxVelocidad.Text);
            Vehiculos[Convert.ToInt32(textBoxiD.Text) - 1].Maniobrabilidad = Convert.ToInt32(textBoxManiobrabilidad.Text);
        }
    }
}