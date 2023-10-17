using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Freireland.Tools
{
    public class Validate
    {
        //	solo caracteres y espacio en blanco
        public bool CheckOnlyText(string text)
        {
            Regex regex = new Regex(@"^\s*[\p{L}']+(\s+[\p{L}']+)*\s*$");
            return regex.IsMatch(text);
        }

        public bool CheckOnlyText1(string text)
        {
            Regex regex = new Regex(@"^\s*[\p{L}']+(\s+[\p{L}']+)*,\s*[\p{L}']+(\s+[\p{L}']+)*(\.\s*)?$");
            return regex.IsMatch(text);
        }

        public bool ValidarLatitudBingMaps(string latitud)
        {
            // Expresión regular para validar la latitud en formato Bing Maps
            string patron = @"^-?([1-8]?[1-9]|[1-9]0)\.\d{1,6}$";

            string latitudStr = latitud.ToString();

            return Regex.IsMatch(latitudStr, patron);
        }
        public bool ValidarLongitudBingMaps(string longitud)
        {
            // Expresión regular para validar la longitud en formato Bing Maps
            string patron = @"^-?((1[0-7]|[1-9])?\d(\.\d{1,6})?|180(\.0{1,6})?)$";

            string longitudStr = longitud.ToString();

            return Regex.IsMatch(longitudStr, patron);
        }


        public bool ValidateStudentCode(string code)
        {
            Regex regex = new Regex(@"^[a-zA-Z]{3}\d{7}$");
            return regex.IsMatch(code);
        }
        public bool IsUsernameValid(string username)
        {
            string pattern = "^[a-zA-Z]{1,5}[0-9]{2}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(username);
        }
        public bool IsPasswordValid(string password)
        {
            // Expresión regular para validar contraseñas
             string pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%?&])[A-Za-z\\d@$!%?&]{8,10}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(password);
        }



        //	validacion para CI
        public bool IsValidIdentificationNumber(string ci)
        {
            Regex regex = new Regex(@"\b\d+(?:-\w+)?\b");
            bool esValido = regex.IsMatch(ci);
            return esValido;
        }
        public bool CheckIsCI(string ci)
        {
            Regex regex = new Regex("^[A-Z]-[0-9]{7,10}$|^[0-9]{7,10}-[0-9]{1}[A-Z]$");
            return regex.IsMatch(ci);
        }

        public bool CheckIsCI1(string ci)
        {

            Regex regex = new Regex("^([0-9]{7,10})$");
            return regex.IsMatch(ci);
        }
        public bool CheckIsPhone(string phone)
        {
            Regex regex = new Regex("^(4[0-9]{6}|[67][0-9]{7})$");
            return regex.IsMatch(phone);
        }

        public bool CheckLatitude(string latitude)
        {
            Regex regex = new Regex("^[\\-\\+]?((0|([1-8]\\d?))(\\.\\d{1,10})?|90(\\.0{1,10})?)$");
            return regex.IsMatch(latitude);
        }
        public bool CheckLongitude(string longitude)
        {
            Regex regex = new Regex("^[\\-\\+]?(0(\\.\\d{1,10})?|([1-9](\\d)?)(\\.\\d{1,10})?|1[0-7]\\d{1}(\\.\\d{1,10})?|180\\.0{1,10})$");
            return regex.IsMatch(longitude);
        }

        public bool CheckMailSintax(string Mail_Address)
        {
            Regex regex = new Regex("^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$");
            return regex.IsMatch(Mail_Address);
        }
        public bool IsValidGender(string selectedValue)
        {
            // Verificar si se ha seleccionado un género válido
            return selectedValue == "M" || selectedValue == "F" ;
        }
        public bool IsValidBirthDate(string birthDateText)
        {
            DateTime birthDate;
            if (DateTime.TryParse(birthDateText, out birthDate))
            {
                if (birthDate > DateTime.Now)
                {
                    return false; 
                }


                return true;
            }

            return false; 
        }
        public bool IsValidRole(string selectedValue)
        {
            // Verificar si se ha seleccionado un rol válido
            return !string.IsNullOrWhiteSpace(selectedValue) && selectedValue != "Seleccione Rol";
        }


    }
}
