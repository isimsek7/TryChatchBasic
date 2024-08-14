Console.WriteLine("Lutfen bir sayi giriniz");
try
{
    int input = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(input*input);
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
        
}
