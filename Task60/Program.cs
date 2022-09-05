//Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] EnterArrayElements(int rows, int cols, int lines) 
{   
    int[,,] NewArray = new int[rows, cols, lines];

    var ListOfUnicNumbers = new List<int>();

    int SomeNumber = 0;
    
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)   
        {
            for(int k = 0; k < lines; k++)
            {
                SomeNumber = new Random().Next(10, 100);
                Console.WriteLine("created number - " + SomeNumber);
                while(ListOfUnicNumbers.Contains(SomeNumber))
                {
                    Console.WriteLine("found a duplicate element - " + SomeNumber);
                    SomeNumber = new Random().Next(10, 100);
                    Console.WriteLine("created number - " + SomeNumber);
                }                     
                
                ListOfUnicNumbers.Add(SomeNumber);
                
                NewArray[i, j, k] = SomeNumber;
            }            
        }            
    }       
    return NewArray;
}

void ShowArrayElementsByRows(int[,,] thisArray) 
{     
    for(int i = 0; i < thisArray.GetLength(0) ; i++)
    {
        for(int j = 0; j < thisArray.GetLength(1) ; j++) 
        {
            for(int k = 0; k < thisArray.GetLength(2) ; k++) 
                Console.Write($"{thisArray[i, j, k]} ({i}, {j}, {k}) ");
            Console.WriteLine(" ");                     
        }              
    }
    
}

int r = 2;
int c = 2;
int l = 2;
int[,,] MyMatrix1 = EnterArrayElements(r, c, l);

Console.WriteLine("Matrix1 was created :-) ");
ShowArrayElementsByRows(MyMatrix1);

