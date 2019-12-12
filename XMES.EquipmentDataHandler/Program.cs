using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace XMES.EquipmentDataHandler
{
    public class Program
    {
        static void Main(string[] args)
        {
            //MJH1234
            //ImportFurnitureOrderBLL src = new ImportFurnitureOrderBLL();
            //src.ImportFurnitureContractForServices();
            HostFactory.Run(x =>
            {
                x.Service<MainJobService>(s =>
                {
                    s.ConstructUsing(name => new MainJobService());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });
                x.RunAsLocalSystem();

                x.SetServiceName(ConfigurationManager.AppSettings["ServiceName"]);
                x.SetDisplayName(ConfigurationManager.AppSettings["DisplayName"]);
                x.SetDescription(ConfigurationManager.AppSettings["Description"]);

            });
        }
    }
}
