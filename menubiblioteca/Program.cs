using System;

class Program
{
    static void Main()
    {
        ShowMainMenu();
    }

    // =========================
    // MENÚ PRINCIPAL
    // =========================
    static void ShowMainMenu()
    {
        int option = 0;

        while (option != 6)
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA DE BIBLIOTECA ===");
            Console.WriteLine("1. Libros");
            Console.WriteLine("2. Usuarios");
            Console.WriteLine("3. Préstamos");
            Console.WriteLine("4. Búsquedas y reportes");
            Console.WriteLine("5. Guardar / Cargar datos");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");

            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    Console.WriteLine("Entrando al menú de libros...");
                    ShowBooksMenu();
                    Console.ReadKey();
                    
                    break;

                case 2:
                    Console.WriteLine("Entrando al menú de usuarios...");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("Entrando al menú de préstamos...");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine("Entrando a búsquedas y reportes...");
                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine("Entrando a guardar/cargar datos...");
                    Console.ReadKey();
                    break;

                case 6:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    Console.ReadKey();
                    break;
            }
        }
    }

    // =========================
    // MENÚ LIBROS
    // =========================
    static void ShowBooksMenu()
    {
        int option = 0;

        while (option != 6)
        {
            Console.Clear();
            Console.WriteLine("=== MENÚ LIBROS ===");
            Console.WriteLine("1. Registrar libro");
            Console.WriteLine("2. Listar libros");
            Console.WriteLine("3. Ver detalle");
            Console.WriteLine("4. Actualizar libro");
            Console.WriteLine("5. Eliminar libro");
            Console.WriteLine("6. Volver");

            Console.Write("Seleccione una opción: ");
            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    RegisterBook();
                    break;

                case 2:
                    ListBooksMenu();
                    break;

                case 3:
                    ViewBookDetail();
                    break;

                case 4:
                    UpdateBookMenu();
                    break;

                case 5:
                    DeleteBook();
                    break;

                case 6:
                    Console.WriteLine("Volviendo al menú principal...");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    Console.ReadKey();
                    break;
            }
        }
    }

    // =========================
    // FUNCIONES DE LIBROS
    // =========================
    static void RegisterBook()
    {
        Console.Clear();
        Console.WriteLine("Registrar libro...");
        Console.ReadKey();
    }

    static void ListBooksMenu()
    {
        Console.Clear();
        Console.WriteLine("Listando libros...");
        Console.ReadKey();
    }

    static void ViewBookDetail()
    {
        Console.Clear();
        Console.WriteLine("Mostrando detalle del libro...");
        Console.ReadKey();
    }

    static void UpdateBookMenu()
    {
        Console.Clear();
        Console.WriteLine("Actualizando libro...");
        Console.ReadKey();
    }

    static void DeleteBook()
    {
        Console.Clear();
        Console.WriteLine("Eliminando libro...");
        Console.ReadKey();
    }
}


