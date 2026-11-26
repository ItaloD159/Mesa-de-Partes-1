using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesa_de_Partes_1
{
    public static class Validaciones
    {

        //Quita los espacios en blanco, convierte a mayúsculas y reemplaza el caracter | por / para no tener problemas al guardar en el archivo de texto
        public static string LimpiarTexto(string texto)
        {
            return texto.Replace("|", "/").Trim().ToUpper();
        }

        //Devuelve true si el texto tiene solo dígitos (0-9)
        public static bool SoloNumeros(string texto)
        {
            foreach (char c in texto)
            {
                if (c < '0' || c > '9') return false;
            }
            return true;
        }

        //Devuelve el mensaje de error o "" si todo es correcto
        public static string ValidarRegistro(string tipoDocumento, string numeroDocumento, string nombres, string apellidoPaterno, string apellidoMaterno, string telefono)
        {
            if (tipoDocumento == "DNI" && numeroDocumento.Length != 8)
                return "El DNI debe tener 8 dígitos (solo números).";

            if (tipoDocumento == "RUC" && numeroDocumento.Length != 11)
                return "El RUC debe tener 11 dígitos (solo números).";

            if (tipoDocumento == "CE" && numeroDocumento.Length != 11)
                return "La Cédula de Extranjería debe tener 11 dígitos (solo números).";
            if (!SoloNumeros(numeroDocumento))
                return "El número de documento solo debe tener números.";

            if (nombres == "" || apellidoPaterno == "" || apellidoMaterno == "")
                return "Ingrese nombres y apellidos.";

            if (telefono == "" || !SoloNumeros(telefono))
                return "Ingrese un número de teléfono válido.";

            return "";
        }
    }
}
