using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using aula02RH.Model.Enuns;
//um comentário qualquer para deixar no git
namespace aula02RH.Model
{
    public class Funcionario
    {
     public int Id {get;set;}
     public string Nome {get;set;}
     public string Cpf{get;set;}
     public DateTime DataAdmissão{get;set;}
     public decimal sálario{get;set;}

     public TipofuncionarioEnum  Tipofuncionario;

     public void Reajustarsálario(){
        sálario = sálario+(sálario *10/100);

     }
  
        public string ExibirPeriodoExperiencia(){

            
        string periodoExperiencia = string.Format("Periodo de experiencia{0} até {1}",
        DataAdmissão,DataAdmissão.AddMonths(3));

        return periodoExperiencia;
    }

    public decimal CalcularDescontoVT(decimal percentual){

        decimal desconto = this.sálario* percentual/100;
        return desconto;
    }
       private int ContarCaracteres(string dado){
        return dado.Length;
     }
     public bool ValidarCpf(){
        if(ContarCaracteres(Cpf)==11)
        return true;
        else 
        return false;

     }

        }

}