/*Static Import (Using Directives in C#)

C# does not support static imports like Java but provides a similar feature with the using
static directive. This allows direct access to static members of a class.
*/


using System;
using static System.Math; // Static import

class Program {
	static void Main(string[] args) {
	double result = Sqrt(25); // No need to use Math.Sqrt()
	Console.WriteLine(result); // Output: 5
}
}