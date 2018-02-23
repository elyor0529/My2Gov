using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My2Gov.Proxy.Consts
{
    public struct ActionList
    {
        public const string AcceptForm = "accept-form";
        public const string RejectApplication = "reject-application";
        public const string AcceptFormOfReceivingStatusBroker = "accept-form-of-receiving-status-broker";
        public const string RejectFormOfReceivingStatusBroker = "reject-form-of-receiving-status-broker";

        public static bool Validate(string action)
        {
            return action == AcceptForm || action == RejectApplication || action == AcceptFormOfReceivingStatusBroker || action == RejectFormOfReceivingStatusBroker;
        }

    }
}
