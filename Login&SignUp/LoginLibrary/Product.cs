namespace LoginLibrary
{
    public class Product

    {
        private int _prodId;
        private string _name;
        private int _price;

        public int ProductId {
            get { return _prodId; }
            set {  _prodId = value; }
        }
        public string ProductName {
            get { return _name; }
            set {  _name = value; }
        }

        public int Price {
            get { return _price; }
            set {  _price = value; }
        }

    }
}
