namespace Exercicio09
{
    public class Paciente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Consulta> Historico { get; set; }

        public Paciente(string nome, int idade, List<Consulta> historico)
        {
            Nome = nome;
            Idade = idade;
            Historico = historico;
        }

        public void NovaConsulta(Consulta novaConsulta)
        {
 
            Historico.Add(novaConsulta);
        }

        public void HistoricoConsulta()
        {
            foreach (var consulta in Historico)
            {
                consulta.HistoricoDeConsultas();
                Console.WriteLine();
            }
        }
    }
}
