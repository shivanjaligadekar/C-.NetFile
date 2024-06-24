internal class Program
{
    private static void Main(string[] args)
    {
        Print1to10();
        PrintHello();
        Task<int> ans = multiplyNos(2, 3);
        Console.WriteLine("Answer="+ans.Result);
        Console.WriteLine("hello");
    }
    public static async void Print1to10()
    {
        await Task.Run(() =>
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
                Task.Delay(10).Wait();   

            }
        });
    }
    public static async void PrintHello()
    {
        await Task.Run(() => { 
            for (int i = 1;i <= 1;i++)
            {
                Console.WriteLine("Hello");
                Task.Delay(10).Wait();

            }
        });
    }
    public static async Task<int> multiplyNos(int i,int j)
    {
        int ans = 0;
        await Task.Run(() => {
            for(int i = 1; i<10; i++) 
            {
                ans = i * j * 10;
            }
            
        });
        return ans;
    }
}