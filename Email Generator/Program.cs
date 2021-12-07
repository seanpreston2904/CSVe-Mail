namespace CSVeMail
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            MainForm mainForm = new MainForm();

            //Disable form resizing and maximize button
            mainForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            mainForm.MaximizeBox = false;

            Application.Run(mainForm);
        }
    }
}