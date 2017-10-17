using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionBetweenTwoPlanes3D
{
    class Program
    {
        class Point
        {
            public double x;
            public double y;
            public double z;

            public Point(double x, double y, double z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
        }

        class Vector
        {
            public Point koord;
            public Vector(Point koord)
            {
                this.koord = koord;
            }

            public static bool isParalel(Vector normal1, Vector normal2)
            {
                if (normal2.koord.x / normal1.koord.x == normal2.koord.y / normal1.koord.y &&
                    normal2.koord.x / normal1.koord.x == normal2.koord.z / normal1.koord.z)
                    return true;
                return false;
            }

            public static bool isCoincide(Vector normal1, Point pPoint, Point checkPoint, 
                                               Vector normal2, Point pPoint2, Point checkPoint2)
            {
                double uravnenie1 = normal1.koord.x * (checkPoint.x - pPoint.x) + 
                             normal1.koord.y * (checkPoint.y - pPoint.y) + 
                             normal1.koord.z * (checkPoint.z - pPoint.z);

                double uravnenie2 = normal2.koord.x * (checkPoint2.x - pPoint2.x) +
                             normal2.koord.y * (checkPoint2.y - pPoint2.y) +
                             normal2.koord.z * (checkPoint2.z - pPoint2.z);
                if (uravnenie1 == 0 && uravnenie2 == 0)
                    return true;
                else return false;
            }

            public static Vector Normalize(Vector vector)
            {
                double V = Math.Sqrt(vector.koord.x * vector.koord.x + vector.koord.y * vector.koord.y + vector.koord.z * vector.koord.z);
                return new Vector(new Point(vector.koord.x / V, vector.koord.y / V, vector.koord.z/V));
            }
        }

        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            input = input.Replace('.', ',');
            var numbers = input.Split(' ').Select(x => double.Parse(x)).ToArray();
            
            Vector normal1 = new Vector(new Point(numbers[3], numbers[4], numbers[5]));
            Vector normal2 = new Vector(new Point(numbers[9], numbers[10], numbers[11]));

            Point point1 = new Point(numbers[0], numbers[1], numbers[2]);
            Point point2 = new Point(numbers[6], numbers[7], numbers[8]);

            if (Vector.isParalel(normal1, normal2))
            {
                if (Vector.isCoincide(normal1, point1, point2, normal2, point2, point1))
                {
                    Console.Write(3 + " ");
                    Console.Write(point1.x + " " + point1.y + " " + point1.z + " ");
                    Vector v = Vector.Normalize(normal1);
                    Console.Write(Math.Round(v.koord.x, 9) + " " + Math.Round(v.koord.y, 9) + " " + Math.Round(v.koord.z, 9));

                }
                else Console.Write(0);

            }
          
            Console.ReadKey();
        }
    }
}
