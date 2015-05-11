namespace OOP.CompositeUtils
{
    //абстрактный класс, чьи экземпляры нельзя создавать, от него можно только наследовать
    public abstract class Equipment
    {
        public abstract string Name { get; }
        public abstract decimal NetPrice { get; }
        public abstract decimal DiscountPrice { get; }

        public virtual void Add(Equipment equipment)
        {
            
        }

        public virtual void Remove(Equipment equipment)
        {
            
        }
    }
}
