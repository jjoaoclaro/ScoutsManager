using ScoutsManager.Enums;

namespace ScoutsManager.Models
{
    public class Scout
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Nin { get; set; }

        public string Nif { get; set; }

        public Cargo Cargo { get; set; }
    }
}
