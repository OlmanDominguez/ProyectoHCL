using ProyectoHCL.Formularios;

namespace ProyectoHCL
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
            //ApplicationConfiguration.Initialize();
          // Application.Run(new PermisosRoLes());
            // Application.Run(new FORMULARIO()); HEAD
            //  Application.Run(new RegistrarUsuario());

            Application.Run(new Dashboard());
            //Application.Run(new NuevaReservacion());
            //Application.Run(new CtrlObjetos());

            //Application.Run(new CtrlClientes());
            //Application.Run(new CtrlUsuarios());
          //Application.Run(new CtrlUsuarios());
            
            Application.Run(new CtrlFacturacion());


        }
    }
}