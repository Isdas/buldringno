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
    public class UsersController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly ILoggingRepository _loggingRepository;

        public UsersController(IUserRepository userRepository, ILoggingRepository loggingRepository)
        {
            _userRepository = userRepository;
            _loggingRepository = loggingRepository;
        }

        [HttpGet("{page:int=0}/{pageSize=12}")]
        public PaginationSet<UserViewModel> Get(int? page, int? pageSize)
        {
            PaginationSet<UserViewModel> pagedSet = null;

            try
            {
                int currentPage = page.Value;
                int currentPageSize = pageSize.Value;

                List<User> _users = null;
                int _totalUsers = new int();

                _users = _userRepository
                    .GetAll()
                    .OrderBy(p => p.Id)
                    .Skip(currentPage * currentPageSize)
                    .Take(currentPageSize)
                    .ToList();

                _totalUsers = _userRepository.GetAll().Count();

                IEnumerable<UserViewModel> _usersVM = Mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(_users);

                pagedSet = new PaginationSet<UserViewModel>()
                {
                    Page = currentPage,
                    TotalCount = _totalUsers,
                    TotalPages = (int)Math.Ceiling((decimal)_totalUsers / currentPageSize),
                    Items = _usersVM
                };
            }
            catch (Exception ex)
            {
                _loggingRepository.Add(new Error() { Message = ex.Message, StackTrace = ex.StackTrace, DateCreated = DateTime.Now });
                _loggingRepository.Commit();
            }

            return pagedSet;
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            IActionResult _result = new ObjectResult(false);
            GenericResult _removeResult = null;

            try
            {
                User _userToRemove = this._userRepository.GetSingle(id);
                _userRepository.Delete(_userToRemove);
                _userRepository.Commit();

                _removeResult = new GenericResult()
                {
                    Succeeded = true,
                    Message = "User removed."
                };
            }
            catch (Exception ex)
            {
                _removeResult = new GenericResult()
                {
                    Succeeded = false,
                    Message = ex.Message
                };

                _loggingRepository.Add(new Error() { Message = ex.Message, StackTrace = ex.StackTrace, DateCreated = DateTime.Now });
                _loggingRepository.Commit();
            }

            _result = new ObjectResult(_removeResult);
            return _result;
        }
    }
}
