using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface ICepApiService
    {
        //interface e sempre a chamada da api
        [Get("/ws/{cep}/json")]
        Task<APIResponse> GetAddressAsync(string cep);
    }
}
