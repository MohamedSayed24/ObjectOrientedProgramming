using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingC_
{
    public class Point3D : IComparable , ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        
        public Point3D()
        {
            
        }
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;

        }




        ////////////public Point3D[] InsertPoints(Point3D[] points)
        ////////////{
        ////////////    int x, y, z;
        ////////////    for (int i = 0; i < points.Length; i++)
        ////////////    {
                
        ////////////        Console.WriteLine($"Enter The Coordinates Of Point{i+1} (x , y ,z)");
        ////////////        bool isValid = int.TryParse(Console.ReadLine(), out x);
        ////////////        bool isValid1 = int.TryParse(Console.ReadLine(), out y);
        ////////////        bool isValid2 = int.TryParse(Console.ReadLine(), out z);
        ////////////        points[i] = new Point3D();

        ////////////    }
        ////////////    return points;


        ////////////}
        
        public override string ToString()
        {
            return $"X: {X}, Y: {Y}, Z: {Z}";
        }

        public int CompareTo(object? obj)
        {
           Point3D point = (Point3D)obj;

            if (X > point.X)
                return 1;
            else if (Y > point.Y) return 1;
            else if (X < point.X)
                return -1;
            else if (Y < point.Y) return -1;
            else
                return 0;



        }

        public object Clone()
        {
            return new Point3D
            {
                X=this.X,
                Y = this.Y,
                Z = this.Z
            };
        }
    }
}
