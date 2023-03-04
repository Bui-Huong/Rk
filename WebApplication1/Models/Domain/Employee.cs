namespace WebApplication1.Models.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Boolean Role { get; set; }
        public long Salary { get; set; }
        public DateTime DateOfBith { get; set;}
        public string Department { get; set; }
        public virtual ICollection<Admin> Admins { get; set; }
    }

}
