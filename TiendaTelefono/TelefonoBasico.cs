using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaTelefono
{
    public class TelefonoBasico : Telefono
    {
        public bool TieneRadioFM { get; set; }
        public bool TieneLinterna { get; set; }

        public TelefonoBasico( string marca, string modelo , decimal precio, int stock, bool tieneRadio = true , bool tieneLinterna = true )
        { 
          this.Marca = marca;
          this.Modelo = modelo;
          this.Precio = precio;
          this.Stock = stock;
          TieneRadioFM = tieneRadio;
          TieneLinterna=tieneLinterna;
        }

        public void MostrarInformacionBasico()
        {
        //Hacemos un pequeño ajuste para cuando se tiene o no se tiene linterna al igual que con radio fm 
            string tiene = (TieneLinterna) ? "Si" : "No";
            string tiene2 = (TieneRadioFM) ? "Si" : "No";
            MostrarInformacion();
            Console.WriteLine($"Tiene Radio FM : {tiene}, Tiene Linterna : {tiene2}");
        }


    }
}
