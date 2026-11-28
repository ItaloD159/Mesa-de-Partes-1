using System;
using System.Collections.Generic;
using System.IO;

namespace Mesa_de_Partes_1
{
    //Lee y escribe el archivo de expedientes
    public static class RepositorioExpedientes
    {
        //COlocamos la ruta donde se guardará el archivo de expedientes
        private static string rutaArchivo = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "MesaDePartes", "expedientes.txt");

        //Escribe todas las filas en el archivo
        public static void Guardar(List<string[]> filas)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(rutaArchivo));

            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                foreach (string[] fila in filas)
                    sw.WriteLine(string.Join("|", fila));
            }
        }

        //Lee el archivo y devuelve las filas
        public static List<string[]> Cargar(int numeroColumnas)
        {
            List<string[]> filas = new List<string[]>();
            if (!File.Exists(rutaArchivo)) return filas;

            using (StreamReader sr = new StreamReader(rutaArchivo))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] datos = linea.Split('|');
                    if (datos.Length == numeroColumnas)
                        filas.Add(datos);
                }
            }
            return filas;
        }
    }
}
