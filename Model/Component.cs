namespace Caso1.Model{
    class Component:IPrototype<Component>{

        int code;
        string name;
        double price;
        int quantity;
        ComponentType type;

        public string toString(){
            return "";
        }
        public Component clone(){

        }
        public Component deepClone(){

        }
    }

}