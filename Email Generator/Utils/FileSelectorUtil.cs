using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{

    /// <summary>
    /// Utility class for dealing with file selection and validation.
    /// </summary>
    internal static class FileSelectorUtil
    {

        /// <summary>
        /// Prompts the user to open a file from disk.
        /// </summary>
        /// <returns>Full path of the selected file</returns>
        public static string OpenSource() 
        {

            //Open new file dialogue
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "|*.csv" };

            if (ofd.ShowDialog() == DialogResult.OK) { return ofd.FileName; }

            return "";

        }

        /// <summary>
        /// Checks if the provided source directory is a csv file, along with null-checks.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool CheckSource(string source)
        {
            return !(source == "" || source == null || source.EndsWith(".csv"));
        }

        public static string SelectDestination()
        {

            //Prompt user to choose where to save the file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "|*.csv";
            saveFileDialog.Title = "Save File";
            saveFileDialog.ShowDialog();

            return saveFileDialog.FileName;

        }

    }
}
