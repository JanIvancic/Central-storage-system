using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralStorageSystem.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Orderer { get; set; }
        public string FundingSource { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string TimeOfReceipt { get; set; }
        public string StoredBy { get; set; }
        public string ProjectName { get; set; }
    }
}
