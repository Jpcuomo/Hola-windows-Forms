using System.Text.RegularExpressions;

namespace Biblioteca
{
    public class Validador
    {
        public static bool ValidarNombre(string textoTbx)
        {
            string patron = @"^[A-Z][a-z]+$";
            
            if (!string.IsNullOrWhiteSpace(textoTbx) && Regex.IsMatch(textoTbx, patron))
            {
                return true;
            }
            return false; 
        }
    }
}