using System.Collections.Generic;

namespace PhoneCode.Models
{
    public class CountryDto
    {

        public string PhoneNumber { get; set; }
        public int CountryCode { get; set; }

        public string Name { get; set; }

        public string CountryIso { get; set; }

        public virtual List<CountryDetailDto> CountryDetails { get; set; }

    }

    public class CountryDetailDto
    {

        public string Operator { get; set; }

        public string OperatorCode { get; set; }
    }

}
