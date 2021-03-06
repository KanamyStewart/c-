using System.Collections.Generic;
using Repository;

namespace Models
{
    public class Procedimento 
    {
        public static int ID = 0;
        private static List<Procedimento> Procedimentos = new List<Procedimento>();
        public int Id { set; get; }
        public string Descricao { set; get; }
        public double Preco { set; get; }

         public override string ToString()
        {
            return $"ID: {this.Id}"
                + $"\nDescrição: {this.Descricao}"
                + $"\nPreco: {this.Preco}";
        }

        public Procedimento(
            string Descricao,
            double Preco
        ) : this(++ID, Descricao, Preco)
        {}

        private Procedimento(
            int Id,
            string Descricao,
            double Preco
        )
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.Preco = Preco;

            Context db = new Context();
            db.Procedimentos.Add(this);
            db.SaveChanges();
        }


        public static List<Procedimento> GetProcedimentos()
        {
            return Procedimentos;
        }

        public static void RemoverProcedimento(Procedimento procedimento)
        {
            Procedimentos.Remove(procedimento);
        }
    }
}