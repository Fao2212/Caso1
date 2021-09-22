namespace Caso1.Model{
    class MainDish{
        string code;
        string name;
        double price;
        ComponentType type;

        /*public MainDish(string code)
        {
            RestaurantJsonStructure data = new ComboDatabase().loadData();
            var allMainDish = data.MainDish;
            foreach(var mainDish in allMainDish)
            {
                if(code == mainDish.code)
                {
                    this.code = mainDish.code;
                    this.name = mainDish.name;
                    this.price = mainDish.price;
                    this.type = mainDish.type;
                    break;
                }
            }
        }*/

        public MainDish(string code, string name, double price, ComponentType type)
        {
            this.code = code;
            this.name = name;
            this.price = price;
            this.type = type;
        }

        public string toString()
        {
            string nombreAndPrecio = this.name + " (¢" + this.price + ")";
            return nombreAndPrecio;
        }

        public double getPrice()
        {
            return this.price;
        }

    }
}