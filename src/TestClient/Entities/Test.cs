
using System;
using System.Collections.Generic;

namespace TestClient.Entities
{
    public class Test
    {
                public Test()
        {
                        CustomerResponses = new HashSet<CustomerResponse>();
                    }                public int Id {get;  set;}
                public string FirstName {get;  set;}
                public string LastName {get;  set;}
                public int CustomerId {get;  set;}
                            public Customer Customer {get; set;}
                                public ICollection<CustomerResponse> CustomerResponses {get; set;}
                }
}


