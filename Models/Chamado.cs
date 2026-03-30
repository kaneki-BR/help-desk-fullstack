namespace SistemaChamados.Api.Models
{
    public class Chamado
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public DateTime DataAbertura { get; set; } = DateTime.Now;
        public string status { get; set; } = "Aberto"; //Aberto, Em Atendimento, Concluído
        public string Prioridade { get; set; } = "Média"; //Baixa, Média, Alta
    }
}
