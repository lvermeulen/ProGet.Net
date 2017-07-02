using System;

// ReSharper disable InconsistentNaming

namespace ProGet.Net.Native.Models
{
    public class EventOccurrence
    {
        public int EventOccurrence_Id { get; set; }
        public string Event_Code { get; set; }
        public string User_Name { get; set; }
        public DateTime Occurrence_Date { get; set; }
        public int? Feed_Id { get; set; }
        public string Details_Xml { get; set; }
    }
}
