namespace Caso1.Model{
    public class Component:IPrototype<Component>{

        protected string code;
        protected string name;
        protected double price;
        protected int quantity;
        protected ComponentType type;

        public Component(string code,string name,double price){
            this.code = code;
            this.name = name;
            this.price = price;
            this.quantity = 1;
        }

        public Component(string code,string name,double price,ComponentType type){
            this.code = code;
            this.name = name;
            this.price = price;
            this.quantity = 1;
            this.type = type;
        }

        public void addQuantity(){
            this.quantity+=1;
        }

        public string getCode(){
            return this.code;
        }

        public ComponentType getType(){
            return this.type;
        }

        

        public string toString(){
            return "Nombre: "+this.name+" x"+this.quantity+"\tTotal: ₡"+this.price;
        }
        public Component clone(){
            return new Component(this.code,this.name,this.price,this.type);
        }
        public Component deepClone(){
            return clone();
        }
    }

}