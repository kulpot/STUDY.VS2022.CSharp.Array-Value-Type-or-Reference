using System;

//ref link:https://www.youtube.com/watch?v=aQ8_RKDGMtw&list=PLRwVmtr-pp07QlmssL4igw1rnrttJXerL&index=8
//

//class MeClass   // reference type
struct MeClass // value type
{
    public int MeField;
}

class MainClass
{
    static void Main()
    {
        int[] meInts = new int[] { 1, 5, 4, 7 };    //value type

        //Console.WriteLine(meInts[2]);

        MeClass[] meClasses = new MeClass[3];   // reference type
        meClasses[1] = new MeClass(); // instanciate new object 
        //meClasses[1].MeField = 5;
        Console.WriteLine(meClasses[1].MeField);
    }
}