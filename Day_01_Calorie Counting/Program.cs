// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


Do("1000,2000,3000,,4000,,5000,6000,,7000,8000,9000,,10000");

void Do(string entrada)
{
    //string entry = "";
    int max = 0;
    int actual = 0;

    foreach (var entry in entrada.Split(new[] { ',','\n'}))
    {
        if (entry != "")
        {
            actual += int.Parse(entry.Trim());
            if (actual > max)
            {
                max = actual;
            }
        }
        else
        {
            actual = 0;
        }

    }

    Console.WriteLine($"La sumatoria del reno con mayor calorias es: {max}");  
}




