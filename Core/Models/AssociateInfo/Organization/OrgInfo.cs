using System.Collections.Generic;

namespace BookBinderBE.Models.Organization
{
    public class OrgInfo
    {
        public string ManagerBookId { get; set; }
        public List<string> DirectReportBookIds { get; set; }
        public string Organization { get; set; }
    }
}