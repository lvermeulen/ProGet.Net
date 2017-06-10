// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class ExecutionLogEntry
    {
        public int Execution_Id { get; set; }
        public int LogMessage_Sequence { get; set; }
        public int LogMessage_Level { get; set; }
        public string LogMessage_Text { get; set; }
    }
}
