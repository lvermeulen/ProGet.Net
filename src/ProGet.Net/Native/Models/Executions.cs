using System;

// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class Executions
    {
        public int Execution_Id { get; set; }
        public DateTime StartedOn_Date { get; set; }
        public DateTime? EndedOn_Date { get; set; }
        public int? HighestLogMessage_Level { get; set; }
        public string InitiatedBy_User { get; set; }
    }
}
