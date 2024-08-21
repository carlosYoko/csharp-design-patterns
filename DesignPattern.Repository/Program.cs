using DesignPattern.Repository.Models;

public static class Program
{
    public static void Main()
    {
        using (var context = new RepositoryPatternContext())
        {
            var list = context.Beers.ToList();
            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}