using Microsoft.AspNetCore.Http;
using SpeditoReposity.Models;
using SpeditoReposity.Reposities.AuthReposities;

namespace Spedito.Libs
{
    public interface IAuth
    {
        User User { get; }
    }

    public class Auth : IAuth
    {
        private readonly IAuthRepository _authRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public Auth(IAuthRepository authRepository,
                    IHttpContextAccessor httpContextAccessor)
        {
            _authRepository = authRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        public User User
        {
            get
            {
                _httpContextAccessor.HttpContext.Request.Cookies.TryGetValue("token", out string token);

                return _authRepository.CheckByToken(token);
            }
        }
    }
}
