using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace myfinance_web_dotnet.Infrastructure
{
    public class MyFinanceDbContext{

        private int Id {get; set;}

        private string? Historico {get; set;}

        private DateTime Data {get; set;}

        private decimal Valor {get; set;}

        
    }
}