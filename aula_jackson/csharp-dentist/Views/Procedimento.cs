using System;
using Controllers;
using Models;

namespace Views
{
  public class ProcedimentoView
  {
    public static void InserirProcedimento()
      {
        string Descricao;
        double Preco;
        Console.WriteLine("Digite a descricao do Procedimento: ");
        try
        {
            IdPaciente = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            throw new Exception("ID inválido.");
        }
        Console.WriteLine("Digite o Id do Dentista do Agendamento: ");
        try
        {
            IdDentista = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            throw new Exception("ID inválido.");
        }
        Console.WriteLine("Digite o Id da Sala do Agendamento: ");
        try
        {
            IdSala = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            throw new Exception("ID inválido.");
        }
        Console.WriteLine("Digite o Data do Agendamento: ");
        try
        {
            Data = Convert.ToDateTime(Console.ReadLine());
        }
        catch
        {
            throw new Exception("Data inválida.");
        }

        Console.WriteLine("Digite os Procedimentos do Agendamento: ");
        string Procedimentos = Console.ReadLine();

        AgendamentoController.InserirAgendamento(
            IdPaciente,
            IdDentista,
            IdSala,
            Data,
            Procedimentos
        );
    }
  }
}