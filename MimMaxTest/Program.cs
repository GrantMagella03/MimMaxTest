internal class Program
{
    private static void Main(string[] args)
    {
        int[] nbrs = {754, 233, 509, 792, 700, 596, 833, 658, 998, 742, 187, 754, 308, 914, 489, 867, 717, 586, 929, 467, 460, 241, 770, 324, 599, 259, 120, 800, 336, 609,690, 134, 598, 249, 282, 574, 334, 956, 659, 214,435, 643, 809, 874, 906, 620, 328, 369, 426, 561};

        int min = nbrs[0];
        int max = nbrs[0];
        foreach (int x in nbrs)
        {
            if (x>max)
            {
                max = x;
            }else if (x<min)
            {
                min = x;
            }
        }
        Console.WriteLine($"Min: {min}, Max: {max}");
    }
}