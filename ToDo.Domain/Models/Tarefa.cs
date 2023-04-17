namespace ToDo.Domain.Models
{
    public class Tarefa : BaseEntity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDeConclusao { get; set; }   
    }
}