using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using My2Gov.Proxy.Consts;
using My2Gov.Proxy.Domains;
using My2Gov.Proxy.Extensions;
using My2Gov.Proxy.Infrasutructure;

namespace My2Gov.Proxy.Clients
{
    /// <summary>
    /// 
    /// Подача заявления на получение статуса брокера
    ///
    /// https://my2.gov.uz/ru/applying-for-receiving-broker-status-first-version/rest-api-documentation 
    /// 
    /// </summary>
    public sealed class MyGovClient2 : BaseClient<ApplyingforreceivingbrokerstatusEntities>
    {

        /// <summary>
        /// fields
        /// </summary>
        private const string _baseAddress = DomainConfig.EndPoint + "/applying-for-receiving-broker-status-first-version/rest-api";

        /// <inheritdoc />
        /// <summary>
        /// ctor
        /// </summary>
        public MyGovClient2() : base(_baseAddress)
        {

        }
         
        public override async Task<ResponseResult> Update(int id, string action, IDictionary<string, object> data)
        {
            if (!ActionList.Validate(action))
                throw new Exception("Действие недоступно!");

            var ent = await GetTask(id);
            if (ent.task.current_node != "application-evaluation")
                throw new Exception("Нода: Рассмотрение заявки (application-evaluation)");

            var json_data = "{";
            switch (action)
            {
                case ActionList.AcceptFormOfReceivingStatusBroker:
                    json_data += "\"AcceptFormFormApplyingForReceivingBrokerStatus\":{";
                    json_data += string.Join(",", data.Select(s => string.Format("\"{0}\":\"{1}\"", s.Key, s.Value)));
                    json_data += "}";
                    break;
                case ActionList.RejectFormOfReceivingStatusBroker:
                    json_data += "\"FormOfRejectFormApplyingForReceivingBrokerStatus\":{";
                    json_data += string.Join(",", data.Select(s => string.Format("\"{0}\":\"{1}\"", s.Key, s.Value)));
                    json_data += "}";
                    break;
            }

            json_data += "}";
            var task = await Client.UploadStringTaskAsync(_baseAddress + "/update?id=" + id + "&action=" + action, "POST", json_data);

            return task.AsResponse();
        }

    }
}
