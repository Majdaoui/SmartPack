using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SmartPack.Classes
{
    public class GlobalAPI
    {

        /// <summary>
        /// Comprova si la matrícula és vàlida
        /// Mètode que comprova si la matrícula és vàlida ha de tenir 4 números i 3 lletres
        /// Si la matrícula és vàlida retorna true, si no, retorna false
        /// tambe valida la matricula antiga de 2 lletres 4 numeros i 2 lletres
        /// </summary>
        /// <param name="tmatricula"></param>
        /// <returns></returns>
        public static bool EsMatriculaValida(string tmatricula)
        {
            string matricula = tmatricula.Trim().ToUpper();
            string modernaPattern = @"^\d{4}[A-Z]{3}$";
            string antigaPattern = @"^[A-Z]{1,2}\d{4}[A-Z]{2}$";
            if (Regex.IsMatch(matricula, modernaPattern) || Regex.IsMatch(matricula, antigaPattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
