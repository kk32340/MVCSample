namespace MVCSample.Models
{
      

    public class Customer
    {
        public string name { get; set; }
        public string phone { get; set; }
        public List<Address> CustAddresses { get; set; }
        public List<AKA> CustAKA { get; set; }
        public List<Notes> CustNotes { get; set; }
    }


    public class Address
    {

        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public string country { get; set; }
           
    }

    public class AKA
    {
        public int id { get; set; }
        public string name { set; get; }
        public string phone { set; get; }

    }

    public class Notes
    {
        public string notes { get; set; }
        public string comment { set; get; }

    }

}
