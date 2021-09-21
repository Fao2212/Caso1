namespace Caso1.Model{
    public class Drink:Component,IAddable{

        public Drink(string code,string name,double price):base(code,name,price){
            this.type = ComponentType.Drink;
        }
    }

    
}