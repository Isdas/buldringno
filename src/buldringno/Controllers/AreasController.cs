using AutoMapper;
using BuldringNo.Entities;
using BuldringNo.Infrastructure.Core;
using BuldringNo.Infrastructure.Repositories;
using BuldringNo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BuldringNo.Controllers
{
    [Route("api/[controller]")]
    public class AreasController : Controller
    {
        private readonly IAreaRepository _areaRepository;
        private readonly ILoggingRepository _loggingRepository;

        public AreasController(IAreaRepository areaRepository,
                               ILoggingRepository loggingRepository)
        {
            _areaRepository = areaRepository;
            _loggingRepository = loggingRepository;
        }

        [HttpGet("{page:int=0}/{pageSize=12}")]
        public PaginationSet<AreaViewModel> Get(int? page, int? pageSize)
        {
            PaginationSet<AreaViewModel> pagedSet = new PaginationSet<AreaViewModel>();

            try
            {
                int currentPage = page.Value;
                int currentPageSize = pageSize.Value;

                List<Area> _areas = null;
                int _totalAreas = new int();

                _areas = _areaRepository
                    .AllIncluding(a => a.Boulders)
                    .OrderBy(a => a.Id)
                    .Skip(currentPage * currentPageSize)
                    .Take(currentPageSize)
                    .ToList();

                _totalAreas = _areaRepository.GetAll().Count();

                IEnumerable<AreaViewModel> _areasVM = Mapper.Map<IEnumerable<Area>, IEnumerable<AreaViewModel>>(_areas);

                pagedSet = new PaginationSet<AreaViewModel>()
                {
                    Page = currentPage,
                    TotalCount = _totalAreas,
                    TotalPages = (int)Math.Ceiling((decimal)_totalAreas / currentPageSize),
                    Items = _areasVM
                };
            }
            catch (Exception ex)
            {
                _loggingRepository.Add(new Error() { Message = ex.Message, StackTrace = ex.StackTrace, DateCreated = DateTime.Now });
                _loggingRepository.Commit();
            }

            return pagedSet;
        }

        [HttpGet("{id:int}/boulders/{page:int=0}/{pageSize=12}")]
        public PaginationSet<BoulderViewModel> Get(int id, int? page, int? pageSize)
        {
            PaginationSet<BoulderViewModel> pagedSet = null;

            try
            {
                int currentPage = page.Value;
                int currentPageSize = pageSize.Value;

                List<Boulder> _boulders = null;
                int _totalBoulders = new int();

                Area _area = _areaRepository.GetSingle(a => a.Id == id, a => a.Boulders);

                _boulders = _area
                            .Boulders
                            .OrderBy(p => p.Id)
                            .Skip(currentPage * currentPageSize)
                            .Take(currentPageSize)
                            .ToList();

                _totalBoulders = _area.Boulders.Count();

                IEnumerable<BoulderViewModel> _bouldersVM = Mapper.Map<IEnumerable<Boulder>, IEnumerable<BoulderViewModel>>(_boulders);

                pagedSet = new PaginationSet<BoulderViewModel>()
                {
                    Page = currentPage,
                    TotalCount = _totalBoulders,
                    TotalPages = (int)Math.Ceiling((decimal)_totalBoulders / currentPageSize),
                    Items = _bouldersVM
                };
            }
            catch (Exception ex)
            {
                _loggingRepository.Add(new Error() { Message = ex.Message, StackTrace = ex.StackTrace, DateCreated = DateTime.Now });
                _loggingRepository.Commit();
            }

            return pagedSet;
        }
    }
}
