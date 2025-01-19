using UdemyCarBook.Application.Features.CQRS.Results.CarResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();

            return values.ConvertAll(x => new GetCarQueryResult
            {
                Id = x.Id,
                BrandId = x.BrandId,
                Model = x.Model,
                CoverImageUrl = x.CoverImageUrl,
                Km = x.Km,
                BigImageUrl = x.BigImageUrl,
                Fuel = x.Fuel,
                Luggage = x.Luggage,
                Seat = x.Seat,
                Transmission = x.Transmission,
            });
        }
    }
}