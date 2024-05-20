using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaTelefono
{
    public class TelefonoInteligente : Telefono
    {
        public string SistemaOperativo { get; set; }    

        public int MemoriaRam {  get; set; }

        public TelefonoInteligente(string marca, string modelo, decimal precio, int stock, string sistemaOperativo, int memoriaRam)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Precio = precio;
            this.Stock = stock;
            this.SistemaOperativo = sistemaOperativo;
            this.MemoriaRam = memoriaRam;

        }
        public void MostrarInformacionInteligente()
        {

            MostrarInformacion();
            Console.WriteLine($"Sistema Operativo : {SistemaOperativo}, Memoria Ram : {MemoriaRam} GB");
        }


    }
}
