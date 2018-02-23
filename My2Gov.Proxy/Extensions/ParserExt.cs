using My2Gov.Proxy.Domains;
using Newtonsoft.Json;

namespace My2Gov.Proxy.Extensions
{
    public static class ParserExt
    {

        public static ResultTask[] AsResults(this string response)
        {
            var result = JsonConvert.DeserializeObject<ResultTask[]>(response);

            return result;
        }

        public static ResultObject<T> AsResult<T>(this string response)
        {
            var result = JsonConvert.DeserializeObject<ResultObject<T>>(response);

            return result;
        }

        public static ResponseResult AsResponse(this string response)
        {
            var result = JsonConvert.DeserializeObject<ResponseResult>(response);

            return result;
        }

    }
}
