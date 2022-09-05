//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] EnterArrayElements(int rows, int cols) 
{   
    int[,] NewArray = new int[rows, cols];
    
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)   
        {
            NewArray[i, j] = new Random().Next(0, 10);
        }            
    }       
    return NewArray;
}

void ShowArrayElements(int[,] thisArray) 
{  
    for(int i = 0; i < thisArray.GetLength(0) ; i++)
    {
        Console.Write("[");
        for(int j = 0; j < thisArray.GetLength(1) ; j++) 
        {
            Console.Write(thisArray[i, j]);
            if(j < thisArray.GetLength(1) - 1)
                Console.Write("; ");
            else
                Console.WriteLine("] ");                
        }        
            
    }

}

void SortArray(int[,] thisArray) 
{      
    for(int i = 0; i < thisArray.GetLength(0) ; i++)  
    {
        for(int j = 0; j < thisArray.GetLength(1) - 1 ; j++)
        {
            int minPosition = j;
            for (int k = j + 1; k < thisArray.GetLength(1); k++)
            {
                if (thisArray[i,k] < thisArray[i,minPosition])
                    minPosition = k;
            }

            int tmp = thisArray[i,j];
            thisArray[i,j] = thisArray[i,minPosition];
            thisArray[i,minPosition] = tmp;
        }                
    }
}

int r = 4;
int c = 3;
int[,] MyArray = EnterArrayElements(r, c);
Console.WriteLine("Array was created :-) ");

ShowArrayElements(MyArray);

SortArray(MyArray);

ShowArrayElements(MyArray);
