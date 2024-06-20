namespace Customer
{
    public class Customer1 { 
        private int Id { get; set; }
        private string custName { get; set; }
        private string city { get; set; }

        public Customer1()
        {
            Console.WriteLine("Im default cunstructor");
        }
        public Customer1(int Id, string custName, string city)
        {
            this.Id = Id;
            this.custName = custName;
            this.city = city;
        }

    }
}
