namespace AssignmentOOP6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project
            Duration D1 = new Duration(11, 36, 58);
            //Console.WriteLine(D1);

            //D1 = new Duration(7800);
            //Console.WriteLine(D1);

            //D1 = new Duration(666);
            //Console.WriteLine(D1);


            //Implement All required Operators overloading to enable this Code:
            Duration D2 = new Duration(11, 35, 22);

            //Duration D3 = D1 + D2;
            //Console.WriteLine(D3);

            //D3 = D1 + 7800;
            //Console.WriteLine(D3);

            //D3 = 666 + D3;
            //Console.WriteLine(D3);

            //D3 = ++D1;
            //Console.WriteLine(D3);

            //D3 = --D1;
            //Console.WriteLine(D3);

            //D1 = D1 - D2;
            //Console.WriteLine(D1);

            //if (D1 > D2)
            //{
            //    Console.WriteLine("D1 is Greater than D2");
            //}
            //else
            //{
            //    Console.WriteLine("D1 is Less than D2");
            //}

            //if (D1 <= D2)
            //{

            //    Console.WriteLine("D1 is Less than or Equal D2");
            //}
            //else
            //    Console.WriteLine("D1 is Not Less than or Equal D2");



            //if (D1)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("Not Exist");

            DateTime Obj = (DateTime)D1;
            Console.WriteLine(Obj);
                #endregion



            }
    }
}
