using System;
namespace EntityFrameWork
{
    public class Customer
    {
        private int id_oder;
        private int id_customer;
        private string name;

        public int Id_oder {
            get { return id_oder; }
            set { id_oder = value; }
        }
        public int Id_customer {
            get { return id_customer; }
            set { id_customer = value; }
        }
        public string Name {
            get {return name; }
            set { name = value; }
        }

        public Customer()
        {

        }
    }
}
