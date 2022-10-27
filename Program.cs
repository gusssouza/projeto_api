using projeto_api.Entities;
using RestSharp;
using RestSharp.Deserializers;

namespace Projeto
{
    class ProjetoApi
    {
        public static async Task Main(string[] args)
        {

            Console.WriteLine("Insira o nome do usuário que você deseja pesquisar");
            string user = Console.ReadLine();
            string link = "https://api.github.com/users/";
            RestClient restClient = new RestClient($"{link}{user}");
            RestRequest restRequest = new RestRequest();
            IRestResponse response = restClient.Execute(restRequest);

            if(response.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                Console.WriteLine("Erro");
            }
            else
            {
                DadosGitHub dados = new JsonDeserializer().Deserialize<DadosGitHub>(response);
                Console.WriteLine("Login: " + dados.login);
                Console.WriteLine("Avatar: " + dados.avatar_url);
                Console.WriteLine("Repos: " + dados.repos_url);
                Console.WriteLine("Site: " + dados.site_admin);
                Console.WriteLine("Location: " + dados.location);
                Console.WriteLine("Bio: " + dados.bio);
                Console.WriteLine("Followers: " + dados.followers);
                Console.WriteLine("Following: " + dados.following);
                Console.WriteLine("Created: " + dados.created_at);
                Console.WriteLine("Updated: " + dados.updated_at);
            }
        }
    }
}
