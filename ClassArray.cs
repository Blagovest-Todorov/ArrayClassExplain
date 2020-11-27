using System;

namespace _08.ArrayClass
{
    class ClassArray
    {
        static void Main(string[] args)
        {
            /// System.Array  class is-> Parrent of all Arrays
            //all Arays inherit from it, 
            //All Arrays have the same : basic functionality and basic property ;
            //e. g Length property 

           // int[,] numbers = new int[3, 4];
           // Console.WriteLine(numbers.Rank); //shows how many dimensions the array has//two dimensional Array
                         //Number of //Rows,Cols,Depths,  
            int[ , ,] numbers3D = new int[3, 5, 2];//three dimensional Array [key index 0,1,2]->[3-rows,5cols,2 in Depth]
            Console.WriteLine(numbers3D.Rank); // ->Rank->number of Dimensions 3->3Dimensional Array,Dimension by rows, by. cols, by depth
            //Length --the number of the cells, the number of the elements , the size of the array;
            Console.WriteLine(numbers3D.Length);  //We have  150 cells, Lenght shows the number of teh cells
            //GetLength -> it returns the number of,cells in given dimension: rows, or the number of cols, or the number of Depth
            //Console.WriteLine(numbers3D.GetLength(0)); // key Index ->0,1,2 --this is index number,
            //it shows: if 0-> number of rows
            //if index 1 - > it shows the number of cols, if 
            //Console.WriteLine(numbers3D.GetLength(1)); - > 5 columns /
            Console.WriteLine(numbers3D.GetLength(2)); // -> , 2 in Depth;
            // getLength() it returns how many cells we have on given Dimension, ie, Dimension Rows or  Dimension Cols, 
            //or dimension Depth;//cells by row, cells by column, cells by Depth; cells pro given Dimension;
            //how many cells we have by dimension rows ->  we have three rows, 
            //how many colums we have on dimension columns- > 3 in our case, 
            // how many cells we have in Dimension Depth - >  2 in our case;

        } 

    }
}
