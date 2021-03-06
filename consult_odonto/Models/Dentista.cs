using System.Collections.Generic;
using Repository;

namespace Models
{
    public class Dentista : Pessoa
    {
        public static int ID = 0;
        private static List<Dentista> Dentistas = new List<Dentista>();
        public string Registro { set; get; }
        public double Salario { set; get; }
        public int IdEspecialidade { set; get; }

        public override string ToString()
        {
            return base.ToString()
                + $"\nRegistro (CRO): {this.Registro}" 
                + $"\nSalario: R$ {this.Salario}"
                + $"\nId da Especialiade: {this.IdEspecialidade}";
        }
        public Dentista(
            string Nome,
            string Cpf,
            string Fone,
            string Email,
            string Senha,
            string Registro,
            double Salario,
            int IdEspecialidade
        ) : this(++ID, Nome, Cpf, Fone, Email, Senha, Registro, Salario, IdEspecialidade)
        {}

        private Dentista(
            int Id,
            string Nome,
            string Cpf,
            string Fone,
            string Email,
            string Senha,
            string Registro,
            double Salario,
            int IdEspecialidade
        ) : base(Id, Nome, Cpf, Fone, Email, Senha)
        {
            this.Registro = Registro;
            this.Salario = Salario;
            this.IdEspecialidade = IdEspecialidade;

            Context db = new Context();
            db.Dentistas.Add(this);
            db.SaveChanges();
        }


        public static List<Dentista> GetDentistas()
        {
            return Dentistas;
        }

        public static void RemoverDentista(Dentista dentista)
        {
            Dentistas.Remove(dentista);
        }
    }
}