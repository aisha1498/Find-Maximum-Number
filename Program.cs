using Find_Maximum_Numbers;

Console.WriteLine("Find the Maximum Number : ");
int output = MaximumNumbercheck.MaximumNumber(25, 15, 13);
Console.WriteLine(output);

double doubleoutput = MaximumNumbercheck.MaximumFloatNumber(52.26, 18.92, 15.12);
Console.WriteLine(doubleoutput);

string strigoutput = MaximumNumbercheck.MaximumStringNumber("linklist", "shellscript", "visualstudio");
Console.WriteLine(strigoutput);

int[] intArray = { 102, 152, 165, 205, 209, 215 };
GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
generic.PrintMaxValue();
double[] doubleArray = { 2.63, 25.36, 52.09, 12.32, 46.15 };
GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
genericDouble.PrintMaxValue();
string[] stringArray = { "maharashtra", "goa", "beach", "agra", "ooti" };
GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
genericString.PrintMaxValue();
Console.ReadKey();