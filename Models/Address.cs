using System.ComponentModel.DataAnnotations;

namespace ERPCore.Models
{
    public class Address
    {
        public int Id { get; set; }

        /// <summary>
        /// Address Line 1
        /// </summary>
        [MaxLength(100)]
        [Required]
        public string Address1 { get; set; }
        
        /// <summary>
        /// Address Line 2
        /// </summary>
        [MaxLength(100)]
        public string Address2 { get; set; }
        
        /// <summary>
        /// State Name
        /// </summary>
        [Required]
        public string State { get; set; }
        
        /// <summary>
        /// City Name
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string City { get; set; }
        
        /// <summary>
        /// Zip code of city
        /// </summary>
        [Required]
        [DataType(DataType.PostalCode)]
        public string Zip { get; set; }
    }
}