using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2.Clases
{
    interface IPromedio
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <returns></returns>
        int promedio_por_parcial(string[,] matriz, int columna_parcial);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        int promedio_por_seccion(string[,] matriz, int columna_parcial, string seccion);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        int promedio_general_seccion(string[,] matriz, string seccion);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        string[,] Clasificar_Alumnos(string[,] matriz, string seccion);

        /// <summary>
        /// a
        /// </summary>
        /// <param name="matriz"></param>
        /// <returns></returns>
        string nombre_nota_mayor(string[,] matriz);

        string nombre_nota_mayor(string[,] matriz, string seccion);



    }
}

