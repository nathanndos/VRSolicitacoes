using Entity.Interface;

namespace Entity
{
    public class Pessoa : IEntityBase
    {
        public Guid Ide { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Status { get; set; }

        public Pessoa()
        {
            Ide = Guid.Empty;
            Id = 0;
            Name = string.Empty;
            LastName = string.Empty;
            Status = 0;
        }
    }
}