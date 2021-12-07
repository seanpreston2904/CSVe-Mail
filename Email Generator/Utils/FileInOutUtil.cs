using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;

namespace Utils
{
    /// <summary>
    /// Utility class to deal with file input/output.
    /// </summary>
    internal class FileInOutUtil
    {

        /// <summary>
        /// Extracts fist/last names from a .CSV file into a list of Person objects.
        /// </summary>
        /// <param name="source">The full path of the .CSV file to read from.</param>
        /// <returns>List of Person objects from the specified .CSV file.</returns>
        public static List<Person> GetPeople(string source)
        {

            List<Person> people = new List<Person>();

            var reader = new StreamReader(source);

            //Eat table headers
            reader.ReadLine();

            while (!reader.EndOfStream)
            {

                //Read values and add them to the data list
                var line = reader.ReadLine();
                var values = line.Split(',');

                people.Add(new Person(values[0], values[1]));

            }

            return people;

        }

    }
}
