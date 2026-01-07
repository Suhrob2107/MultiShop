using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MultiShop.IdentityServer.Dtos;
using MultiShop.IdentityServer.Models;
using static Duende.IdentityServer.IdentityServerConstants;

namespace MultiShop.IdentityServer.Controllers
{
    [Authorize(LocalApi.PolicyName)]  // Bu controller'a erişim için LocalApi politikasını kullan
    [Route("api/[controller]")]
    [ApiController]
    public class RegistersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager; // Kullanıcı yönetimi için UserManager servisi

        public RegistersController(UserManager<ApplicationUser> userManager) // Constructor ile UserManager servisini al
        {
            _userManager = userManager; // UserManager servisini private alana ata
        }
        [HttpPost] // HTTP POST isteği için bu metodu kullan
        public async Task<IActionResult> UserRegister(UserRegisterDto userRegisterDto) // Kullanıcı kayıt DTO'sunu parametre olarak al
        {
            var values = new ApplicationUser // Yeni bir ApplicationUser nesnesi oluştur
            {
                UserName = userRegisterDto.UserName, // Kullanıcı adını DTO'dan al
                Email = userRegisterDto.Email, // E-posta adresini DTO'dan al
                Name = userRegisterDto.Name,
                Surname = userRegisterDto.Surname
            };
            var result = await _userManager.CreateAsync(values, userRegisterDto.Password); // Kullanıcıyı veritabanına ekle
            if (result.Succeeded) // Eğer ekleme başarılı ise
            {
                return Ok("Kullanici basriyla eklnedi");
            }
            else
            {
                return BadRequest("Kullanici eklenemedi");
            }
        }
    }
}
