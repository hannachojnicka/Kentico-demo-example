using System;
using System.Data;
using System.Runtime.Serialization;

using CMS;
using CMS.DataEngine;
using CMS.Helpers;
using CustomDataSynchronization;

[assembly: RegisterObjectType(typeof(HistoryOfScheduledTaskInfo), HistoryOfScheduledTaskInfo.OBJECT_TYPE)]

namespace CustomDataSynchronization
{
    /// <summary>
    /// Data container class for <see cref="HistoryOfScheduledTaskInfo"/>.
    /// </summary>
    [Serializable]
    public partial class HistoryOfScheduledTaskInfo : AbstractInfo<HistoryOfScheduledTaskInfo>
    {
        /// <summary>
        /// Object type.
        /// </summary>
        public const string OBJECT_TYPE = "customdatasynchronization.historyofscheduledtask";


        /// <summary>
        /// Type information.
        /// </summary>
#warning "You will need to configure the type info."
        public static readonly ObjectTypeInfo TYPEINFO = new ObjectTypeInfo(typeof(HistoryOfScheduledTaskInfoProvider), OBJECT_TYPE, "CustomDataSynchronization.HistoryOfScheduledTask", "HistoryOfScheduledTaskID", "HistoryOfScheduledTaskLastModified", "HistoryOfScheduledTaskGuid", null, null, null, null, null, null)
        {
            ModuleName = "CustomDataSynchronization",
            TouchCacheDependencies = true,
        };


        /// <summary>
        /// History of scheduled task ID.
        /// </summary>
        [DatabaseField]
        public virtual int HistoryOfScheduledTaskID
        {
            get
            {
                return ValidationHelper.GetInteger(GetValue("HistoryOfScheduledTaskID"), 0);
            }
            set
            {
                SetValue("HistoryOfScheduledTaskID", value);
            }
        }


        /// <summary>
        /// History of scheduled task guid.
        /// </summary>
        [DatabaseField]
        public virtual Guid HistoryOfScheduledTaskGuid
        {
            get
            {
                return ValidationHelper.GetGuid(GetValue("HistoryOfScheduledTaskGuid"), Guid.Empty);
            }
            set
            {
                SetValue("HistoryOfScheduledTaskGuid", value);
            }
        }


        /// <summary>
        /// History of scheduled task last modified.
        /// </summary>
        [DatabaseField]
        public virtual DateTime HistoryOfScheduledTaskLastModified
        {
            get
            {
                return ValidationHelper.GetDateTime(GetValue("HistoryOfScheduledTaskLastModified"), DateTimeHelper.ZERO_TIME);
            }
            set
            {
                SetValue("HistoryOfScheduledTaskLastModified", value);
            }
        }


        /// <summary>
        /// Task run time.
        /// </summary>
        [DatabaseField]
        public virtual DateTime TaskRunTime
        {
            get
            {
                return ValidationHelper.GetDateTime(GetValue("TaskRunTime"), DateTimeHelper.ZERO_TIME);
            }
            set
            {
                SetValue("TaskRunTime", value, DateTimeHelper.ZERO_TIME);
            }
        }


        /// <summary>
        /// I ds.
        /// </summary>
        [DatabaseField]
        public virtual string IDs
        {
            get
            {
                return ValidationHelper.GetString(GetValue("IDs"), String.Empty);
            }
            set
            {
                SetValue("IDs", value, String.Empty);
            }
        }


        /// <summary>
        /// Fail id I ds.
        /// </summary>
        [DatabaseField]
        public virtual string FailIdIDs
        {
            get
            {
                return ValidationHelper.GetString(GetValue("FailIdIDs"), String.Empty);
            }
            set
            {
                SetValue("FailIdIDs", value, String.Empty);
            }
        }


        /// <summary>
        /// Result.
        /// </summary>
        [DatabaseField]
        public virtual string Result
        {
            get
            {
                return ValidationHelper.GetString(GetValue("Result"), String.Empty);
            }
            set
            {
                SetValue("Result", value, String.Empty);
            }
        }


        /// <summary>
        /// Number of success I ds.
        /// </summary>
        [DatabaseField]
        public virtual int NumberOfSuccessIDs
        {
            get
            {
                return ValidationHelper.GetInteger(GetValue("NumberOfSuccessIDs"), 0);
            }
            set
            {
                SetValue("NumberOfSuccessIDs", value, 0);
            }
        }


        /// <summary>
        /// Last ID.
        /// </summary>
        [DatabaseField]
        public virtual int LastID
        {
            get
            {
                return ValidationHelper.GetInteger(GetValue("LastID"), 0);
            }
            set
            {
                SetValue("LastID", value, 0);
            }
        }


        /// <summary>
        /// Deletes the object using appropriate provider.
        /// </summary>
        protected override void DeleteObject()
        {
            HistoryOfScheduledTaskInfoProvider.DeleteHistoryOfScheduledTaskInfo(this);
        }


        /// <summary>
        /// Updates the object using appropriate provider.
        /// </summary>
        protected override void SetObject()
        {
            HistoryOfScheduledTaskInfoProvider.SetHistoryOfScheduledTaskInfo(this);
        }


        /// <summary>
        /// Constructor for de-serialization.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming context.</param>
        protected HistoryOfScheduledTaskInfo(SerializationInfo info, StreamingContext context)
            : base(info, context, TYPEINFO)
        {
        }


        /// <summary>
        /// Creates an empty instance of the <see cref="HistoryOfScheduledTaskInfo"/> class.
        /// </summary>
        public HistoryOfScheduledTaskInfo()
            : base(TYPEINFO)
        {
        }


        /// <summary>
        /// Creates a new instances of the <see cref="HistoryOfScheduledTaskInfo"/> class from the given <see cref="DataRow"/>.
        /// </summary>
        /// <param name="dr">DataRow with the object data.</param>
        public HistoryOfScheduledTaskInfo(DataRow dr)
            : base(TYPEINFO, dr)
        {
        }
    }
}