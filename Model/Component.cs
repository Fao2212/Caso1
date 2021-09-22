namespace Caso1.Model{
    class Component:IPrototype<Component>{

        string code;
        string name;
        double price;
        int quantity;
        ComponentType type;

        

        public Component(string code,string name,double price,int quantity,ComponentType type){
            this.code = code;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.type = type;
        }

        public string toString(){
            return this.name;
        }

        public string getName()
        {
            return this.name;
        }

        public double getPrice()
        {
            return this.price;
        }

        public Component clone(){
            return new Component(this.code,this.name,this.price,this.quantity,this.type);
        }
        public Component deepClone(){
            return clone();
        }

    }

}