using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Queries.AboutQueries;
using UdemyCarBook.Application.Features.CQRS.Results.AboutResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutByIdQueryHandler
    {
        private readonly IRepository<About> _repository;

        public GetAboutByIdQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public GetAboutByIdQueryResult Handle(GetAboutByIdQuery query)
        {
            var value = _repository.GetByIdAsync(query.Id).Result;
            return new GetAboutByIdQueryResult
            {
                Id = value.Id,
                Title = value.Title,
                Description = value.Description,
                ImageUrl = value.ImageUrl,
            };
        }
    }
}
