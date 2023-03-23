using System.ComponentModel.DataAnnotations;

namespace Formation_TP1.Dto
{
    public class restaurant
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string cuisine { get; set; }



    }
}
