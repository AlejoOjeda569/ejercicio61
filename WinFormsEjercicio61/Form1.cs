namespace WinFormsEjercicio61
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InicializarLosDatos();
        }

        private void InicializarLosDatos()
        {
            txtDecimal.Clear();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var Numero = int.Parse(txtDecimal.Text);

                DataGridViewRow r = construirfila();
                Setearfila(r, Numero);
                Agregarfila(r);
                MessageBox.Show("Registro de los datos", "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information

                    );
                InicializarLosDatos();
            }
        }

        private void Agregarfila(DataGridViewRow r)
        {
            dataGridView1.Rows.Add(r);
        }

        private void Setearfila(DataGridViewRow r, int numero)
        {
            r.Cells[colDecimal.Index].Value = numero;
            r.Cells[colBinario.Index].Value = ConvertirBinario(numero);

        }

        private DataGridViewRow construirfila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dataGridView1);
            return r;
        }

        private bool ValidarDatos()
        {
            bool esvalido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtDecimal.Text, out int nro))
            {
                esvalido = false;
                errorProvider1.SetError(txtDecimal, "Nro fuera de la linea");
            }
            return esvalido;
        }
        private string ConvertirBinario(int numero)
        {
            if (numero == 0)
            {
                return "0";
            }
            string binario = "";
            while (numero > 0)
            {
                int resisuo = numero % 2;
                binario = resisuo + binario;
                numero = numero / 2;
            }
            return binario;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estas seguro?", "Comfirmacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado==DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}