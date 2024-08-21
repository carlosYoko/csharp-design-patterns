using DesignPattern.Repository.Models;
using DesignPattern.Repository.Repository;

public static class Program
{
    public static void Main()
    {
        using (var context = new RepositoryPatternContext())
        {
            var beerRepository = new BeerRepository(context);
            var beer = new Beer();
            beer.Name = "Corona";
            beer.Style = "Pilsner";
            beerRepository.Add(beer);
            beerRepository.Save();

            foreach (var item in beerRepository.Get())
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}