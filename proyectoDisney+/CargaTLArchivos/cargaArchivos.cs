using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace proyectoDisney_.CargaTLArchivos
{
    class cargaArchivos
    {
        public List<string> resultList;
        /// <summary>
        /// Funcion que retornara los resultados que coinciden con el nombre de la pelicula a buscar
        /// </summary>
        /// <param name="value"></param> nombre de la pelicula
        /// <returns></returns>
        public List<string> LoadingTxt(string value){
        List<string> filesData = new List<string>();
            var myregex = new Regex(value, RegexOptions.IgnoreCase);



            //Archivo Disney
            StreamWriter archivoDisneytxt = new StreamWriter("Disney.txt", true);
            archivoDisneytxt.Close();
            string[] archivoDisneyLines = File.ReadAllLines("Disney.txt");

            //Archivo Pixar
            StreamWriter escribirPixarTxt = new StreamWriter("Pixar.txt", true);
            escribirPixarTxt.Close();
            string[] escribirPixarLines = File.ReadAllLines("Pixar.txt");

            //Archivo Marvel
            StreamWriter escribirMarvelTxt = new StreamWriter("Marvel.txt", true);
            escribirMarvelTxt.Close();
            string[] escribirMarvelLines = File.ReadAllLines("Marvel.txt");

            //Archivo Star Wars
            StreamWriter escribirStarWarsTxt = new StreamWriter("Star Wars.txt", true);
            escribirStarWarsTxt.Close();
            string[] escribirStarWarsLines = File.ReadAllLines("Star Wars.txt");

            //Archivo National Geographic
            StreamWriter escribirNatGeoTxt = new StreamWriter("Nat Geo.txt", true);
            escribirNatGeoTxt.Close();
            string[] escribirNatGeoLines = File.ReadAllLines("Nat Geo.txt");

            //Llenando mi lista string con todas las lineas de los archivos
            foreach (string fila in archivoDisneyLines)
            {
                if (!string.IsNullOrEmpty(fila))
                {
                    filesData.Add(fila);
                }
            }      
            
            foreach (string fila in escribirPixarLines)
            {
                if (!string.IsNullOrEmpty(fila))
                {
                    filesData.Add(fila);
                }
            }     
            
            foreach (string fila in escribirMarvelLines)
            {
                if (!string.IsNullOrEmpty(fila))
                {
                    filesData.Add(fila);
                }
            }      
            
            foreach (string fila in escribirStarWarsLines)
            {
                if (!string.IsNullOrEmpty(fila))
                {
                    filesData.Add(fila);
                }
            }      
            
            foreach (string fila in escribirNatGeoLines)
            {
                if (!string.IsNullOrEmpty(fila))
                {
                    filesData.Add(fila);
                }
            }
            //Retornara todos los nombres de las peliculas que hacen match con lo que ingreso el usuario
            return resultList = filesData.Where(i => myregex.IsMatch(i)).ToList();
        }
    }

}
