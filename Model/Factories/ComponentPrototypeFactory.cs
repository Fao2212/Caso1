
using System.Collections.Generic;

namespace Caso1.Model.Factories{
    public class ComponentPrototypeFactory:IFactory<Component>{

        static Dictionary<string,Component> components = new Dictionary<string,Component>();

        static ComponentPrototypeFactory(){
            
        }

        public Component get(string componentCode){
            return ComponentPrototypeFactory.components[componentCode].deepClone();
        }

        public void save(Component component){
            ComponentPrototypeFactory.components.Add(component.getCode(),component);
        }
    }
}