using System;

// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class ScheduledTasksExtended
    {
        public int ScheduledTask_Id { get; set; }
        public string ScheduledTaskType_Code { get; set; }
        public int? Feed_Id { get; set; }
        public string Feed_Name { get; set; }
        public string FeedType_Name { get; set; }
        public int? Connector_Id { get; set; }
        public string Connector_Url { get; set; }
        public string Connector_Name { get; set; }
        public string Connector_FeedType_Name { get; set; }
        public int? Frequency_Hours { get; set; }
        public int StartTimeOfDay_Minutes { get; set; }
        public int EndTimeOfDay_Minutes { get; set; }
        public bool Active_Indicator { get; set; }
        public bool? Feed_Active_Indicator { get; set; }
        public string RunImmediately_User { get; set; }
        public bool Running_Indicator { get; set; }
        public int? LastExecution_Id { get; set; }
        public DateTime? LastStart_Date { get; set; }
    }
}
