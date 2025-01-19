using UdemyCarBook.Application.Features.CQRS.Results.CarResults;
using UdemyCarBook.Application.Interfaces.CarInterfaces;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly ICarRepository _carRepository;

        public GetCarWithBrandQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public List<GetCarWithBrandQueryResult> Handle()
        {
            var value = _carRepository.GetCarsListWithBrands();
            return value
                .ConvertAll(x => new GetCarWithBrandQueryResult
                {
                    Id = x.Id,
                    BigImageUrl = x.BigImageUrl,
                    BrandId = x.BrandId,
                    CoverImageUrl = x.CoverImageUrl,
                    Fuel = x.Fuel,
                    Km = x.Km,
                    Luggage = x.Luggage,
                    Model = x.Model,
                    Seat = x.Seat,
                    BrandName = x.Brand.Name
                });
        }
    }
}
