string mensaje = "Hola, cómo te llamás ?"; /*  primer mensaje */

Console.Clear(); /* limpia pantalla */

Console.WriteLine(mensaje); /* pide el nombre */

string nombre = Console.ReadLine(); /* el usuario ingresa su nombre */

Console.WriteLine("Hola " + nombre + " bienvenido a mi mundo."); /* da la bienvenida al usuario*/

Console.WriteLine("Querés cruzar la entrada al laberinto ? Si ó No ?");

Console.WriteLine("(S) para SI , (N) para NO.");

var eleccion = Console.ReadLine();

if (eleccion.ToUpper() == "S")
{
    Console.WriteLine(nombre + " has elegido ingresar al laberinto, bienvenido ...");
    Console.WriteLine("Hola " + nombre + " bienvenido a mi mundo."); /* da la bienvenida al usuario*/
    Console.WriteLine("Querés cruzar la entrada al laberinto ? Si ó No ?");
    Console.WriteLine("(S) para SI , (N) para NO.");
}
else if (eleccion.ToUpper() == "N")
{
    Console.WriteLine(nombre + " no quieres entrar al laberinto, pero ya estás en mi mundo LOL !");
} else {
    Console.WriteLine("Jamás podrás salir de aquí !! salvo que cierres esta ventanita.");
}

   