namespace Caso1.Model{

    public class MainDish:Component{

        public MainDish(string code,string name,double price):base(code,name,price){
            this.type = ComponentType.MainDish;
        }
    }

    
}