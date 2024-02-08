using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    internal class Carro : IGuiaInventario
    {
        // Atributos
        private string marca;
        private string modelo;
        private int año;

        // Constructor
        public Carro(string marca, string modelo, int año)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
        }

        // Método de la interfaz
        public void Info()
        {
            Console.WriteLine($"Carro - Marca: {marca}, Modelo: {modelo}, Año: {año}");
        }
    }


}

