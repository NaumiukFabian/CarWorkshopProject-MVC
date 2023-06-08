namespace CarWorkshop.Application.Services
{
    public interface ICarWorkshopService
    {
        Task Creat(Domain.Entities.CarWorkshop carWorkshop);
    }
}