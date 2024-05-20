using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaTelefono
{
    public class Telefono
    {
       // comenzamos agregar arreglos para poder almacenar los telefonos y establecemos el tamaño del mismo
        static Telefono[] inventario = new Telefono[10]; // Arreglo para almacenar los teléfonos registrados
        //inicializamos nuestro contador de telefonos que es el cual ira contabilizando , en 0
        static int contadorTelefonos = 0;
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo : {Modelo}, Precio : ${Precio}, Stock: {Stock}");
        }

        //Creamos un menu el cual tenga 4 opciones , registar, Mostrar telefonos registrados , consultar el stock del telefono registrado
        public static void MostrarMenu()
        {
            while (true)
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Registrar Teléfono");
                Console.WriteLine("2. Mostrar Teléfonos Registrados");
                Console.WriteLine("3. Consultar Stock de un Teléfono Específico");
                Console.WriteLine("0. Salir");

                Console.Write("Seleccione una opción: ");
                Console.WriteLine();

                string opcion = Console.ReadLine();
                //utilizamos un switch case para cada opcion en el cual mandamos a llamar metodos para no sobrecargar mucho 

                switch (opcion)
                {
                    case "1":
                        RegistrarTelefono();
                        break;
                    case "2":
                        MostrarTelefonosRegistrados();
                        break;
                    case "3":
                        ConsultarStockTelefono();
                        break;
                    case "0":
                        Console.WriteLine("Estas saliendo del programa");
                        return;
                    default:
                        Console.WriteLine("La opcion ingresada no es valida por favor ingresa una correcta ");
                        break;
                }
            }
        }

        //Creamos un metodo en donde se registraran nuestros y telefonos
        static void MostrarTelefonosRegistrados()
        {
            Console.WriteLine();
            Console.WriteLine("Teléfonos Registrados:");
            //Utilizamos un bucle for para recorrer el arreglo inventario desde el índice 0 hasta el valor de contadorTelefonos.
            //Esto asegura que solo se muestren los teléfonos que han sido registrados y no posiciones vacías en el arreglo.
            for (int i = 0; i < contadorTelefonos; i++)
            {
                //Para cada teléfono registrado en el inventario,
                //llama al método MostrarInformacion() de la clase Telefono para mostrar los detalles de ese teléfono en la consola.
                inventario[i].MostrarInformacion();
            }
            Console.WriteLine();
        }

        static void ConsultarStockTelefono()
        {
            Console.WriteLine();
            Console.Write("Ingrese el modelo del teléfono a consultar: ");
            string modelo = Console.ReadLine();

            //Utilizamos un bucle foreach para recorrer el arreglo inventario y buscar un teléfono que coincida con el modelo ingresado por el usuario.
            //Si se encuentra un teléfono con el modelo especificado, se asigna a la variable telefonoConsultado.
            Telefono telefonoConsultado = null;
            foreach (Telefono telefono in inventario)
            {
                if (telefono != null && telefono.Modelo == modelo)
                {
                    telefonoConsultado = telefono;
                    break;
                }
            }
            // Si se encuentra un teléfono con el modelo ingresado,
            // se muestra en la consola la cantidad de unidades en stock de ese teléfono específico.
            if (telefonoConsultado != null)
            {
                Console.WriteLine($"El modelo:  {modelo}, tiene : {telefonoConsultado.Stock} unidades en stock.");
            }
            else
            {
                //Si no se encuentra un teléfono con el modelo ingresado,
                //se muestra un mensaje indicando que ese modelo no se encuentra en el inventario.
                Console.WriteLine($"El modelo :{modelo}, no se encuentra en el inventario.");
            }
            Console.WriteLine();
    }
        static void RegistrarTelefono()
        {
            //Comprobamos si hay espacio disponible en el arreglo inventario para registrar un nuevo teléfono , si no hay espacio debe de tirarnos un mensaje de que no hay espacio .
            //es decir si el contador de teléfonos registrados es menor que la longitud del arreglo, se permite registrar un nuevo teléfono.
            if (contadorTelefonos < inventario.Length)
            {
                //Solicitamos al usuario que seleccione el tipo de teléfono que desea registrar: básico o inteligente.
                Console.WriteLine();
                Console.WriteLine("Seleccione el tipo de teléfono a registrar:");
                Console.WriteLine();
                Console.WriteLine("1. Teléfono Básico");
                Console.WriteLine("2. Teléfono Inteligente");
                Console.WriteLine();
                Console.Write("Opción: ");
                string opcionTipoTelefono = Console.ReadLine();

                if (opcionTipoTelefono == "1")
                {
                    Console.Write("Ingrese la marca del teléfono básico: ");
                    string marca = Console.ReadLine();
                    Console.Write("Ingrese el modelo del teléfono básico: ");
                    string modelo = Console.ReadLine();
                    Console.Write("Ingrese el precio del teléfono básico: ");
                    decimal precio = decimal.Parse(Console.ReadLine());
                    Console.Write("Ingrese el stock del teléfono básico: ");
                    int stock = int.Parse(Console.ReadLine());
                    //true significa si y false no 
                    Console.WriteLine("Tiene lintera?(Si/No): ");
                    //Este método compara la cadena ingresada por el usuario con la cadena "Si" . StringComparison.OrdinalIgnoreCase
                    //indica que la comparación se realizará sin importar si las letras son mayúsculas o minúsculas.
                    //El resultado de la comparación se asigna a la variable tieneLinterna
                    //que será true si la entrada del usuario es "Si" (sin importar que sea mayuscula o minuscula) y false en caso contrario.
                    bool tieneLinterna = Console.ReadLine().Equals("Si", StringComparison.OrdinalIgnoreCase);
                    Console.WriteLine("Tiene radio Fm? (Si/No)");
                    bool tieneRadio = Console.ReadLine().Equals("Sí", StringComparison.OrdinalIgnoreCase);

                    //Se crea una instancia de TelefonoBasico con los datos ingresados y se agrega al arreglo inventario.
                    //Luego, se incrementa el contador de teléfonos registrados y se muestra un mensaje de éxito.
                    inventario[contadorTelefonos] = new TelefonoBasico(marca, modelo, precio, stock, tieneRadio, tieneLinterna);
                    contadorTelefonos++;
                    Console.WriteLine("Teléfono básico registrado con éxito.");
                }
                else if (opcionTipoTelefono == "2")
                {
                    Console.Write("Ingrese la marca del teléfono inteligente: ");
                    string marca = Console.ReadLine();
                    Console.Write("Ingrese el modelo del teléfono inteligente: ");
                    string modelo = Console.ReadLine();
                    Console.Write("Ingrese el precio del teléfono inteligente: ");
                    decimal precio = decimal.Parse(Console.ReadLine());
                    Console.Write("Ingrese el stock del teléfono inteligente: ");
                    int stock = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el sistema operativo del telefono Inteligente : ");
                    string sistemaOperativo = Console.ReadLine();
                    Console.Write("Ingrese memoria Ram :");
                    int memoriaRam = int.Parse(Console.ReadLine());

                    //Se crea una instancia de TelefonoBasico con los datos ingresados y se agrega al arreglo inventario.
                    //Luego, se incrementa el contador de teléfonos registrados y se muestra un mensaje de éxito.
                    inventario[contadorTelefonos] = new TelefonoInteligente(marca, modelo, precio, stock, sistemaOperativo, memoriaRam);
                    contadorTelefonos++;
                    Console.WriteLine("Teléfono inteligente registrado con éxito.");
                }
                else
                {
                    Console.WriteLine("Opción inválida. Por favor, seleccione otra opcion.");
                }
            }
            else
            {
                Console.WriteLine("El inventario está lleno. No es posible registrar más teléfonos.");
            }

            Console.WriteLine();
        }
    }
}


