namespace CrudProjectApi.Model
{
    public class Staff
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? Address { get; set; }

        public DateTime DateTime { get; set; }= DateTime.Now;

        public string? DepNo { get; set; }
    }
}
