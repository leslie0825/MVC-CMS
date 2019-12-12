using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace XMES.EquipmentDataHandler
{
    public class GlobalConstants
    {
        public static readonly string ServiceBuCode = ConfigurationManager.AppSettings["ServiceBuCode"] ?? "All";
    }
}
