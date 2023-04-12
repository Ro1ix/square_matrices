Console.WriteLine("Ввдедите размер квадратных матриц");
int N = Convert.ToInt32(Console.ReadLine());
string size = "";
for (int i = 1; i < N; i++)
{
    size = size + ",";
}
Console.WriteLine(size);