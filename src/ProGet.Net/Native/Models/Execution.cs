// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class Execution
    {
        public int Execution_Id { get; set; }
        public string StartedOn_Date { get; set; }
        public string EndedOn_Date { get; set; }
        public int HighestLogMessage_Level { get; set; }
        public string InitiatedBy_User { get; set; }
    }
}
