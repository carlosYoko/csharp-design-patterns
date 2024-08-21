using DesignPattern.Repository.Models;
using DesignPattern.Repository.Repository;

public static class Program
{
    public static void Main()
    {
        using (var context = new RepositoryPatternContext())
        {
            var beerRepository = new Repository<Beer>(context);
            var beer = new Beer() { Name = "Chuff", Style = "Belgium" };
            beerRepository.Add(beer);
            beerRepository.Save();

            foreach (var item in beerRepository.Get())
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}