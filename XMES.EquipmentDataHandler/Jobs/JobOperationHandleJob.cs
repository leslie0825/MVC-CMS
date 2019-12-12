using System;
using System.Threading;
using XMES.Ultity;

namespace XMES.EquipmentDataHandler.Jobs
{
    /// <summary>
    /// 设备加工数据处理（更改任务单工序完工状态）Job
    /// </summary>
    /// <remarks>
    /// 1.包含合同和订单数据
    /// 2.通过WebApi调用
    /// </remarks>
    public class JobOperationHandleJob : IJobWithIdentity
    {
        public string JobId
        {
            get
            {
                return JobIds.JobId_JobOperationHandle;
            }
        }

        public string JobName
        {
            get
            {
                return "根据项目机设备加工数据更改任务单工序完工状态Job";
            }
        }

        /// <summary>
        /// 导入家具订单和合同数据
        /// </summary>
        public void Execute()
        {
            try
            {
                var now = DateTime.Now.ToString();
                for (int i = 1; i <= 5; i++)
                {
                    AppLogger.Default.Info(now, "我是：" + i);
                    Thread.Sleep(4000);
                }

                Thread.Sleep(10000);
                ////ImportFurnitureOrderBLL bll = new ImportFurnitureOrderBLL();
                ////bll.ImportFurnitureContractForServices();
            }
            catch (Exception ex)
            {
                AppLogger.Default.Error(this.JobName, string.Format("{0}运行异常：", this.JobName), ex);
            }
        }        

    }
}
