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
    public class BouldersController : Controller
    {
        private readonly IBoulderRepository _boulderRepository;
        private readonly ILoggingRepository _loggingRepository;

        public BouldersController(IBoulderRepository boulderRepository,
                                  ILoggingRepository loggingRepository)
        {
            _boulderRepository = boulderRepository;
            _loggingRepository = loggingRepository;
        }

        [HttpGet("{page:int=0}/{pageSize=12}")]
        public PaginationSet<BoulderViewModel> Get(int? page, int? pageSize)
        {
            PaginationSet<BoulderViewModel> pagedSet = new PaginationSet<BoulderViewModel>();

            try
            {
                int currentPage = page.Value;
                int currentPageSize = pageSize.Value;

                List<Boulder> _boulders = null;
                int _totalBoulders = new int();

                _boulders = _boulderRepository
                    .AllIncluding(a => a.Problems)
                    .OrderBy(a => a.Id)
                    .Skip(currentPage * currentPageSize)
                    .Take(currentPageSize)
                    .ToList();

                _totalBoulders = _boulderRepository.GetAll().Count();

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

        [HttpGet("{id:int}/problems/{page:int=0}/{pageSize=12}")]
        public PaginationSet<ProblemViewModel> Get(int id, int? page, int? pageSize)
        {
            PaginationSet<ProblemViewModel> pagedSet = null;

            try
            {
                int currentPage = page.Value;
                int currentPageSize = pageSize.Value;

                List<Problem> _problems = null;
                int _totalProblems = new int();

                Boulder _boulder = _boulderRepository.GetSingle(a => a.Id == id, a => a.Problems);

                _problems = _boulder
                            .Problems
                            .OrderBy(p => p.Id)
                            .Skip(currentPage * currentPageSize)
                            .Take(currentPageSize)
                            .ToList();

                _totalProblems = _boulder.Problems.Count();

                IEnumerable<ProblemViewModel> _problemsVM = Mapper.Map<IEnumerable<Problem>, IEnumerable<ProblemViewModel>>(_problems);

                pagedSet = new PaginationSet<ProblemViewModel>()
                {
                    Page = currentPage,
                    TotalCount = _totalProblems,
                    TotalPages = (int)Math.Ceiling((decimal)_totalProblems / currentPageSize),
                    Items = _problemsVM
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
