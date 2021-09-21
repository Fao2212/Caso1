namespace Caso1.Model{
    public interface IPrototype<T>{
        T clone();
        T deepClone();
    }
}