using Parcial_2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCargarArchivo_Click(object sender, EventArgs e)
        {
            limpiarCaja();
            ClsArchivo arch = new ClsArchivo();
            OpenFileDialog msj = new OpenFileDialog();
            msj.Title = "Porfa, Selecciona tu archivo plano";
            msj.InitialDirectory = @"C:\Users\Usuario\Documents\Archivo Plano";
            msj.Filter = "Archivo Plano (*.csv)|*.csv";

            if (msj.ShowDialog() == DialogResult.OK)
            {
                var archivo = msj.FileName;
                string resultado = arch.LeerTodoArchivo(archivo);
                ArregloNotas = arch.LeerArchivo(archivo);
                textBoxArchivo.Text = resultado;
            }
        }

        private void buttonPromedioporParcial_Click(object sender, EventArgs e)
        {
            limpiarCaja();
            Promedio promedio = new Promedio();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {
                string[] DatosUnitarios = linea.Split(';');
               
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.num1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.num2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.num3] = DatosUnitarios[4];
                NumeroLinea++;
            }

            int promedioP1 = promedio.promedio_por_parcial(ArregloDosDimensiones, EnumColumnas.num1);
            int promedioP2 = promedio.promedio_por_parcial(ArregloDosDimensiones, EnumColumnas.num2);
            int promedioP3 = promedio.promedio_por_parcial(ArregloDosDimensiones, EnumColumnas.num3);

            listBoxResultado.Items.Add($"Promedio de Tercer Parcial: {promedioP3}");
            listBoxResultado.Items.Add($"Promedio de Segundo Parcial: {promedioP2}");
            listBoxResultado.Items.Add($"Promedio de Primer Parcial: {promedioP1}");
        }

        private void buttonPromedioporSeccion_Click(object sender, EventArgs e)
        {
            limpiarCaja();
            Promedio promedio = new Promedio();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {
               
                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.num1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.num2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.num3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Seccion] = DatosUnitarios[5];
                NumeroLinea++;
            }

            int promSA1 = promedio.promedio_por_seccion(ArregloDosDimensiones, EnumColumnas.num1, "A");
            int promSA2 = promedio.promedio_por_seccion(ArregloDosDimensiones, EnumColumnas.num2, "A");
            int promSA3 = promedio.promedio_por_seccion(ArregloDosDimensiones, EnumColumnas.num3, "A");
            int promSB1 = promedio.promedio_por_seccion(ArregloDosDimensiones, EnumColumnas.num1, "B");
            int promSB2 = promedio.promedio_por_seccion(ArregloDosDimensiones, EnumColumnas.num2, "B");
            int promSB3 = promedio.promedio_por_seccion(ArregloDosDimensiones, EnumColumnas.num3, "B");
            int promSC1 = promedio.promedio_por_seccion(ArregloDosDimensiones, EnumColumnas.num1, "C");
            int promSC2 = promedio.promedio_por_seccion(ArregloDosDimensiones, EnumColumnas.num2, "C");
            int promSC3 = promedio.promedio_por_seccion(ArregloDosDimensiones, EnumColumnas.num3, "C");

            listBoxResultado.Items.Add($"Promedio Sección A, Parcial 1: {promSA1}");
            listBoxResultado.Items.Add($"Promedio Sección A, Parcial 2: {promSA2}");
            listBoxResultado.Items.Add($"Promedio Sección A, Parcial 3: {promSA3}");

            listBoxResultado.Items.Add($"Promedio Sección B, Parcial 1: {promSB1}");
            listBoxResultado.Items.Add($"Promedio Sección B, Parcial 2: {promSB2}");
            listBoxResultado.Items.Add($"Promedio Sección B, Parcial 3: {promSB3}");

            listBoxResultado.Items.Add($"Promedio Sección C, Parcial 1: {promSC1}");
            listBoxResultado.Items.Add($"Promedio Sección C, Parcial 2: {promSC2}");
            listBoxResultado.Items.Add($"Promedio Sección C, Parcial 3: {promSC3}");


        }

        private void limpiarCaja()
        {
            listBoxResultado.Items.Clear();
        }

        private void buttonPromedioGeneralSeccion_Click(object sender, EventArgs e)
        {
            limpiarCaja();
            Promedio promedio = new Promedio();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.num1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.num2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.num3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Seccion] = DatosUnitarios[5];
                NumeroLinea++;
            }

            int promedioGeneralA = promedio.promedio_general_seccion(ArregloDosDimensiones, "A");
            int promedioGeneralB = promedio.promedio_general_seccion(ArregloDosDimensiones, "B");
            int promedioGeneralC = promedio.promedio_general_seccion(ArregloDosDimensiones, "C");

            listBoxResultado.Items.Add($"Promedio General Sección A: {promedioGeneralA}");
            listBoxResultado.Items.Add($"Promedio General Sección B: {promedioGeneralB}");
            listBoxResultado.Items.Add($"Promedio General Sección C: {promedioGeneralC}");
        }

        private void buttonClasificarAlumnos_Click(object sender, EventArgs e)
        {
            limpiarCaja();
            Promedio promedio = new Promedio();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.num1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.num2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.num3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Seccion] = DatosUnitarios[5];
                NumeroLinea++;
            }

            string[,] alumnoClasificado = promedio.Clasificar_Alumnos(ArregloDosDimensiones, "B");
            string nombre = alumnoClasificado[0, 0];
            string nota = alumnoClasificado[0, 1];

            listBoxResultado.Items.Add($"Mejores Notas");
            listBoxResultado.Items.Add($"SECCIÓN B:");
            listBoxResultado.Items.Add($"Nombre: {nombre}");
            listBoxResultado.Items.Add($"Sumatoria de los parciales: {nota}");
        }

        private void buttonNotaMayor_Click(object sender, EventArgs e)
        {
            limpiarCaja();
            Promedio promedio = new Promedio();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {

                string[] Datos = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Correlativo] = Datos[0];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Nombre] = Datos[1];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.num1] = Datos[2];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.num2] = Datos[3];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.num3] = Datos[4];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Seccion] = Datos[5];
                NumeroLinea++;
            }

            string mayor = promedio.nombre_nota_mayor(ArregloDosDimensiones, "C");

            listBoxResultado.Items.Add($" Alumno con mayor promedio SeccionC");
            listBoxResultado.Items.Add($"Nombre: {mayor}");
        }

        private void buttonNotaMayorGeneral_Click(object sender, EventArgs e)
        {
            limpiarCaja();
            Promedio promedio = new Promedio();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.num1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.num2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.num3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Seccion] = DatosUnitarios[5];
                NumeroLinea++;
            }

            string mayor = promedio.nombre_nota_mayor(ArregloDosDimensiones);

            listBoxResultado.Items.Add($" Alumno con mayor promedio");
            listBoxResultado.Items.Add($"Nombre: {mayor}");
        }

        private void textBoxArchivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

   


     
        
    
