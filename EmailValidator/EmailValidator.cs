using System;
using System.Text.RegularExpressions;

namespace EmailValidator
{
    public class EmailValidator
    {
        public static bool ValidateEmail(string text)
        {
            string CorreoElectronico = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z\.!#$%&'*+/=?^_`{|}~-]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[-0-9a-z_])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([-0-9a-z_][-0-9a-z_]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

            return Regex.IsMatch(text, CorreoElectronico);
        }
    }
}
