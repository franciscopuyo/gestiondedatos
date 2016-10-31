using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFrba.util
{
    class Validations
    {

        public static Boolean isOnlyAlphabetical(String text)
        {
            return !isEmpty(text) && !System.Text.RegularExpressions.Regex.IsMatch(text, @"^[A-Z]{1}[a-z]+$");
        }

        public static Boolean isValidString(String text)
        {
            return !isEmpty(text) && System.Text.RegularExpressions.Regex.IsMatch(text, @"^[A-Z a-z 0-9]+$");
        }

         public static Boolean isValidEmail(String text)
        {
            return !isEmpty(text) && System.Text.RegularExpressions.Regex.IsMatch(text, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
        }

        public static Boolean isValidNumericWithMaxLength(String number, int length)
        {
            int parsedValue;
            if (!int.TryParse(number, out parsedValue))
            {
                return false;
            }
            return number.Length <= length;
        }

        public static Boolean isValidNumeric(String number, int length)
        {
            int parsedValue;
            if (!int.TryParse(number, out parsedValue))
            {
                return false;
            }
            return number.Length == length;
        }

        public static Boolean isEmpty(String text)
        {
            return text == null || text == "";
        }


        internal static void validateOnlyAlphabetical(System.Windows.Forms.TextBox textBox, System.Windows.Forms.ErrorProvider errorProvider, string msg, ref Boolean valid)
        {
            if (!isOnlyAlphabetical(textBox.Text))
            {
                errorProvider.SetError(textBox, msg);
                valid = false;
            }
            else
            {
                errorProvider.Clear();
            }
        }

        internal static void validateString(System.Windows.Forms.TextBox textBox, System.Windows.Forms.ErrorProvider errorProvider, string msg, ref Boolean valid)
        {
            if (!isValidString(textBox.Text))
            {
                errorProvider.SetError(textBox, msg);
                valid = false;
            }
            else
            {
                errorProvider.Clear();
            }
        }

        internal static void validateIntWithLength(System.Windows.Forms.TextBox textBox, System.Windows.Forms.ErrorProvider errorProvider, string msg, int length, ref bool valid)
        {

            if (!isValidNumeric(textBox.Text, length))
            {
                errorProvider.SetError(textBox, msg);
                valid = false;
            }
            else
            {
                errorProvider.Clear();
            }
        }

        internal static void validateIntWithMaxLength(System.Windows.Forms.TextBox textBox, System.Windows.Forms.ErrorProvider errorProvider, string msg, int maxLength, ref bool valid)
        {

            if (!isValidNumericWithMaxLength(textBox.Text, maxLength))
            {
                errorProvider.SetError(textBox, msg);
                valid = false;
            }
            else
            {
                errorProvider.Clear();
            }
        }

        internal static void validateEmail(System.Windows.Forms.TextBox textBox, System.Windows.Forms.ErrorProvider errorProvider, string msg, ref bool valid)
        {
            if (!isValidEmail(textBox.Text))
            {
                errorProvider.SetError(textBox, msg);
                valid = false;
            }
            else
            {
                errorProvider.Clear();
            }
        }

        internal static void validateDateBeforeNow(System.Windows.Forms.DateTimePicker dateTimePicker, System.Windows.Forms.ErrorProvider errorProvider, string msg, ref bool valid)
        {
            if (dateTimePicker.Value.Date >= DateTime.Now.Date)
            {
                errorProvider.SetError(dateTimePicker, msg);
                valid = false;
            }
            else
            {
                errorProvider.Clear();
            }
        }

    }
}
