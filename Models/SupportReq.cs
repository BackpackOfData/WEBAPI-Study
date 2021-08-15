using System;
using System.Collections.Generic;

namespace techSupport.Model
{
    public class BaseClass
    {
        public int ID { get; set; }
    }
    public class SupportReq : BaseClass
    {
        private DateTime? dateCreated = null;
        private DateTime createDate;
        public string Message { get; set; }
        public int FromWhoID { get; set; }
        public DateTime DateCreate { get; set; }
        
        public DateTime DateExpired { get; set; }
        public virtual ICollection<SupportTakeReq> SupportTakeReqs { get; set; }
    }

}
