using FluentScheduler;
using XMES.EquipmentDataHandler.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace XMES.EquipmentDataHandler
{
    /// <summary>
    /// Job注册类
    /// </summary>
    public class JobRegistry: Registry
    {
        public JobRegistry()
        {
            this.RegisterJobs();
        }

        /// <summary>
        /// 注册Job
        /// </summary>
        private void RegisterJobs()
        {
            //防止并发执行任务
            NonReentrantAsDefault();
            List<IJobWithIdentity> jobs = new List<IJobWithIdentity>
            {

                new JobOperationHandleJob()  //设备加工数据处理（更改任务单工序完工状态）

                //////new ImportCabinetOrderJob(),    //导入橱柜订单 10 ljbin
                //////new ImportFurnitureOrderJob(),  //导入家具订单 20
                //////new ImportBathroomOrderJob(),  //导入卫浴订单 40
                //////new ImportBathroomFileJob(),   //导入卫浴文件 50
                //////new UpdateInsightStatusJob(), //卫浴状态反馈 60
                //////new UpdateZYTotObjectJob(), //更新造易标准件数据 100 （现已取消运行）
                //////new UpdateTableTaskJob(), //更新橱柜台面任务单 110 ljbin
                //////new ZYPartModifyJob(),  //造易订单板件定损接口任务 120
                //////new CabinetScheduleFeedbackJob(), //橱柜AP排产产地/车间反馈 130 ljbin
                //////new RetryImportOrderToASJob(), //旧系统排产异常订单重新接入AS系统 140
                //////new ImportCabinetDealersJob(), //导入橱柜商场信息 150
                //////new ImportFurnitureDealersJob(), //导入家具商场信息 160
                //////new TableTaskDeliverMesJob(), //橱柜台面任务单下发MES 170 ljbin
                //////new ImportCabinetOrderStatusJob(), //橱柜导入加急/取消/修改交期等Job 180 
                //////new UpdateBodyProcessJob(), //更新家具进仓确认 210 ljbin
                //////new SyncStdPartFromZoweeToMesJob(), //造易标准件同步MES 220
                //////new ImportWoodDoorOrderJob() //导入木门旧系统订单 230
            };

            jobs.ForEach(x =>
            {
                Schedule(x).ToRunEvery(5).Seconds();
            });
            //////List<string> jobIds = GlobalConstants.ServiceBuCode.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            //////jobs.ForEach(x =>
            //////{
            //////    if (jobIds.Contains(x.JobId))
            //////    {
            //////        if (x.JobId == JobIds.JobId_ImportFurnitureDealers || x.JobId == JobIds.JobId_ImportDoorDealers 
            //////        || x.JobId == JobIds.JobId_ImportCabinetDealers || x.JobId == JobIds.JobId_ImportBathroomDealers)
            //////        {
            //////            Schedule(x).ToRunEvery(1).Days();
            //////        }
            //////        else
            //////        {
            //////            Schedule(x).ToRunEvery(5).Seconds();
            //////        }

            //////    }
            //////});


        }
    }
}
