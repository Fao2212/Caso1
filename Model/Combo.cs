using System.Collections.Generic;

namespace Caso1.Model{

    class Combo:IPrototype<Combo>{

        string name;
        MainDish mainDish;
        Dictionary<string,List<Component>> components;

        public Combo(string name,Component mainDish,Dictionary<string,List<Component>> components){
            this.name = name;
            this.mainDish = mainDish;
            this.components = components;
        }

        //Clase comboBuidler va a ser usada por el factory para crear los nuevos combos
        public static class ComboBuilder:IBuilder<Combo>{

            static string name;
            static MainDish mainDish;
            static Dictionary<string,List<Component>> components;

            static ComboBuilder setName(string name){
                this.name = name;
                return this;
            }

            //Solo puede tener un plato principal y tiene que ser de tipo MainDish
            static ComboBuilder setMainDish(MainDish mainDish){
                this.name = name;
                return this;
            }

            public static Combo build(){
                return new Combo(this.name,this.mainDish,this.components);
            }
        }
        
        //TODO:Como va a presentarse el combo?
        public string toString(){
            return "";
        }
        public Combo clone(){
            return new Combo(this.name,this.mainDish,new Dictionary<string,List<Component>>());
        }

        //deepClone queda muy feo
        public Combo deepClone(){
            Dictionary<string,List<Component>> dictionaryClone = new Dictionary<string,List<Component>>();
            foreach (string key in this.components.Keys)
            {
                //Si se tienen que clonar los componentes porque si se modifica algun combo cambiaria todas las referencias no clonadas
                List<Component> componentsClone = new List<Component>();
                foreach (Component component in this.components[key])
                {
                    componentsClone.Add(component.clone());
                }
                dictionaryClone.Add(key,componentsClone);
            }
            return new Combo(this.name,this.mainDish,dictionaryClone);
        }

        //Agrega un componente al diccionario. Los componentes ya tienen su nombre. Esto para agregar a los ya existentes.
        void addComponent(Component component){
            
        }

        //Necesito funciones que me traigan de el diccionario de componentes el componente a buscar y la cantidad de estos.
    }

}