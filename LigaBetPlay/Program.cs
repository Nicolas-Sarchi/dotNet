using LigaBetPlay.View;
using LigaBetPlay.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Federacion> ligas = new List<Federacion>();
        MainMenu menu = new MainMenu();
        int opcion;

        do
        {
            opcion = menu.MostrarMenu();

            switch (opcion)
            {
                case 1:
                    int opcionPlantel;
                    MenuPlantel menuPlantel = new MenuPlantel();
                    do
                    {
                        opcionPlantel = menuPlantel.menuPlantel();
                    } while (opcionPlantel != 6);
                    break;
                case 2:
                    int opcionBusqueda;
                    MenuBusqueda menuBusqueda = new MenuBusqueda();
                    do
                    {
                        opcionBusqueda = menuBusqueda.ConsultaDatos();
                        
                    } while (opcionBusqueda != 4);
                    break;
                case 3:
                    Console.WriteLine("Hasta luego.");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                    break;
            }

        } while (opcion != 3);
    }
}







