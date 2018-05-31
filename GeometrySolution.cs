using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry {
	class Program {
		static void Main(string[] args) {
			Square theSquare = new Square {
				LengthOfSides = 3.3
			};
			theSquare.Print();

			Rectangle theRectangle = new Rectangle {
				Height = 1.2,
				Width = 8.2
			};
			theRectangle.Print();

			Circle theCircle = new Circle {
				Radius = 3.1
			};
			theCircle.Print();

			Sphere theSphere = new Sphere {
				Radius = 3.2
			};
			theSphere.Print();

			Trapezoid theTrapezoid = new Trapezoid {
				FirstBase = 1.2,
				SecondBase = 2.3,
				Height = 3.4,
				FirstSide = 4.5,
				SecondSide = 5.6
			};
			theTrapezoid.Print();

			//for (var i = 0; i < 100; i++) {
			//	int[] array = { 1, 2, 3 };
			//	var rand = new Random();
			//	int picked = rand.Next(0, 2);
			//	int prize = rand.Next(0, 2);
			//	int show = rand.Next(0, 2);
			//	if (show == prize || show == picked) {
			//		show = rand.Next(0, 2);
			//	}
			//	if ()
			//	Console.WriteLine();
			}
		}
	}
}
