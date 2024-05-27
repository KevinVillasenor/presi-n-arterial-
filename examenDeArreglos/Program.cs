//declaracion de variables 
int baja = 0;
int normal = 0;
int elevada = 0;
int con = 0;
int[] array = new int[30];

//llamando la funcion random
Random random = new Random();

//llenando el arreglo 
for(con = 0; con < 30; con++)
{
    array[con] = random.Next(100,150);
}

//clasificando la precion en : baja, normal y elevada 
for (con = 0; con < 30; con++)
{
    if (array[con] < 120)
    {
        baja++;
    }
    if (array[con] >= 120 && array[con] <= 129)
    {
        normal++;
    }
    if (array[con] >= 130)
    {
        elevada++;
    }
}

//mostrando los resultados de la precion
Console.WriteLine("baja: " + baja);
Console.WriteLine("normal: " + normal);
Console.WriteLine("elevada: " + elevada);


// mostrando el estado de precion del paciente 
if (baja > normal)
{
    if (baja > elevada)
    {
        Console.WriteLine("el paciente padece de precion baja");
    }
    else
    {
        Console.WriteLine("el paciente padece de precion elevada");
    }
} else if (normal > elevada)
{
    Console.WriteLine("el paciente padece de precion normal");
}
else
{
    Console.WriteLine("el paciente padece de precion elevada"); 
}

