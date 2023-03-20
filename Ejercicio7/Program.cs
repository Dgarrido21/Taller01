using System.Windows.Forms;

namespace Ejercicio7
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    class Vehiculo
    {
        //Atributos
        private string _fabricante, _modelo;
        private int _id, _anio, _velocidad, _maniobrabilidad;
        //Propiedades
        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public string Fabricante
        {
            get { return  this._fabricante; }
            set { this._fabricante = value; }
        }
        public string Modelo
        {
            get { return this._modelo; }
            set { this._modelo = value; }
        }
        public int Anio
        {
            get { return this._anio; } 
            set { this._anio = value;}
        }
        public int Velocidad
        {
            get { return this._velocidad; }
            set { this._velocidad = value; }
        }
        public int Maniobrabilidad
        {
            get { return this._maniobrabilidad; }
            set { this._maniobrabilidad = value; }
        }
        //Metodo
        public Vehiculo(int Id, string fabricante, string modelo, int anio, int velocidad, int maniobrabilidad)
        {
            this._id = Id;
            this._fabricante = fabricante;
            this._modelo = modelo;
            this._anio = anio;
            this._velocidad = velocidad;
            this._maniobrabilidad = maniobrabilidad;
        }

    }
}