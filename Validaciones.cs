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
        public static string ValidarRegistro(string tipo, string documento, string nombres, string paterno, string materno)
        {
            if (tipo == "DNI" && documento.Length != 8)
                return "El DNI debe tener 8 dígitos.";

            if (tipo == "RUC" && documento.Length != 11)
                return "El RUC debe tener 11 dígitos.";

            if (tipo == "CE" && documento.Length != 11)
                return "La Cédula de Extranjería debe tener 11 dígitos.";

            if (nombres == "" || paterno == "" || materno == "")
                return "Ingrese nombres y apellidos.";

            return "";
        }
    }
}