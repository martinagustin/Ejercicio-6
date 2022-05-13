﻿/*
 1) Generar un número secreto
aleatorio con la siguiente instruccion:

// Genera un numero entero aleatorio de 1 a 20
int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);

2) Pedir al usuario que ingrese un número y que
intente adivinar el número que eligió la computadora.

3) Si el numero ingresado por el usuario es mayor
al número secreto, avisarle que es muy grande y que intente de nuevo y que
vuelva al paso 2.

4) Si el numero ingresado es menor al número
secreto, avisarle que es muy chico, y que intente de nuevo volviendo al paso 2.

5) Si el número ingresado coincide con el número
secreto, sacar el siguiente mensaje:

"Felicitaciones, has adivinado el número
secreto que era:  [numeroSecreto]"
"Lo has logrado en [n] intentos!!"

Y finalizar el programa.
 */
int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);
int numeroIngresado = 0;
int contador = 0;
while (numeroIngresado != numeroSecreto)
{
    Console.WriteLine(" Ingrese un numero");
    numeroIngresado = Convert.ToInt32(Console.ReadLine());
    contador++;
    if (numeroIngresado > numeroSecreto)
    {
        Console.WriteLine("numero ingresado muy grande, intentalo de nuevo");
    }
    else if (numeroIngresado < numeroSecreto)
    {
        Console.WriteLine("numero ingresado muy chico, intentalo de nuevo");
    }
}
Console.WriteLine($"Felicitaciones el numero secreto era: {numeroSecreto}, lo has logrado en {contador} intentos");
