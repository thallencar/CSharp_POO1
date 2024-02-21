namespace Exercicio09
{
    public class Consulta
    {
        public DateTime Data { get; set; }
        public string Medico{ get; set; }
        public string Motivo { get; set; }
        public string Diagnostico { get; set;}

        public Consulta(DateTime data, string medico, string motivo, string diagnostico)
        {
            Data = data;
            Medico = medico;
            Motivo = motivo;
            Diagnostico = diagnostico;
        }

        public Consulta()
        {
            
        }

        public void HistoricoDeConsultas()
        {
            Console.WriteLine(@$"Data: {Data}
Médico: {Medico}
Motivo: {Motivo}
Diagnóstico: {Diagnostico}");
        }

        public void CriarNovaConsulta()
        {
            Console.WriteLine("Informe os detalhes da consulta:");
            Console.WriteLine("Diagnóstico");
            Diagnostico = Console.ReadLine();

            Console.WriteLine("Nome do médico: ");
            Medico = Console.ReadLine();


            Console.WriteLine("Data da consulta: ");
            Data = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Motivo da consulta: ");
            Motivo = Console.ReadLine();

        }
    }
}
