namespace Caso1.Model.Factories{
    public interface IFactory<T>
    {
        T get(string id);
        //void save(T object);
    }
}