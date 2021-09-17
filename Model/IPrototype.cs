namespace Caso1.Model{
    interface IPrototype<T>{
        T clone();
        T deepClone();
    }
}