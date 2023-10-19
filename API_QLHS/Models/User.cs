using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_QLHS.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public string Code { get; set; }
        public string CpnyCode { get; set; }
        public string SiteCode { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ManagerCode { get; set; }
        public string CategoryCode { get; set; }
        public string GroupCode { get; set; }
        public DateTime RegistationDate { get; set; }
        public int  ExpireDay { get; set; }
        public string Status { get; set; }
        public DateTime RecentLogin { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

       
    }
}
