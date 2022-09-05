//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MultiplicationMatrix(int[,] FirstMatrix, int[,] SecondMatrix, int[,] ThirdMatrix) 
{      
    for (int i = 0; i < ThirdMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < ThirdMatrix.GetLength(1); j++)
            {
                ThirdMatrix[i, j] = 0;
                for (int k = 0; k < FirstMatrix.GetLength(1); k++)
                    ThirdMatrix[i, j] += FirstMatrix[i, k] * SecondMatrix[k, j];
            }
        }
    return ThirdMatrix;    
}

int r = 2;
int c = 2;
int[,] MyMatrix1 = EnterArrayElements(r, c);
Console.WriteLine("Matrix1 was created :-) ");
ShowArrayElements(MyMatrix1);

int[,] MyMatrix2 = EnterArrayElements(r, c);
Console.WriteLine("Matrix2 was created :-) ");
ShowArrayElements(MyMatrix2);

int[,] MyMatrix3 = EnterArrayElements(r, c);
Console.WriteLine("Multiplication : ");
ShowArrayElements(MultiplicationMatrix(MyMatrix1, MyMatrix2, MyMatrix3));