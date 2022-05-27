using static System.Console;
Clear();

//1. Crear el carto de bingo de 3 filas y 9 columnas (Matriz[3,9]
int[,] carton = new int[3, 9];

Random num = new Random();


for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 9; j++)
    {
        carton[i, j] = num.Next(1, 90);
    }
}


int aux = 0;
int posMenor = 0;
int pos = 0;
for (int e = 0; e < 9; e++)
{
    for (int i = 0; i < 2; i++)
    {
        posMenor = i;
        pos = i + 1;
        do
        {
            if (carton[posMenor, e] > carton[pos, e])
            {
                posMenor = pos;
            }
            pos++;
        }
        while (pos <= 2);
        if (i != posMenor)
        {
            aux = carton[i, e];
            carton[i, e] = carton[posMenor, e];
            carton[posMenor, e] = aux;
        }
    }
}


for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 9; j++)
    {

        Write($"| {carton[i, j]} ");

    }
    WriteLine();
}





//2. "carton" debe tener 15 numeros y 12 espacios en blanco.
//3. Cada fila debe ter 5 numeros 4 espacios vacios
//4. Cada columna debe tener 1 o 2 numeros.
//5. Ningun numero debe repetirse.
//6. La primer columna contiene los numeros del 1-9
//   La segunda del 10-19
//   La tercera del 20-29
//   La cuarta del 30-39
//   La quinta del 40-49
//   La sexta del 50-59
//   La septima del 60-69
//   La octava del 70-79
//   La novena del 80-90



//7. Mostrar el carton por consola.




