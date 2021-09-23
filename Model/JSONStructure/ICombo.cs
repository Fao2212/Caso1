

using Caso1.Model;
using static Caso1.Model.Combo;

public interface ICombo{
    Combo agregar();
    ComboBuilder addComponent(IAddable component);


}