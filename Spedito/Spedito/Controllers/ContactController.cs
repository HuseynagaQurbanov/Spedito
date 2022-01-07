using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Spedito.Models;
using SpeditoReposity.Models;
using SpeditoReposity.Reposities.AuthReposities;
using SpeditoReposity.Repositories.SettingRepository;
using System.Collections.Generic;

namespace Spedito.Controllers
{
    public class ContactController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAuthRepository _authRepository;
        private readonly ISettingRepository _settingRepository;
        public ContactController(IMapper mapper,
                                 IAuthRepository authRepository,
                                 ISettingRepository settingRepository)
        {
            _mapper = mapper;
            _authRepository = authRepository;
            _settingRepository = settingRepository;
        }

        public IActionResult Index()
        {
            var settings = _settingRepository.GetSettings();
            var model = _mapper.Map<IEnumerable<Setting>, IEnumerable<ContactViewModel>>(settings);

            return View(model);
        }
    }
}
