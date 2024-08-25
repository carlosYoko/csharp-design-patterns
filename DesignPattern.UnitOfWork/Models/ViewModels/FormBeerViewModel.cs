namespace DesignPattern.UnitOfWork.Models.ViewModels
{
    public class FormBeerViewModel
    {
        public string Name { get; set; }
        public string Style { get; set; }
        public Guid? BrandId { get; set; }
        public string OtherBrand { get; set; }

    }
}
