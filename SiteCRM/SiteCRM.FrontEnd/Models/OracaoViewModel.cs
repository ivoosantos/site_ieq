namespace SiteCRM.FrontEnd.Models
{
    public class OracaoViewModel
    {
        public string nome { get; set; } = string.Empty;
        public string telefone { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string mensagem { get; set; } = string.Empty;
        public DateTime data { get; set; }
        public bool IsPrayer { get; set; }
        public int IdIgreja { get; set; }
    }
}
