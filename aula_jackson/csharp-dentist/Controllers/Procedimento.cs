using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Controllers
{
  public class ProcedimentoController
    {
      public static Procedimento InserirProcedimento(
        string Descricao,
        double Preco
      )
      {
        return new Procedimento(Descricao, Preco);
      }

      public static Procedimento AlterarProcedimento(
        int Id,
        string Descricao,
        double Preco
      )
      {
        Procedimento procedimento = GetProcedimento(Id);

        return procedimento;
      }
      public static Procedimento ExcluirProcedimento(
        int Id
      )
      {
        Procedimento procedimento = GetProcedimentos(Id);
        procedimento.RemoverProcedimento(procedimento);
        return procedimento;
      }
      public static List<Procedimento> VisualizarProcedimentos()
      {
        return Procedimento.GetProcedimentos();
      }
      public static Procedimento GetProcedimento(
        int Id
      )
      {
        Procedimento Procedimento = (
            from Procedimento in Procedimento.GetProcedimentos()
                where Procedimento.Id == Id
                select Procedimento
        ).First();

        if (procedimento == null)
        {
            throw new Exception("Procedimento não encontrado.");
        }

        return procedimento;
      }
    }
}