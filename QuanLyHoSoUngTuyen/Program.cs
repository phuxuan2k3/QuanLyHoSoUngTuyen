using GUI;

namespace QuanLyHoSoUngTuyen
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new GUI_Base());
            //Application.Run(new GUI_DoanhNghiep());
             Application.Run(new GUI_NhanVienTiepNhan());
        }
    }
}