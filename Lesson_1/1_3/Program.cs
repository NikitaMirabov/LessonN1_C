// Программа запрашивает целое число X, а на выходе дает все цедые числа в промежутке от -X до X

string s = Console.ReadLine()!;
int x = int.Parse(s);
int y = -x;

while (y <= x)
{
    Console.Write(y);
    Console.Write("; ");
    y++;
}