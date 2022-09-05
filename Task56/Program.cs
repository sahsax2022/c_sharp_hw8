//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void GetMinRow(int[,] thisArray) 
{      
    int minSumRow = 0;
    int minRow = 0;

    for(int i = 0; i < thisArray.GetLength(0) ; i++)  
    {        
        int sumRow = 0;
        
        for(int j = 0; j < thisArray.GetLength(1); j++)
            sumRow += thisArray[i,j];              

        if(i == 0) 
            minSumRow = sumRow;

        if(sumRow <= minSumRow)
        {
            minRow = i;
            minSumRow = sumRow;               
        }              
    }
    Console.WriteLine("Строка мин суммы - " + (minRow+1));
}

int r = 4;
int c = 4;
int[,] MyArray = EnterArrayElements(r, c);
Console.WriteLine("Array was created :-) ");

ShowArrayElements(MyArray);

GetMinRow(MyArray);
