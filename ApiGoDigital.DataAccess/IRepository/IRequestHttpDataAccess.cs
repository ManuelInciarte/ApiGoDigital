using ApiGoDigital.DataAccess.Entities;
using System.Threading.Tasks;

namespace ApiGoDigital.DataAccess.IRepository
{
    public interface IRequestHttpDataAccess
    {
        Task<string> CallGetMethod(string service, string method, string parameters);


    }
}
