using System.ComponentModel;

namespace ObjectOrientedProgrammingC_
{

    public class Maths
    {
     int x; int y;

        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double Divide(double x, double y)
        {
            return x / y;
        }


    }


    internal class Program
    {
        public static Point3D[] InsertPoints(Point3D[] points)
        {
            int x, y, z;
            for (int i = 0; i < points.Length; i++)
            {

                Console.WriteLine($"Enter The Coordinates Of Point{i + 1} (x , y ,z)");
                bool isValid = int.TryParse(Console.ReadLine(), out x);
                bool isValid1 = int.TryParse(Console.ReadLine(), out y);
                bool isValid2 = int.TryParse(Console.ReadLine(), out z);
                points[i] = new Point3D(x,y,z);

            }
            return points;


        }
        static void Main(string[] args)
        {
            #region First Project:

            //int size ;
            //Console.WriteLine("Enter The Number Of Points");
            //bool isValid = int.TryParse(Console.ReadLine(), out size);
            //Point3D[] points = new Point3D[size];

            //InsertPoints(points);

            //for (int i = 0; i < points.Length; i++)
            //{  
            //    Console.WriteLine($"Point{i + 1} : {points[i]}");
            //} 

            ////////////// Another Way To Insert Points ////////////////


            //int x1 ,x2 , y1, y2, z1, z2;
            //Console.WriteLine("Enter The Coordinates Of Point1 (x , y ,z)");
            //bool isValid = int.TryParse(Console.ReadLine(), out x1);
            //bool isValid1 = int.TryParse(Console.ReadLine(), out y1);
            //bool isValid2 = int.TryParse(Console.ReadLine(), out z1);
            //Point3D point1 = new Point3D(x1, y1, z1);
            //Console.WriteLine("Enter The Coordinates Of Point2 (x , y ,z)");
            //bool isValid01 = int.TryParse(Console.ReadLine(), out x2);
            //bool isValid102 = int.TryParse(Console.ReadLine(), out y2);
            //bool isValid203 = int.TryParse(Console.ReadLine(), out z2);

            //Point3D point2 = new Point3D(x2, y2, z2);

            //Console.WriteLine($"point1: {point1}");
            //Console.WriteLine($"point2: {point2}");

            //if(point1 == point2)
            //    Console.WriteLine("Yes it Work");

            // No It Dosn't Work Because it must compare point1.X with point2.X and point1.Y with point2.Y and point1.Z with point2.Z




            //Define an array of points and sort this array based on X & Y coordinates.
            //Point3D[] points =
            //{
            //    new Point3D{ X=8 , Y = 5 , Z=3 },
            //    new Point3D{ X=3 , Y = 8 , Z=1 },
            //};  
            //Array.Sort(points);

            //foreach(Point3D point in points)
            //{
            //    Console.WriteLine(point);
            //}

            #endregion

            #region Seconed Project :

            //double Addition = Maths.Add(10, 20);
            //double Substraction = Maths.Subtract(10, 20);
            //double Multiplition  = Maths.Multiply(10, 20);
            //double Division = Maths.Divide(10, 20);

            //Console.WriteLine($"Addition : {Addition} ,Substraction: {Substraction} ,Multiplition: {Multiplition} , Division : {Division}");
            #endregion

            #region Third Project:

            Duration D1 = new Duration(10, 35, 24);
            Console.WriteLine(D1);

            D1 = new Duration(3600);
            Console.WriteLine(D1);

            D1 = new Duration(666);
            Console.WriteLine(D1);
            #endregion
        }
    }
}
