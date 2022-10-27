
namespace projeto_api.Entities
{
    public class DadosGitHub
    {
        public string login { get; set; }
        public string avatar_url { get; set; }
        public string repos_url { get; set; }
        public bool site_admin { get; set; }
        public string location { get; set; }
        public string bio { get; set; }
        public int followers { get; set; }
        public int following { get; set; }
        public string created_at { get; set;}
        public string updated_at { get; set;}

    }
}
