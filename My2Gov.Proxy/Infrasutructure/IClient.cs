using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using My2Gov.Proxy.Domains;

namespace My2Gov.Proxy.Infrasutructure
{
    public interface IClient<T> : IDisposable
    {

        Task<ResultTask[]> GetTasks();

        Task<ResultObject<T>> GetTask(int id);

        Task<dynamic> GetPdf(int id);

        Task<dynamic> GetDsInfo(int id);

        Task<ResponseResult> Update(int id, string action, IDictionary<string, object> data);

    }
}
