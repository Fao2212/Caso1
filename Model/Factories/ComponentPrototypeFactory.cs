
using System.Collections.Generic;

namespace Caso1.Model.Factories{
    public class ComponentPrototypeFactory:IFactory<Component>{

        Dictionary<string,Component> components = new Dictionary<string,Component>();

        static ComponentPrototypeFactory(){
            
        }

        public Component get(string componentCode){
            return this.components[componentCode];
        }

        public void save(Component component){
            this.components.Add(component.getCode(),component);
        }
    }
}