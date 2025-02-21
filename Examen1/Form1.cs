namespace Examen1
{
    public partial class Form1 : Form
    {
        string filePath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_CARGAR_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = openFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                try
                {
                    string documento = File.ReadAllText(filePath);

                    string[] fila = documento.Split('\n');
                    string[] col = fila[0].Split(',');

                    DGV.ColumnCount = col.Length+2;
                    DGV.RowCount = fila.Length;
                    for (int i = 0; i < col.Length; i++)
                    {
                        DGV.Rows[0].Cells[i].Value = col[i];
                    }
                    for (int i = 1; i < (fila.Length) - 1; i++)
                    {
                        col = fila[i].Split(',');
                        for (int j = 0; j < col.Length; j++)
                        {
                            DGV.Rows[i].Cells[j].Value = col[j];
                            string curp = col[0];
                            edadYsexo(curp);
                        }
                    }
                    //string curp = CURP.Text;
                    //edadYsexo(curp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                }
            }
        }

        public string[] edadYsexo(string curp)
        {
            string[] retorno = new string[2];

            string ano = curp[4].ToString() + curp[5].ToString();
            string mes = curp[6].ToString() + curp[7].ToString();
            string dia = curp[8].ToString() + curp[9].ToString();

            string sexo = curp[10].ToString();
            retorno[1] = sexo;

            DateTime fechaNac = DateTime.Parse(dia + "/" + mes + "/" + ano);

            DateTime hoy = DateTime.Today;
            TimeSpan edadHoras = hoy.Date - fechaNac.Date;
            DateTime edad = new DateTime() + edadHoras;

            if (hoy.Month < fechaNac.Month)
            {
                retorno[0] = (edad.Year - 1) + " años";
            }
            else
            {
                retorno[0] = edad.Year + " años";
            }
            return retorno;
        }
    }
}
