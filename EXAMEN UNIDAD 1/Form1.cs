//ANGEL DANIEL SALINAS ORTIZ
// NO CONTRO: 23130598

using System.Data;
using System.Windows.Forms;

namespace EXAMEN_UNIDAD_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DGVDATOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void CARGARD_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos CSV|*.csv",
                Title = "Seleccionar archivo CSV"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CargarCSV(openFileDialog.FileName);
            }
        }

        //CARGAR EL ARCHIVO CSV

        private void CargarCSV(string filePath)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("CURP");
            dataTable.Columns.Add("PROMEDIO");
            dataTable.Columns.Add("EDAD");
            dataTable.Columns.Add("SEXO");

            try
            {
                string[] lineas = File.ReadAllLines(filePath);

                foreach (var linea in lineas.Skip(1)) // Pare saltarse la primera linea si es encabezado
                {
                    var datos = linea.Split(',');

                    if (datos.Length >= 2)
                    {
                        string CURP = datos[0].Trim();
                        string PROMEDIO = datos[1].Trim();

                        int EDAD = CalcularEdadDesdeCURP(CURP);
                        string SEXO = DeterminarSexoDesdeCURP(CURP);

                        dataTable.Rows.Add(CURP, PROMEDIO, EDAD, SEXO);
                    }
                }

                DGVDATOS.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR, NO SE PUDO CARGAR TU ARCHIVO VUELVE A INTENTARLO " + ex.Message);
            }
        }

        //CALCULAR EDED CON LA CURP
        private int CalcularEdadDesdeCURP(string CURP)
        {
            if (CURP.Length < 18) return 0; // CURP NO PASA

            string fechaNacimiento = CURP.Substring(4, 6);
            int año = int.Parse(fechaNacimiento.Substring(0, 2));
            int mes = int.Parse(fechaNacimiento.Substring(2, 2));
            int dia = int.Parse(fechaNacimiento.Substring(4, 2));

            // SABER SIGLO ENTRE LOS ANOS (1900 o 2000)
            año += (año < 30) ? 2000 : 1900;

            DateTime fechaNacimientoReal = new DateTime(año, mes, dia);
            int EDAD = DateTime.Today.Year - fechaNacimientoReal.Year;

            if (DateTime.Today < fechaNacimientoReal.AddYears(EDAD))
                EDAD--;

            return EDAD;
        }

        //SABER EL SEXO CON LA CURP
        private string DeterminarSexoDesdeCURP(string CURP)
        {
            if (CURP.Length < 18) return "N/A"; // CURP NO PASA

            char SEXO = CURP[10]; // EL CARACTER 11VO DEFINE EL SEXO
            return (SEXO == 'H') ? "Masculino" : "Femenino";
        }
    }
}