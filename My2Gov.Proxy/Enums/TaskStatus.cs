using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My2Gov.Proxy.Enums
{
    public enum ResultStatus
    {
        @new,
        process,
        processed,
        rejected
    }
}
