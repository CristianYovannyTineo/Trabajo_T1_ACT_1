// See https://aka.ms/new-console-template for more information

//La empresa APCI ha evaluado el ingreso de 3 salarios importantes y desea calcular:
//a.Suma de los tres salarios
//b. Promedio de los tres salarios
//c.Porcentaje de cada salario con respecto a la suma.
//d. La media ponderada(MP) asignándole un peso(Pi) a cada salario:
//MP = (P1 x Salario1 + P2 x Salario2 + P3 x Salario3) / (P1 + P2 + P3)e.La media geométrica 
//(MG):MG = (Salario1 x Salario2 x Salario3) (1 / 3)

//Salarios:
double salario1, salario2, salario3;
//Pesos:
double P1, P2, P3;
//Calculo:
double suma, promedio, porcentaje1, porcentaje2, porcentaje3;
//Calculo de media:
double mediaPonderada, mediaGeometrica, mediaArmonica, adicionInversos;
//Ingrese los salarios:
Console.WriteLine("Ingrese el Primer salario: ");
salario1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el Segundo salario: ");
salario2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el Tercer salario: ");
salario3 = double.Parse(Console.ReadLine());
// Ingrese los pesos (P1, P2 y P3):
Console.WriteLine("Ingrese el peso del Primer salario ");
P1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el peso del Segundo salario ");
P2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el peso del Tercer salario ");
P3 = double.Parse(Console.ReadLine());
//Suma de los salarios:
suma = salario1 + salario2 + salario3;
Console.WriteLine("La Suma de los Salarios es: " + suma);
//Promedio de los tres salarios:
promedio = suma / 3;
Console.WriteLine("El Promedio de los salarios es: " + promedio);
//Porcentaje de cada salario:
porcentaje1 = (salario1 / suma) * 100;
porcentaje2 = (salario2 / suma) * 100;
porcentaje3 = (salario3 / suma) * 100;
Console.WriteLine("El Porcentaje del Primer Salario es: " + porcentaje1 + "%");
Console.WriteLine("El Porcentaje del Segundo Salario es: " + porcentaje2 + "%");
Console.WriteLine("El Porcentaje del Tercer Salario es: " + porcentaje3 + "%");
//La media ponderada:
mediaPonderada = (P1 * salario1 + P2 * salario2 + P3 * salario3) / (P1 + P2 + P3);
Console.WriteLine("La Media ponderada de los salario es: " + mediaPonderada);
//La media geométrica:
mediaGeometrica = Math.Pow(salario1 * salario2 * salario3, 1.0 / 3.0);
Console.WriteLine("La Media geometrica de los salarios es: " + mediaGeometrica);
//La media armónica:
adicionInversos = 1.0 / salario1 + 1.0 / salario2 + 1.0 / salario3;
mediaArmonica = 3.0 / adicionInversos;
Console.WriteLine("La Media armónica de los salarios es: " + mediaArmonica);