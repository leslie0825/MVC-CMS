using FluentScheduler;
using System;
using System.Configuration;
using XMES.Ultity;

namespace XMES.EquipmentDataHandler
{
    internal class MainJobService
    {
        private string ServiceName = "";

        public MainJobService()
        {
            ServiceName = ConfigurationManager.AppSettings["ServiceName"];
        }

        /// <summary>
        /// 服务启动
        /// </summary>
        public void Start()
        {
            try
            {
                AppLogger.Default.Info(ServiceName,ServiceName + "服务开始启动...");
                JobManager.Initialize(new JobRegistry());
                AppLogger.Default.Info(ServiceName, ServiceName + "服务启动成功！ ");
            }
            catch (Exception ex)
            {
                AppLogger.Default.Error(ServiceName, ServiceName + "服务启动失败：", ex);
            }
        }

        /// <summary>
        /// 服务停止
        /// </summary>
        public void Stop()
        {
            try
            {
                AppLogger.Default.Info(ServiceName, ServiceName + "服务开始停止...");
                JobManager.StopAndBlock();
            }
            catch (Exception ex)
            {
                AppLogger.Default.Error(ServiceName, ServiceName + "服务停止异常：", ex);
            }
            AppLogger.Default.Info(ServiceName, ServiceName + "服务已停止！");
        }
    }
}
