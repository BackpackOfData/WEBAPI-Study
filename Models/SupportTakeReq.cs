namespace techSupport.Model
{
    public enum Status
    {
        Take, Cancel, Complete, NotComplete
    }
    // supporters can take one req but all need to complete or cancel req;
    public class SupportTakeReq : BaseClass
    {
        public int SupportReqID { get; set; }
        public Status? ReqStatus { get; set; }
        public int SupporterPresonID { get; set; }
        public SupportReq SupportReq { get; set; }
    }
}
