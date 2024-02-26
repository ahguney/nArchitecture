using Application.Services.Repositories;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandRepository _brandRepository;

        public BrandsController(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        [HttpGet("getlist")]
        public IList<Brand> GetList()
        {
            return _brandRepository.GetList();
        }

        [HttpPost("addbrand")]
        public Brand AddBrand(Brand brand)
        {
            return _brandRepository.Add(brand);
        }

    }
}
