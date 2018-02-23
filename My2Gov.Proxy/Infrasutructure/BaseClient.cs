using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using My2Gov.Proxy.Domains;
using My2Gov.Proxy.Extensions;
using Newtonsoft.Json;

namespace My2Gov.Proxy.Infrasutructure
{
    public abstract class BaseClient<T> : IClient<T>
    {
        /// <summary>
        /// fields
        /// </summary>
        private readonly WebClient _client;

        private readonly string _baseAddress;

        /// <summary>
        /// ctor
        /// </summary>
        protected BaseClient(string baseAddress)
        {
            _client = new WebClient
            {
                UseDefaultCredentials = true,
                Credentials = CredentialCache.DefaultCredentials,
                Encoding = Encoding.UTF8,
                Headers =
                {
                    [HttpRequestHeader.ContentType] = "application/json",
                    [HttpRequestHeader.Authorization] = string.Format("Basic {0}", DomainConfig.Credentials)
                }
            };

            _baseAddress = baseAddress;
        }

        /// <summary>
        /// web client
        /// </summary>
        public WebClient Client
        {
            get
            {
                return _client;
            }
        }

        /// <summary>
        /// Dispose resources
        /// </summary>
        public void Dispose()
        {
            _client.Dispose();
        }

        /// <summary>
        /// /rest-api/get-tasks (GET)
        /// </summary>
        /// <returns>
        /// get-tasks - Получения списка активных заявок заявок:
        /// </returns>
        public virtual async Task<ResultTask[]> GetTasks()
        {
            var task = await Client.DownloadStringTaskAsync(_baseAddress + "/get-tasks");

            return task.AsResults();
        }

        /// <summary>
        /// /rest-api/get-task (GET)
        /// </summary>
        /// <param name="id">Task ID from database	</param>
        /// <returns>
        /// get-task - Получение информации о заявке:
        /// </returns>
        public virtual async Task<ResultObject<T>> GetTask(int id)
        {
            var task = await Client.DownloadStringTaskAsync(_baseAddress + "/get-task/" + id);

            return task.AsResult<T>();
        }

        /// <summary>
        /// /rest-api/get-pdf (GET)
        /// </summary>
        /// <param name="id">Task ID from database	</param>
        /// <returns> 
        /// get-pdf - Получение PDF файла:
        /// </returns>
        public virtual async Task<dynamic> GetPdf(int id)
        {
            var task = await Client.DownloadStringTaskAsync(_baseAddress + "/get-pdf/" + id);
            var result = JsonConvert.DeserializeObject<dynamic>(task);

            return result;
        }

        /// <summary>
        /// /rest-api/get-ds-info (GET)
        /// </summary>
        /// <param name="id">Task ID from database	</param>
        /// <returns>
        /// get-ds-info - Получение данных с ЭЦП:
        /// </returns>
        public virtual async Task<dynamic> GetDsInfo(int id)
        {
            var task = await Client.DownloadStringTaskAsync(_baseAddress + "/get-ds-info/" + id);
            var result = JsonConvert.DeserializeObject<dynamic>(task);

            return result;
        }

        /// <summary>
        /// /rest-api/update (PUT, POST)
        /// </summary>
        /// <param name="id">Task ID from database	</param>
        /// <returns>
        /// update - Обновить данные заявки
        /// </returns>
        public virtual async Task<ResponseResult> Update(int id, string action, IDictionary<string, object> data)
        {
            throw new NotImplementedException();
        }

    }
}
