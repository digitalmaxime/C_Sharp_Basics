int[,] Array2d = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

System.Console.WriteLine(Array2d[1, 2]);


int[,,] Array3d = new int[2, 2, 3] {
    {
        {0, 1, 2}, {3, 4, 5}
    },
    {
        {6, 7, 8}, {9, 10, 11}
    }
};

System.Console.WriteLine(Array3d[1, 1, 2]);

int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[2] { 1, 2 };
jaggedArray[1] = new int[3] { 3, 4, 5 };
jaggedArray[2] = new int[4] { 6, 7, 8, 9 };

System.Console.WriteLine(jaggedArray[0][0]);
System.Console.WriteLine(jaggedArray[1][2]);
System.Console.WriteLine(jaggedArray[2][3]);
