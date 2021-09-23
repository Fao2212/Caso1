namespace Caso1.Model{
    public class Drink:Component,IAddable{

        public Drink(string code,string name,double price):base(code,name,price){
            this.type = ComponentType.Drink;
        }
        public override Drink clone()
        {
            return new Drink(this.code, this.name, this.price);
        }

        public override Drink deepClone()
        {
            return clone();
        }
    }




}