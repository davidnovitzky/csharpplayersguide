int i1, i2; // Two of everything.
string s1, s2;
int[] a1, a2;

i1 = 2; // Assign a value to the first.
s1 = "Hello";
a1 = new int[] { 1, 2, 4 };

i2 = i1; // Copy to the second.
s2 = s1;
a2 = a1;

i2 = 4; // Make changes.
a2[0] = -1;
a1[0] = 3; // Change the first element of a1.

Console.WriteLine($"{a2[0]} and {a1[0]}");
