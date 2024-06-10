// See https://aka.ms/new-console-template for more information

Console.WriteLine("Bienvenido, por favor ingrese las calificaciones de los estudiantes:");
List<double> estudiantes = new List<double>();

double usuario;
usuario = Convert.ToDouble(Console.ReadLine());

while (usuario != 0)
{
    if (usuario > 0)
    {
        estudiantes.Add(usuario);
    }
    Console.WriteLine("escribe 0 cuando ya no quieras agregar estudiantes");
    usuario = Convert.ToDouble(Console.ReadLine());

}

double calificacionMasAlta = estudiantes.Max();
double menorCalificacion = estudiantes.Min();
double Promedio = estudiantes.Sum() / estudiantes.Count();

Console.WriteLine("la calificacion mas alta es: " + calificacionMasAlta);
Console.WriteLine("la calificacion mas baja es: " + menorCalificacion);
Console.WriteLine("el promedio de todos los estudiantes es: " + Promedio);
