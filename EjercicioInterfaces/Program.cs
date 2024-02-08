
using EjercicioInterfaces;

// Crear objetos de las clases
Carro carro1 = new Carro("Toyota", "Corolla", 2022);
Libro libro1 = new Libro("La historia interminable", "Michael Ende", 481);

// Llamar al método de la interfaz para cada objeto
carro1.Info();
libro1.Info();

