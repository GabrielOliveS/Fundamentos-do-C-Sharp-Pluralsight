using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluralSightLearning.Contas
{
    //public record Conta
    //{
    //    private string numeroConta;

    //    public string NumeroConta
    //    {
    //        get { return numeroConta; }
    //        set
    //        {

    //        numeroConta = value; 
    //        }
    //    }
    public record Conta(string NumeroConta);
}
