using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryChiarenzaSP3
{
    public partial class frmRepuestos : Form
    {

        // DECLARACION DE VARIABLES GLOBALES

        // Array de 1 dimension - vector - sin elementos
        string[] vecRegistros;

        // Array de 2 dimensiones - matriz - sin elementos
        string[,] matRegistros;

        // Array de 1 dimension - vector - sin elementos
        string[] vecRepuestos = new string[3];

        // Array de 2 dimensiones - matriz
        string[,] matRepuestos = new string[2, 2];

        int indiceRegistros = 0;


        struct Repuesto
        {
            public string Marca;
            public string Origen;
            public string Numero;
            public string Descripcion;
            public string Precio;
        }
        Repuesto[] repuestos = new Repuesto[100];
        int cantidad = 0;

        public frmRepuestos()
        {
            InitializeComponent();
        }

        private void frmRepuestos_Load(object sender, EventArgs e)
        {
            cmbMarca.Items.Add("P");
            cmbMarca.Items.Add("F");
            cmbMarca.Items.Add("R");
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // CONTROL CARGA DE 100 REPUESTOS
            if (cantidad == 100)
            {
                MessageBox.Show("Ya se cargaron los 100 repuestos.");
                return;
            }

            // CONTROLAR MARCA
            if (cmbMarca.SelectedIndex == -1) {
                MessageBox.Show("Debe seleccionar una marca.");
                return;
            }

            // CONTROLAR ORIGEN
            if (!rdbNacional.Checked && !rdbImportado.Checked)
            {
                MessageBox.Show("Debe seleccionar el origen.");
                return;
            }

            // CONTROLAR NUMERO
            if (txtNumRepuesto.Text == "")
            {
                MessageBox.Show("Debe ingresar el número del repuesto.");
                return;
            }
            int numero;

            if (!int.TryParse(txtNumRepuesto.Text, out numero))
            {
                MessageBox.Show("El número del repuesto debe ser un valor numérico.");
                return;
            }

            if (numero < 0 || numero > 999999)
            {
                MessageBox.Show("El número del repuesto no puede superar los 6 dígitos.");
                return;
            }

            // VERIFICAR QUE NO EXISTA EL MISMO NUMERO

            for (int i = 0; i < cantidad; i++)
            {
                if (repuestos[i].Numero == txtNumRepuesto.Text)
                {
                    MessageBox.Show("Ya existe un repuesto con ese número.");
                    return;
                }
            }

            // VERIFICAR 
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripcion sobre el repuesto");
                return;
            }

            if (txtDescripcion.Text.Length > 50)
            {
                MessageBox.Show("La descripcion no puede superar los 50 caracteres");
                return;
            }

            // VERIFICAR PRECIO

            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio para el repuesto");
                return;
            }

            float precio;

            if (!float.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("El precio debe ser numérico");
                return;
            }

            string varMarca = cmbMarca.Text;
            string varOrigen;

            // Estoy registrando como texto a Marca. lo cargado se guardara en la cmb

            if (rdbNacional.Checked == true)
            {
                varOrigen = "Nacional";

            }

            else
            {

                varOrigen = "Importado";

            }

            // GUARDAR REPUESTOS

            repuestos[cantidad].Marca = varMarca;
            repuestos[cantidad].Origen = varOrigen;
            repuestos[cantidad].Numero = txtNumRepuesto.Text;
            repuestos[cantidad].Descripcion = txtDescripcion.Text;
            repuestos[cantidad].Precio = txtPrecio.Text;

            cantidad++;

             }

            // Grabar en el VECTOR - Array de 1 dimension

            // Ejemplo del uso de vector de strings

            //vecRepuestos[indiceRegistros] =  varMarca + " " + varOrigen;
            //indiceRegistros++;

            // Añadir los elementos del vector a la lista

            // Bucle repetitivo p/ recorrer el vector y añadir sus elementos a la lista
            //for (int indice = 0; indice < vecRepuestos.Length; indice++)
            //{
            // lsbDatos.Items.Add(vecRepuestos[indice] = cmbMarca.Text);
            //}

        private void txtNumRepuesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string marcaConsulta = cmbMarca.Text;
            string origenConsulta;

            if (rdbNacional.Checked)
            {
                origenConsulta = "Nacional";
            }
            else
            {
                origenConsulta = "Importado";
            }

            lsbDatos.Items.Clear();

            for (int i = 0; i < cantidad; i++)
            {
                if (repuestos[i].Marca == marcaConsulta &&
                    repuestos[i].Origen == origenConsulta)
                { 

            lsbDatos.Items.Add(
                repuestos[i].Numero + " - " +
                repuestos[i].Descripcion + " - $ " +
                repuestos[i].Precio

            );

                }   

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}

