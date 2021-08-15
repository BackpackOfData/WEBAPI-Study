using another_test.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techSupport.Model;

namespace another_test
{
    public class SupportReqReposit
    {
        private readonly another_testContext _context;
        public SupportReqReposit(another_testContext context) 
        {
            _context = context;
        }
        public IEnumerable<SupportReq> GetRequests() // список всех реквестов 
        {
            IEnumerable<SupportReq> result = _context.SupportReq.ToList();
            return result;
        }
        public SupportReq GetRequestByID(int id)  // это выборка реквеста
        {
            SupportReq result = _context.SupportReq.FirstOrDefault(row => row.ID == id);
            return result;
        }
        public IEnumerable<SupportReq> GetRquestByMessage(string likemsg) 
        {
            IEnumerable<SupportReq> result = _context.SupportReq.Where(row=> row.Message.Contains(likemsg));
            return result;
        }
        public void InsertIntoSupportReqTab(SupportReq creckedValidReq)
        {
            _context.Add(creckedValidReq);
            _context.SaveChanges();
        }
    }
}
