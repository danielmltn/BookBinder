using System.Collections.Generic;

namespace AssociateManagement.Models.Organization
{
    public class OrgInfo
    {
        public string ManagerAssociateId { get; set; }
        public List<string> DirectReportAssociateIds { get; set; }
        public string Organization { get; set; }
    }
}