using LigaBetPlay.View;
using LigaBetPlay.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Liga> Ligas = new List<Liga>();
        MainMenu menu = new MainMenu();
        int opcion = 0;
        do
        {
            opcion = menu.MostrarMenu();
            switch (opcion)
            {
                case 1:
                    int opcionPlantel = 0;
                    MenuPlantel menuPlantel = new MenuPlantel();
                    do
                    {
                        opcionPlantel = menuPlantel.menuPlantel();
                        switch (opcionPlantel)
                        {
                            case 1:
                                Liga ligabuscar = new Liga();
                                Liga opcionliga = ligabuscar.buscarLiga(Ligas);
                                Console.WriteLine(opcionliga.nombre);
                                Equipo equipo = new Equipo();
                                Equipo nuevoequipo = equipo.agregarEquipo();
                                Console.WriteLine(nuevoequipo.nombre);
                                opcionliga.EquiposDeLiga.Add(nuevoequipo);
                                break;
                            case 2:
                                Liga ligabuscarJugador = new Liga();
                                Liga opcionligaJugador = ligabuscarJugador.buscarLiga(Ligas);
                                Equipo equipoBuscarJugador = new Equipo();
                                equipoBuscarJugador.buscarEquipo(opcionligaJugador.EquiposDeLiga);
                                Jugador jugador = new Jugador();
                                
                                break;
                            default:
                                break;
                        }
                    } while (opcionPlantel != 6);
                    break;
                case 2:
                    int opcionBuscar = 0;
                    MenuBusqueda menuBusqueda = new MenuBusqueda();
                    do
                    {
                        opcionPlantel = menuBusqueda.ConsultaDatos();
                        switch (opcionPlantel)
                        {
                            case 1:
                                Liga ligabuscar = new Liga();
                                Liga opcionliga = ligabuscar.buscarLiga(Ligas);
                                Equipo equipoBuscar = new Equipo();
                                equipoBuscar.buscarEquipo(opcionliga.EquiposDeLiga);
                                break;
                            default:
                                break;
                        }

                    } while (opcionBuscar != 5);
                    break;
                case 3:
                    Liga liga = new Liga();
                    Ligas.Add(liga.agregarLiga());
                    liga.mostrarLigas(Ligas);
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        } while (opcion != 4);
    }

}



