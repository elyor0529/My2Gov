using My2Gov.Proxy.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace My2Gov.Proxy.Domains
{
    public class ResultTask
    {

        public int id { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ResultStatus status { get; set; }

        public string last_update { get; set; }

        public string current_node { get; set; }

    }

    public class ResultObject<T>
    {

        public ResultTask task { get; set; }

        public T entities { get; set; }

    }

    public class ResultElement
    {

        public string label { get; set; }

        public object value { get; set; }

        public object real_value { get; set; }

    }

    public class ResponseResult
    {

        public string status { get; set; }

        public ResultTask task { get; set; }

    }

    #region Doc-1

    public class ApplyingForOpeningTradingPaltformEntities
    {
        public ApplyingforopeningtradingpaltformItem ApplyingForOpeningTradingPaltform { get; set; }
    }

    public class ApplyingforopeningtradingpaltformItem
    {
        public ResultElement id { get; set; }
        public ResultElement authority_id { get; set; }
        public ResultElement legal_form { get; set; }
        public ResultElement serial_number { get; set; }
        public ResultElement reestr_number { get; set; }
        public ResultElement given_date { get; set; }
        public ResultElement legal_address { get; set; }
        public ResultElement address_platform { get; set; }
        public ResultElement bank_name { get; set; }
        public ResultElement account_number { get; set; }
        public ResultElement mfo { get; set; }
        public ResultElement registrator_name { get; set; }
        public ResultElement test_number { get; set; }
        public ResultElement order_number { get; set; }
        public ResultElement registrator_contact { get; set; }
        public ResultElement notification_for_user { get; set; }
        public ResultElement date_of_sending_notification { get; set; }
        public ResultElement reason_of_reject { get; set; }
        public ResultElement date_of_reject { get; set; }
        public ResultElement legal_head_name { get; set; }
        public ResultElement legal_email { get; set; }
        public ResultElement company_phone { get; set; }
        public ResultElement legal_company_tin { get; set; }
        public ResultElement legal_name_company { get; set; }
        public ResultElement about_service { get; set; }
        public ResultElement docs_are_present { get; set; }
    }

    #endregion

    #region Doc-2

    public class ApplyingforreceivingbrokerstatusEntities
    {
        public ApplyingforreceivingbrokerstatusItem ApplyingForReceivingBrokerStatus { get; set; }
    }

    public class ApplyingforreceivingbrokerstatusItem
    {
        public ResultElement applicant_sign { get; set; }
        public ResultElement authority_sign { get; set; }
        public ResultElement legal_okonh { get; set; }
        public ResultElement id { get; set; }
        public ResultElement fax { get; set; }
        public ResultElement account_number { get; set; }
        public ResultElement bank_name { get; set; }
        public ResultElement notification_for_user { get; set; }
        public ResultElement date_of_sending_notification { get; set; }
        public ResultElement reason_of_reject { get; set; }
        public ResultElement date_of_reject { get; set; }
        public ResultElement authority_id { get; set; }
        public ResultElement legal_company_tin { get; set; }
        public ResultElement legal_email { get; set; }
        public ResultElement company_phone { get; set; }
        public ResultElement legal_name_company { get; set; }
        public ResultElement mfo { get; set; }
        public ResultElement about_service { get; set; }
        public ResultElement docs_are_present { get; set; }
    }


    #endregion

    #region Doc-3

    public class ApplyingforinclusionofgoodsintheexchangelistEntities
    {
        public ApplyingforinclusionofgoodsintheexchangelistItem ApplyingForInclusionOfGoodsInTheExchangeList { get; set; }
    }

    public class ApplyingforinclusionofgoodsintheexchangelistItem
    {
        public ResultElement _base { get; set; }
        public ResultElement company_head_name { get; set; }
        public ResultElement legal_name_company { get; set; }
        public ResultElement product_name { get; set; }
        public ResultElement code_tnved { get; set; }
        public ResultElement product_code { get; set; }
        public ResultElement unit_of_measure { get; set; }
        public ResultElement id { get; set; }
        public ResultElement lot { get; set; }
        public ResultElement start_price { get; set; }
        public ResultElement nds { get; set; }
        public ResultElement gost { get; set; }
        public ResultElement product_location { get; set; }
        public ResultElement terms_of_delivery { get; set; }
        public ResultElement date_of_delivery { get; set; }
        public ResultElement regularity_of_exhibiting { get; set; }
        public ResultElement deposit { get; set; }
        public ResultElement form_of_package { get; set; }
        public ResultElement currency { get; set; }
        public ResultElement special_condition { get; set; }
        public ResultElement broker_number { get; set; }
        public ResultElement type_of_contract { get; set; }
        public ResultElement size_per_month { get; set; }
        public ResultElement notification_for_user { get; set; }
        public ResultElement date_of_sending_notification { get; set; }
        public ResultElement reason_of_reject { get; set; }
        public ResultElement date_of_reject { get; set; }
        public ResultElement authority_id { get; set; }
        public ResultElement manufacturer_country { get; set; }
        public ResultElement legal_company_tin { get; set; }
        public ResultElement about_service { get; set; }
        public ResultElement docs_are_present { get; set; }
    }

    #endregion
}
