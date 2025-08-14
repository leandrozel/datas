using System;
using aula02RH.Model;
using aula02RH.Model.Enuns;
namespace aula02RH;

// um comentário qualquer

public class aula02RH{

    public static void Main(string[]args){
      
     /*Funcionario f = new Funcionario();
     f.Id =10;
     f.Nome = "leandro";
     f.Cpf = "12345678910";
     f.DataAdmissão = DateTime.Parse("01/01/2000");
     f.sálario = 1000.00M;
     f.Tipofuncionario = TipofuncionarioEnum.Aprendiz;
     string mensagem = f. ExibirPeriodoExperiencia();
     Console.WriteLine(mensagem);
    }*/
    Funcionario func = new Funcionario();
    Console.WriteLine("Digite o id do funcionário: ");
    func.Id = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o nome do funcionário: ");
    func.Nome = Console.ReadLine();
     Console.WriteLine("Digite o CPF");
     func.Cpf = Console.ReadLine();
      Console.WriteLine("Digite a data de Admissão: ");
      func.DataAdmissão = DateTime.Parse(Console.ReadLine());
       Console.WriteLine("Digite o Salário: ");
       func.sálario = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Escolha o tipo de Funcionário  (' 1- CLT / 2 - Aprendiz): ");
        int opcao = int.Parse(Console.ReadLine());
        func.Tipofuncionario = (opcao == 1 )? TipofuncionarioEnum.CLT : TipofuncionarioEnum.Aprendiz;

        func.Reajustarsálario();
        decimal valorDescontoVT = func.CalcularDescontoVT(6);

         Console.WriteLine("==============================");
          Console.WriteLine($"O salário reajustado é {func.sálario}.\n");
           Console.WriteLine($"O desconto do VT é{valorDescontoVT}.\n");
            Console.WriteLine("==============================");

}
}


