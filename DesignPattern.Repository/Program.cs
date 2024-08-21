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

            foreach (var item in beerRepository.Get()) { Console.WriteLine(item.Name); }


            var brandRepository = new Repository<Brand>(context);
            var brand = new Brand() { Name = "Damm" };
            brandRepository.Add(brand);
            brandRepository.Save();

            foreach (var item in brandRepository.Get()) { Console.WriteLine(item.Name); }
        }
    }
}