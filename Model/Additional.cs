namespace Caso1.Model{
    public class Additional:Component,IAddable{

        public Additional(string code,string name,double price):base(code,name,price){
            this.type = ComponentType.Additional;
        }
    }


}