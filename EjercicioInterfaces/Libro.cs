using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    internal class Libro : IGuiaInventario
    {
        // Atributos
        private string titulo;
        private string autor;
        private int paginas;

        // Constructor
        public Libro(string titulo, string autor, int paginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.paginas = paginas;
        }

        // Método de la interfaz
        public void Info()
        {
            Console.WriteLine($"Libro - Título: {titulo}, Autor: {autor}, Páginas: {paginas}");
        }
    }
}

