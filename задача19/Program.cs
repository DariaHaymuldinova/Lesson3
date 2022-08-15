// Программа: определят является ли пятизначное число палиндромом

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
string numberString = number.ToString();
int[] array = new int[5];
array[0] = numberString[0];
array[1] = numberString[1];
array[2] = numberString[2];
array[3] = numberString[3];
array[4] = numberString[4];
if (array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine ("Это не палиндром");
}


