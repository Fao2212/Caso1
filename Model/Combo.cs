using System.Collections.Generic;
using Caso1.Model.Factories;

namespace Caso1.Model{

    public class Combo:IPrototype<Combo>{

        string name;
        MainDish mainDish;
        Dictionary<string,Component> components;

        public Combo(string name,MainDish mainDish,Dictionary<string,Component> components){
            this.name = name;
            this.mainDish = mainDish;
            this.components = components;
        }

        public Combo(string name, MainDish mainDish, List<string> componentCodes)
        {
            this.name = name;
            this.mainDish = mainDish;
            this.components = new Dictionary<string, Component>();
            foreach (var code in componentCodes)
            {
                addComponent((IAddable)new ComponentPrototypeFactory().get(code));
            }
        }

        //Clase comboBuidler va a ser usada por el factory para crear los nuevos combos
        public class ComboBuilder:IBuilder<Combo>{

            string name;
            MainDish mainDish;
            Dictionary<string,Component> components = new Dictionary<string,Component>();

            ComboBuilder setName(string name){
                this.name = name;
                return this;
            }

            //Solo puede tener un plato principal y tiene que ser de tipo MainDish
            ComboBuilder setMainDish(MainDish mainDish){
                this.mainDish = mainDish;
                return this;
            }

            ComboBuilder addComponent(IAddable component){
                Component savedComponent;
                if (this.components.TryGetValue(component.getCode(), out savedComponent))
                {
                    savedComponent.addQuantity();
                }
                else
                {
                    this.components.Add(component.getCode(), new ComponentPrototypeFactory().get(component.getCode()));
                }
                return this;
            }

            public Combo build(){
                return new Combo(this.name,this.mainDish,this.components);
            }
        }

        public Combo clone(){
            return new Combo(this.name,this.mainDish,new Dictionary<string,Component>());
        }

        public Combo deepClone(){
            Dictionary<string,Component> dictionaryClone = new Dictionary<string,Component>();
            foreach (KeyValuePair<string, Component> component in this.components)
            {
                dictionaryClone.Add(component.Key,component.Value.clone());
            }
            return new Combo(this.name,this.mainDish,dictionaryClone);
        }

        public void addComponent(IAddable component){
            Component savedComponent;
            if(this.components.TryGetValue(component.getCode(),out savedComponent)){
                savedComponent.addQuantity();}
            else{
                this.components.Add(component.getCode(),new ComponentPrototypeFactory().get(component.getCode()));
            }
        }

        //Necesito funciones que me traigan de el diccionario de componentes el componente a buscar y la cantidad de estos.
        List<Component> getDrinks(){
            List<Component> drinks = new List<Component>();
            foreach (Component component in this.components.Values)
            {
                if(component.getType()==ComponentType.Drink)drinks.Add(component);
            }
            return drinks;
        }
        List<Component> getAdditionals(){
            List<Component> additionals = new List<Component>();
            foreach (Component component in this.components.Values)
            {
                if(component.getType()==ComponentType.Additional)additionals.Add(component);
            }
            return additionals;
        }

        string showDrinks(){
            string drinksString = "Drinks:\n";
            foreach (Component component in getDrinks())
            {
                drinksString += "\t"+component.toString();
            }
            return drinksString;
        }
        string showAdditionals(){
            string additionalString = "Additionals:\n";
            foreach (Component component in getAdditionals())
            {
                additionalString += "\t"+component.toString();
            }
            return additionalString;
        }

        public string toString(){
            string comboString = "Combo: "+this.name+"\n";
            comboString+="Main Dish: "+ this.mainDish.toString();
            comboString+="\t"+showDrinks()+"\n";
            comboString+="\t"+showAdditionals()+"\n";
            return comboString;
        }
    }

}