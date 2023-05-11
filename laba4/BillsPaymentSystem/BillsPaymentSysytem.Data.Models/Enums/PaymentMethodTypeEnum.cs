using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BillsPaymentSysytem.Data.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PaymentMethodType
    {
        BankAccount = 0,

        CreditCard = 1,
    }
}
