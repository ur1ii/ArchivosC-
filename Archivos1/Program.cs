// Almacenar 10 registros de estudiantes: nombre, carrera y promedio
estudiante[] estudiante = new estudiante[10];

int menu()
{
    Console.WriteLine("=== MENU ===");
    Console.WriteLine("1. Agregar");
    Console.WriteLine("2. Mostrar");
    Console.WriteLine("3. Guardar");
    Console.WriteLine("4. Salir");
    Console.WriteLine("Ingresa tu opcion: ");
    return int.Parse(Console.ReadLine()!);

}

void pedirdatos()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("=== Ingresa los datos ===");
        Console.WriteLine("Nombre: ");
        estudiante[i].nombre = Console.ReadLine()!;
        Console.WriteLine("Carrera: ");
        estudiante[i].carrera = (Console.ReadLine()!);
        Console.WriteLine("Promedio: ");
        estudiante[i].promedio = double.Parse(Console.ReadLine()!);
       
    }

}
void mostrardatos()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"{estudiante[i].nombre} | {estudiante[i].carrera} | {estudiante[i].promedio}");
    }
}

void guardarachivos()
{
    StreamWriter archivo = new StreamWriter("C:\\Archivos_R");
    for (int i = 0; i < 10; i++)
    {
        archivo.WriteLine(estudiante[i].nombre + ";" + estudiante[i].carrera + ";" + estudiante[i].promedio);
    }
    archivo.Close();
    Console.WriteLine("Registro guardado...");
}
   
void main()
    {
       int op;
        do
        {
            op = menu();
            switch (op)
            {
                case 1:
                    pedirdatos();
                    break;
                case 2:
                    mostrardatos();
                    break;
                case 3:
                    guardarachivos();
                    break;
                case 4:
                    Console.WriteLine("Adios...");
                    break;
                default:
                    Console.WriteLine("Opcion Invalida");
                    break;
            }

        } while (op != 3);

    }
    main();


struct estudiante
{
    public string nombre, carrera;
    public double promedio;
}