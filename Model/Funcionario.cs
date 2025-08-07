using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using aula02RH.Model.Enuns;

namespace aula02RH.Model
{
    public class funcionario
    {
     public int id {get;set;}
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

        }

}