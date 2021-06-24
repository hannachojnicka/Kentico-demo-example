using System;
using System.Data;

using CMS.Base;
using CMS.DataEngine;
using CMS.Helpers;

namespace CustomDataSynchronization
{
    /// <summary>
    /// Class providing <see cref="HistoryOfScheduledTaskInfo"/> management.
    /// </summary>
    public partial class HistoryOfScheduledTaskInfoProvider : AbstractInfoProvider<HistoryOfScheduledTaskInfo, HistoryOfScheduledTaskInfoProvider>
    {
        /// <summary>
        /// Creates an instance of <see cref="HistoryOfScheduledTaskInfoProvider"/>.
        /// </summary>
        public HistoryOfScheduledTaskInfoProvider()
            : base(HistoryOfScheduledTaskInfo.TYPEINFO)
        {
        }


        /// <summary>
        /// Returns a query for all the <see cref="HistoryOfScheduledTaskInfo"/> objects.
        /// </summary>
        public static ObjectQuery<HistoryOfScheduledTaskInfo> GetHistoryOfScheduledTasks()
        {
            return ProviderObject.GetObjectQuery();
        }


        /// <summary>
        /// Returns <see cref="HistoryOfScheduledTaskInfo"/> with specified ID.
        /// </summary>
        /// <param name="id"><see cref="HistoryOfScheduledTaskInfo"/> ID.</param>
        public static HistoryOfScheduledTaskInfo GetHistoryOfScheduledTaskInfo(int id)
        {
            return ProviderObject.GetInfoById(id);
        }


        /// <summary>
        /// Sets (updates or inserts) specified <see cref="HistoryOfScheduledTaskInfo"/>.
        /// </summary>
        /// <param name="infoObj"><see cref="HistoryOfScheduledTaskInfo"/> to be set.</param>
        public static void SetHistoryOfScheduledTaskInfo(HistoryOfScheduledTaskInfo infoObj)
        {
            ProviderObject.SetInfo(infoObj);
        }


        /// <summary>
        /// Deletes specified <see cref="HistoryOfScheduledTaskInfo"/>.
        /// </summary>
        /// <param name="infoObj"><see cref="HistoryOfScheduledTaskInfo"/> to be deleted.</param>
        public static void DeleteHistoryOfScheduledTaskInfo(HistoryOfScheduledTaskInfo infoObj)
        {
            ProviderObject.DeleteInfo(infoObj);
        }


        /// <summary>
        /// Deletes <see cref="HistoryOfScheduledTaskInfo"/> with specified ID.
        /// </summary>
        /// <param name="id"><see cref="HistoryOfScheduledTaskInfo"/> ID.</param>
        public static void DeleteHistoryOfScheduledTaskInfo(int id)
        {
            HistoryOfScheduledTaskInfo infoObj = GetHistoryOfScheduledTaskInfo(id);
            DeleteHistoryOfScheduledTaskInfo(infoObj);
        }
    }
}