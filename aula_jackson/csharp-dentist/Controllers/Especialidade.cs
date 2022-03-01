using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Controllers
{
    public class EspecialidadeController
    {
        public static Especialidade InserirEspecialidade(
            string Descricao,
            string Detalhamento
        )
        {
           if (String.IsNullOrEmpty(Descricao))
            {
                throw new Exception("Descrição inválida");
            }

            if (String.IsNullOrEmpty(Detalhamento))
            {
                throw new Exception("Detalhamento precisa ser preenchido");
            }
        }

        public static Especialidade AlterarEspecialidade(
            int Id,
            string Descricao,
            string Detalhamento
        )
        {
            Especialidade especialidade = GetEspecialides(Id);

            if (!String.IsNullOrEmpty(Descricao))
            {
                especialidade.Descricao = Descricao;
            }

            if (!String.IsNullOrEmpty(Detalhamento))
            {
                especialidade.Detalhamento = Detalhamento;
            }

            return especialidade;
        }

        public static Especialidade ExcluirEspecialidade(
            int Id
        )
        {
            Especialidade especialidade = GetEspecialides(Id);
            Especialidade.RemoverEspecialidade(especialidade);
            return especialidade;
        }

        public static List<Especialidade> VisualizarEspecialide()
        {
            return Especialidade.GetAgendamentos();
        }

        public static Especialidade GetEspecialides(
            int Id
        )
        {
            Especialidade especialidade = (
                from Especialidade in Especialidade.GetEspecialides()
                    where Especialidade.Id == Id
                    select Especialidade
            ).First();

            if (especialidade == null)
            {
                throw new Exception("Especialidade não encontrada.");
            }

            return especialidade;
        }
    }
}