namespace ConsoleApp2   
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Songs> list = new List<Songs>
            {
                new( "Mike Bubble", "Some dumb song", 4.02, SongType.Christmas),
                new( "Nat King Cole", "Merry Christmas", 3.22, SongType.Christmas),
                new( "Dave Brubeck", "Unsquare Dance", 2.34, SongType.Jazz),
                new( "John Whillams", "Some Star Wars Shit", 8.69, SongType.Classical),
                new("Jimi Hendricks", "Purple Haze", 4.65, SongType.Rock)
            };

            int[] intArray = [3, 5, 9, 7, 1];

            Songs length = list.FirstOrDefault(x => x.Duration > 5);

            List<Songs> type = list.Where(x => x.Type == SongType.Christmas).ToList();

            Songs last = list.Last();

            if (length != null)
            {
                Console.WriteLine($"{length.Artist} - {length.Title} ({length.Duration} minutes) - Type: {length.Type}");
            }

            foreach (var item in type)
            {
                Console.WriteLine($"{item.Artist} - {item.Title} ({item.Duration} minutes) - Type: {item.Type}" );
            }

            Console.WriteLine($"This is the last song in the list: {last.Title}");

            BubbleSort(intArray);

        }


        static void BubbleSort(int[] array)
        {

            for (int i = 0; i < array.Length; i++) 
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

        }
    }
}