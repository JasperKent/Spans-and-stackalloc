//int[] a1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//Span<int> a2 = a1.AsSpan(2,4);

//a2[0] = 500;

//foreach (var i in a1) Console.WriteLine(i);

//Console.WriteLine();          

//foreach (var i in a2) Console.WriteLine(i);

//ReadOnlySpan<char> strSpan = "Hello World";

//foreach (var i in strSpan) Console.WriteLine(i);

//List<int> il = new List<int>() { 1,2,3 };


//Span<int> a1 = stackalloc int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//foreach (var i in a1) Console.WriteLine(i);

//using Spans;

//var p = Point3D.Parse("(1.1, 2.2, 3.3)");

//Console.WriteLine(p);

using BenchmarkDotNet.Running;
using Spans;

BenchmarkRunner.Run<Benchmarks>();