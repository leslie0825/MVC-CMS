using FluentScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMES.EquipmentDataHandler.Jobs
{
    /// <summary>
    /// 带身份识别的IJob接口
    /// </summary>
    public interface IJobWithIdentity : IJob
    {
        /// <summary>
        /// Job名字
        /// </summary>
        string JobName { get; }

        /// <summary>
        /// Jod的Id：如橱柜10；家具20；木门30
        /// </summary>
        string JobId { get; }
    }

    internal class JobIds
    {
        /// <summary>
        /// 设备加工数据处理（更改任务单工序完工状态）Id
        /// </summary>
        public const string JobId_JobOperationHandle = "10";


    }
}
