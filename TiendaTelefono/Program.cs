namespace TiendaTelefono
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos instancias de 2 objetos para que se muestre la informacion de los almacenados , realizamos nuestro programa para que ingrese
            //los datos que desee almacenar  el cliente, estas instancias solo son ejemplos

            TelefonoBasico telefonoBasico = new TelefonoBasico("Blackberry", "m23", 14, 3);
            TelefonoInteligente telefonoInteligente = new TelefonoInteligente("Samsung", "A03", 456, 3, "Android", 64);

            //mandamos a llamar los metodos correspondientes
            telefonoBasico.MostrarInformacionBasico();
            telefonoInteligente.MostrarInformacionInteligente();

            Console.WriteLine();
            //mandamos a llamar de nuestro proyecto de TiendaTelefono la clase Telefono en donde se encuentra nuestro metodo MostrarMenu();
            //ya que no queremos sobrecargar nuestro menu entonces solo cmandamos a llamar
            TiendaTelefono.Telefono.MostrarMenu();

            //Con este metodo le decimos al usuario que ingrese todos los telefonos que desea agregar 
           
        }
    }
}
