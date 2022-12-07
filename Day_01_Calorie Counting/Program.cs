using System.Diagnostics;

Stopwatch sw = Stopwatch.StartNew();


string data = File.ReadAllText("Input\\input_day_1.txt");
//Do("1000\n2000\n3000\n\n4000\n\n5000\n6000\n\n7000\n8000\n9000\n\n10000");
Do(data.Replace("\r",""));

sw.Stop();

Console.WriteLine($"Time in Milliseconds: {sw.ElapsedMilliseconds}");

Console.ReadKey();
void Do(string entrada)
{
    int actual = 0;
    var xdata = entrada.Split('\n')
        .ToList()
        .Select((v, i) => new { Value = v, Index = i });

    List<int> maxList = new();

    int count  = xdata.Count();

    foreach (var entry in xdata)
    {
        if (entry.Value != "")
        {
            actual += int.Parse(entry.Value.Trim());
        }

        if(entry.Index + 1 == count || entry.Value == "")
        { 
            maxList.Add(actual);
            actual = 0;
        }
    }

    var top3 = maxList
        .OrderByDescending(p => p)
        .Take(3)
        .ToList();

    Console.WriteLine($"La sumatoria del reno con mayor calorías es: {top3[0]}");
    Console.WriteLine($"La sumatoria de los tres renos con mayor calorías es es: {top3.Sum()}");
}