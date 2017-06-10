using System.Collections.Generic;

namespace ProGet.Net.Native.Models
{
    public class ExecutionsExecutionLogEntries
    {
        public List<Execution> Executions { get; set; }
        public List<ExecutionLogEntry> ExecutionLogEntries { get; set; }
    }
}
