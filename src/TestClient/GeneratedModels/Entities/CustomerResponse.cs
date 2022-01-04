using System.Collections.Generic;

namespace TestClient.Entities
{
    public class CustomerResponse
    {
        public ICollection<Test> Tests { get; set; }
    }
}