using System;

namespace Nugu.BL
{
    public class Subscription
    {
        public Subscription() 
        {
        }

        public string CompanyId { get; set; }
        public string ServiceId { get; set; }
        public DateTime StartdDate { get; set; }
        public int StatusCd { get; set; }
    }
}
