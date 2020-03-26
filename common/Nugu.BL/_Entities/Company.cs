using System;

namespace Nugu.BL
{
    public class Company
    {
        public Company()
        {
        }

        public Guid Id { get; set; }
        public string Name { get; set; }   
        public DateTime CreatedDate { get; set; }
    }
}
