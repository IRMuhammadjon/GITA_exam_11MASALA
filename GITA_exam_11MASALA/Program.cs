
Console.WriteLine("Bo'linuvchini kiriting: ");
var B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bo'luvchini kiriting: ");
var b= Convert.ToInt32(Console.ReadLine());
int count=0;
while (B > 0)
{
    B = B - b;
   count++;
}
if (B != 0)
{
    B = B + b;
    count--;
}
Console.WriteLine("Qoldiq: "+ B);
Console.WriteLine("Butun qismi: "+ count);
