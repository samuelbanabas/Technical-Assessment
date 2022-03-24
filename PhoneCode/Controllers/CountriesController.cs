using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PhoneCode.Models;

namespace PhoneCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly CountryContext _context;

        public CountriesController(CountryContext context)
        {
            _context = context;
        }


        [HttpGet("GetCountyCodeByPhNo")]
        public async Task<ActionResult<CountryDto>> GetCountyCodeByPhNo(string phoneNumber)
        {
            List<CountryDto> countryDtos = new List<CountryDto>();
            List<CountryDetailDto> countryDetailsDtos = new List<CountryDetailDto>();


            var code = phoneNumber.Substring(0,3);

            var country = await _context.Countries
                .Include(u => u.CountryDetails)
                .FirstOrDefaultAsync(x=>x.CountryCode==int.Parse(code));
             

            foreach (var item in country.CountryDetails)
            {
                countryDetailsDtos.Add(new CountryDetailDto
                {
                    Operator = item.Operator,
                    OperatorCode = item.OperatorCode
                });
            }
            var result = new CountryDto
            {
                PhoneNumber= phoneNumber,   
                CountryCode = country.CountryCode,
                CountryIso = country.CountryIso,
                Name = country.Name,
                CountryDetails = countryDetailsDtos
            };

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }


        [HttpGet("getAll")]
         [Produces(typeof(List<CountryDto>))]
        public async Task<IActionResult> Get()
        {
            List<CountryDto> countryDtos = new List<CountryDto>();
            List<CountryDetailDto> countryDetailsDtos = new List<CountryDetailDto>();

            var countries = await _context.Countries
                .Include(u => u.CountryDetails)
                .ToListAsync();

            foreach(var item in countries)
            {
                countryDetailsDtos.Add(new CountryDetailDto
                {
                    Operator = item.CountryDetails.FirstOrDefault(x=>x.CountryId==item.Id).Operator,
                    OperatorCode = item.CountryDetails.FirstOrDefault(x => x.CountryId == item.Id).OperatorCode
                });
                countryDtos.Add(new CountryDto
                {
                    CountryCode = item.CountryCode,
                    CountryIso = item.CountryIso,
                    Name = item.Name,
                    CountryDetails = countryDetailsDtos
                });
            }


            return Ok(countryDtos);
        }
 

        
    }
}
