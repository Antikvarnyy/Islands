Islands islands = new();
islands.Print();
Console.WriteLine();
Console.WriteLine(islands.Count());
class Islands
{
    int[,] isl = new[,] { { 1, 0, 0, 0, 1 }, { 0, 0, 1, 1, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 1, 1, 0 }, { 0, 1, 0, 0, 1 } };
    int k;
    //1 0 0 0 1
    //0 0 1 1 0
    //0 0 1 0 0
    //0 0 1 1 0
    //0 1 0 0 1
    public void Print()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(isl[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    public int Count()
    {
        k = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (isl[i, j] != 0)
                {
                    if (i == 0 && j == 0)
                        k++;
                    if (i == 0 && j != 0)
                    {
                        if (isl[i, j - 1] == 0)
                            k++;
                    }
                    if (j == 0 && i != 0)
                    {
                        if (isl[i - 1, j] == 0)
                            k++;
                    }
                    if (j != 0 && i != 0)
                    {
                        if (isl[i - 1, j] == 0 && isl[i, j - 1] == 0)
                            k++;
                    }
                }
            }
        }
        return k;
    }
}