using Laboratorio1YeisonMauricioÁlvarez.Entidades;
using Laboratorio1YeisonMauricioÁlvarez.Negocio;

Persona persona= new Persona();
ClsPersona clsPersona= new ClsPersona();

Console.WriteLine("Ingrese Su Nombre");
persona.Nombre = Console.ReadLine();

Console.WriteLine("Ingrese Su Edad");
persona.Edad= int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su Sexo");
persona.Sexo = Console.ReadLine();

Console.WriteLine("Ingrese su Peso");
persona.Peso= double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese su Altura");
persona.Altura = double.Parse(Console.ReadLine());

clsPersona.calcularIMC(persona);
clsPersona.esMayorDeEdad(persona);
