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
                   
                    ShowBooksMenu();
                    break;

                case 2:
                  ShowUsersMenu();
                   

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

   static void ShowUsersMenu()
{
    int option = 0;

    while (option != 6)
    {
        Console.Clear();
        Console.WriteLine(" MENÚ USUARIOS ");
        Console.WriteLine("1. Registrar usuario");
        Console.WriteLine("2. Listar usuarios");
        Console.WriteLine("3. Ver detalle");
        Console.WriteLine("4. Actualizar usuario");
        Console.WriteLine("5. Eliminar usuario");
        Console.WriteLine("6. Volver");

        Console.Write("Seleccione una opción: ");

        int.TryParse(Console.ReadLine(), out option);

        switch (option)
        {
            case 1:
                RegisterUser();
                break;

            case 2:
                ListUsers();
                break;

            case 3:
                ViewUserDetail();
                break;

            case 4:
                UpdateUserMenu();
                break;

            case 5:
                DeleteUser();
                break;

            case 6:
                break;

            default:
                Console.WriteLine("Opción inválida");
                //Console.ReadKey();
                break;
        }
    }
}

static void UpdateUserMenu()
{
    int option = 0;

    while (option != 4)
    {
       // Console.Clear();
        Console.WriteLine(" ACTUALIZAR USUARIO ");
        Console.WriteLine("1. Editar nombre");
        Console.WriteLine("2. Editar contacto");
        Console.WriteLine("3. Activar / Desactivar usuario");
        Console.WriteLine("4. Volver");

        Console.Write("Seleccione una opción: ");

        int.TryParse(Console.ReadLine(), out option);

        switch (option)
        {
            case 1:
                EditUserName();
                break;

            case 2:
                EditUserContact();
                break;

            case 3:
                ToggleUserActiveStatus();
                break;

            case 4:
                break;

            default:
                Console.WriteLine("Opción inválida");
              //  Console.ReadKey();
                break;
        }
    }
}
static void RegisterUser()
{
    Console.WriteLine("Función: Registrar usuario");
   // Console.ReadKey();
}

static void ListUsers()
{
    Console.WriteLine("Función: Listar usuarios");
   // Console.ReadKey();
}

static void ViewUserDetail()
{
    Console.WriteLine("Función: Ver detalle del usuario por ID/documento");
    // Console.ReadKey();
}

static void EditUserName()
{
    Console.WriteLine("Función: Editar nombre del usuario");
   // Console.ReadKey();
}

static void EditUserContact()
{
    Console.WriteLine("Función: Editar contacto del usuario");
   // Console.ReadKey();
}

static void ToggleUserActiveStatus()
{
    Console.WriteLine("Función: Activar o desactivar usuario");
    //Console.ReadKey();
}

static void DeleteUser()
{
    Console.WriteLine("Validar no permitir eliminar si tiene préstamos activos");
    //Console.ReadKey();
}
}