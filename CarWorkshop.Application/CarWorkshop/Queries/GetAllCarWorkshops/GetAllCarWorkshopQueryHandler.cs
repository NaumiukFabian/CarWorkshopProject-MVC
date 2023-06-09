﻿using AutoMapper;
using CarWorkshop.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Application.CarWorkshop.Queries.GetAllCarWorkshops
{
    public class GetAllCarWorkshopQueryHandler : IRequestHandler<GetAllCarWorkshopsQuery, IEnumerable<CarWorkshopDto>>
    {
        private readonly IMapper _mapper;
        private readonly ICarWorkshopRepository _carWorkshopRepository;
        public GetAllCarWorkshopQueryHandler(IMapper mapper, ICarWorkshopRepository carWorkshopRepository)
        {
            _mapper = mapper;
            _carWorkshopRepository = carWorkshopRepository;
        }
        public async Task<IEnumerable<CarWorkshopDto>> Handle(GetAllCarWorkshopsQuery request, CancellationToken cancellationToken)
        {
            var carWorkshops = await _carWorkshopRepository.GetAll();
            var carWorkshopDto = _mapper.Map<IEnumerable<CarWorkshopDto>>(carWorkshops);
            return carWorkshopDto;
        }
    }
}
