using System;
using System.Collections.Generic;

namespace pis.data.automation.entities
{
    public partial class TaskSchedule
    {
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public string TaskTitle { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? TaskReminder { get; set; }
        public short? ReminderDuration { get; set; }
        public DateTime LastReminderTime { get; set; }
        public bool? IsSession { get; set; }
        public short Priority { get; set; }
        public bool? IsPrivate { get; set; }
        public bool? IsPriodical { get; set; }
        public short? PriodFlag { get; set; }
        public short? RepeatTime { get; set; }
        public short Duration { get; set; }
    }
}
