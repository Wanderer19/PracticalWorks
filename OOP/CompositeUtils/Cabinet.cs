using System;

namespace OOP.CompositeUtils
{
    public sealed class Cabinet : CompositeEquipment // наследуем от родительского класса, то есть нам доступны все его методы и свойства
    {
        private readonly string name;

        // переопределяем виртуальное свойство класса - родителя
        public override string Name
        {
            get { return name; }
        }

        public Cabinet(string name, Decimal netPrice, Decimal discountPrice)
        {
            this.name = name;
            this.netPrice = netPrice;
            this.discountPrice = discountPrice;
        }
    }
}
