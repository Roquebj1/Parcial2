using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Parcial_2.Clases
{
    class Promedio : IPromedio
    {
        public string[,] Clasificar_Alumnos(string[,] matriz, string seccion)
        {
            string[,] alumnos = new string[1, 2];

            int actual;
            int mayor = 0;
            int totalfila = matriz.GetLength(0);
            int filasec = totalfila;
            int totalcolumn = matriz.GetLength(1);
            for (int fila = 1; fila < totalfila; fila++)
            {

                if (matriz[fila, EnumColumnas.Seccion] == seccion)
                {

                    actual = Convert.ToInt32(matriz[fila, EnumColumnas.num1])
                            + Convert.ToInt32(matriz[fila, EnumColumnas.num2])
                            + Convert.ToInt32(matriz[fila, EnumColumnas.num3]);

                   

                    if (mayor > actual)
                    {
                        alumnos[0, 1] = mayor.ToString();

                    } else
                    {
                        alumnos[0, 0] = matriz[fila, EnumColumnas.Nombre];
                        alumnos[0, 1] = actual.ToString();
                        mayor = actual;
                    }



                }


            }

            return alumnos;
        }

        public string nombre_nota_mayor(string[,] matriz)
        {
            string nombre = "";

            int actual;
            int mayor = 0;
            int totalfila = matriz.GetLength(0);
            int filasec = totalfila;
            int totalcolumn = matriz.GetLength(1);
            for (int fila = 1; fila < totalfila; fila++)
            {

                int p1 = Convert.ToInt32(matriz[fila, EnumColumnas.num1]);
                int p2 = Convert.ToInt32(matriz[fila, EnumColumnas.num2]);
                int p3 = Convert.ToInt32(matriz[fila, EnumColumnas.num3]);

                actual = (p1 + p2 + p3) / 3;
                
                if (actual > mayor)
                {
                    nombre = matriz[fila, EnumColumnas.Nombre];
                    mayor = actual;
                }
            }

            return nombre;
        }

        public string nombre_nota_mayor(string[,] matriz, string  seccion)
        {
            string nombre = "";

            int actual;
            int mayor = 0;
            int totalfila = matriz.GetLength(0);
            int filasec = totalfila;
            int totalcolumn = matriz.GetLength(1);


            for (int fila = 1; fila < totalfila; fila++)
            {
                if (matriz[fila, EnumColumnas.Seccion] == seccion)
                {
                    int p1 = Convert.ToInt32(matriz[fila, EnumColumnas.num1]);
                    int p2 = Convert.ToInt32(matriz[fila, EnumColumnas.num2]);
                    int p3 = Convert.ToInt32(matriz[fila, EnumColumnas.num3]);

                    actual = (p1 + p2 + p3) / 3;

                    if (actual > mayor)
                    {
                        nombre = matriz[fila, EnumColumnas.Nombre];
                        mayor = actual;
                    }
                }
                    
            }

            return nombre;
        }

        public int promedio_general_seccion(string[,] matriz,  string seccion)
        {
            int Acum = 0;
            int Prom;
            int totalfila = matriz.GetLength(0);
            int filasec = totalfila;
            int totalcolumn = matriz.GetLength(1);
            for (int fila = 1; fila < totalfila; fila++)
            {
                if (matriz[fila, EnumColumnas.Seccion] == seccion)
                {
                    Acum = Acum 
                        + Convert.ToInt32(matriz[fila, EnumColumnas.num1])
                        +Convert.ToInt32(matriz[fila, EnumColumnas.num2])
                        +Convert.ToInt32(matriz[fila, EnumColumnas.num3]);
                }
                else
                {
                    filasec--;
                }

            }
            
            Prom = (Acum / (filasec - 1)) / 3;
            return Prom;
        }

        public int promedio_por_parcial(string[,] matriz, int columna_parcial)
        {
            int Acum = 0;
            int Prom;
            int totalfila = matriz.GetLength(0);
            int totalcolumn = matriz.GetLength(1);
            for (int fila = 1; fila < totalfila; fila++)
            {
                Acum = Acum + Convert.ToInt32(matriz[fila, columna_parcial]);
            }
            Prom = Acum / (totalfila - 1);
            return Prom;
        }

        public int promedio_por_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            int Acum = 0;
            int Prom;
            int totalfila = matriz.GetLength(0);
            int filasSecc = totalfila;
            int totalcolumn = matriz.GetLength(1);
            for (int fila = 1; fila < totalfila; fila++)
            {
                if (matriz[fila, EnumColumnas.Seccion] == seccion)
                {
                    Acum = Acum + Convert.ToInt32(matriz[fila, columna_parcial]);
                   
                
                } else
                {
                    filasSecc--;
                }
                
            }
            Prom = Acum / (filasSecc - 1);
            return Prom;
        }
    }
}
