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

        //Devuelve el mensaje de error o "" si todo es correcto
        public static string ValidarRegistro(string tipoDocumento, string numeroDocumento, string nombres, string apellidoPaterno, string apellidoMaterno)
        {
            if (tipoDocumento == "DNI" && numeroDocumento.Length != 8)
                return "El DNI debe tener 8 dígitos.";

            if (tipoDocumento == "RUC" && numeroDocumento.Length != 11)
                return "El RUC debe tener 11 dígitos.";

            if (tipoDocumento == "CE" && numeroDocumento.Length != 11)
                return "La Cédula de Extranjería debe tener 11 dígitos.";

            if (nombres == "" || apellidoPaterno == "" || apellidoMaterno == "")
                return "Ingrese nombres y apellidos.";

            return "";
        }
    }
}
