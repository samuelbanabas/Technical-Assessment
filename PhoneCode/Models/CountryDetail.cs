using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneCode.Models
{
    public class CountryDetail
    {
        [Key]
        public int Id { get; set; }


        [ForeignKey("countryId")]

        public int CountryId { get; set; }


        public Country Country { get; set; }

        public string Operator { get; set; }

        public string OperatorCode { get; set; }
    }
}