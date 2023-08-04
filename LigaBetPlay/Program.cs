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
                                Liga ligabuscarEntrenador = new Liga();
                                Liga opcionligaEntrenador = ligabuscarEntrenador.buscarLiga(Ligas);
                                Equipo equipoBuscarEntrenador = new Equipo();
                                equipoBuscarEntrenador = equipoBuscarEntrenador.buscarEquipo(opcionligaEntrenador.EquiposDeLiga);
                                Entrenador Entrenador = new Entrenador();
                                Entrenador = Entrenador.agregarEntrenador();
                                equipoBuscarEntrenador.entrenadores.Add(Entrenador);
                                break;
                            case 3:
                                Liga ligabuscarMasajista = new Liga();
                                Liga opcionligaMasajista = ligabuscarMasajista.buscarLiga(Ligas);
                                Equipo equipoBuscarMasajista = new Equipo();
                                equipoBuscarMasajista = equipoBuscarMasajista.buscarEquipo(opcionligaMasajista.EquiposDeLiga);
                                Masajista Masajista = new Masajista();
                                Masajista = Masajista.agregarMasajista();
                                equipoBuscarMasajista.masajistas.Add(Masajista);
                                break;
                            case 4:
                                Liga ligabuscarJugador = new Liga();
                                Liga opcionligaJugador = ligabuscarJugador.buscarLiga(Ligas);
                                Equipo equipoBuscarJugador = new Equipo();
                                equipoBuscarJugador = equipoBuscarJugador.buscarEquipo(opcionligaJugador.EquiposDeLiga);
                                Jugador jugador = new Jugador();
                                jugador = jugador.agregarJugador();
                                equipoBuscarJugador.jugadores.Add(jugador);
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
                                Console.WriteLine("------------------ Buscar Equipo -----------------");
                                Liga ligabuscar = new Liga();
                                Liga opcionliga = ligabuscar.buscarLiga(Ligas);
                                Equipo equipoBuscar = new Equipo();
                                equipoBuscar.buscarEquipo(opcionliga.EquiposDeLiga);
                                break;
                            case 2:
                                Console.WriteLine("--------------- Listar Jugadores por Equipo --------------");
                                Liga ligaListar = new Liga();
                                Liga opcionligaListar = ligaListar.buscarLiga(Ligas);
                                Equipo equipoListar = new Equipo();
                                equipoListar = equipoListar.buscarEquipo(opcionligaListar.EquiposDeLiga);
                                equipoListar.ListarJugadores(equipoListar.jugadores);
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



