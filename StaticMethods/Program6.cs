/*
Static vs Non-static Context
● Static Context: Includes static variables, methods, and constructors. Static members
belong to the type and are shared across all instances. They cannot access
instance-specific members directly.
● Non-static Context: Includes instance variables and methods. Instance methods can
access both static and instance members.
*/

using System;

class Program6 {
	int instanceVar = 10;
	static int staticVar = 20;

	public static void StaticMethod() {
		// Console.WriteLine(instanceVar); // Error: Cannot access instance members
		Console.WriteLine(staticVar); // Valid
	}

	public void InstanceMethod() {
		Console.WriteLine(instanceVar); // Valid
		Console.WriteLine(staticVar); // Valid
	}
	static void Main(string[] args) {
		Program6 prog= new Program6();
		prog.InstanceMethod();
	}
}