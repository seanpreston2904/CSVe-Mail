using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;
using CSVeMail;

namespace Utils
{

    /// <summary>
    /// Utility class for generating email strings from the people model.
    /// </summary>
    internal static class EmailUtil
    {

        /// <summary>
        /// Generates a random string of numbers to a specified length.
        /// </summary>
        /// <param name="digits">The length of the string.</param>
        /// <returns></returns>
        public static string GenerateNumber(int digits) 
        {

            Random random = new Random();
            string number = "";

            for (int i = 0; i < digits; i++) { number+=(random.Next(10).ToString()); }

            return number;

        }

        /// <summary>
        /// Generates an email from a person object, based on user preferences.
        /// </summary>
        /// <param name="person">Person to generate email address from.</param>
        /// <returns></returns>
        public static string PersonToEmail(Person person) {

            //Start with person's first name, removing any spaces or hyphens
            string emailOut = person.firstName.Replace(" ", "").Replace("-", "");

            string suffix = "";

            //If the person's last name contains a hyphen
            if (person.lastName.Contains('-'))
            {

                //Split the last name and use the first character of each name for the suffix
                string[] splitName = person.lastName.Split('-');
                foreach (string name in splitName) { suffix += name[0].ToString(); }

            }

            //Otherwise just use the first character of the student's last name
            else { suffix = person.lastName[0].ToString(); }

            //Construct email address
            emailOut += suffix;

            //If the user has enabled random number generation
            if (UserSettings.Default.randomNumbers) { 

                string numbers = GenerateNumber((int)UserSettings.Default.randomNumbersCount);
                emailOut = (UserSettings.Default.randomNumbersPosition) ?
                    numbers + emailOut : emailOut + numbers;

            }

            emailOut += '@' + UserSettings.Default.emailDomain;

            return emailOut.ToLower();

        }

    }
}
