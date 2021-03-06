namespace Caso1.Model{


    public class MainDish : Component
    {
        public MainDish(string code, string name, double price) : base(code, name, price)
        {
            this.type = ComponentType.MainDish;
            this.quantity = quantity;   
        }

        public override MainDish clone()
        {
            return new MainDish(this.code, this.name, this.price);
        }

        public override MainDish deepClone()
        {
            return clone();
        }


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

    }
}