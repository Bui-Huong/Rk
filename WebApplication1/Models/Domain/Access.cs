namespace WebApplication1.Models.Domain
{
    public class Access
    {
        public int AccessId { get; set; }
        public string NameAccess { get; set; }
        public string Category { get; set; }

        public DateTime InstalledDate = DateTime.Now;
        public virtual Admin Admin { get; set; }
    }
}
