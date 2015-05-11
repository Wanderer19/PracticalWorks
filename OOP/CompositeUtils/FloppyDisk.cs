using System;

namespace OOP.CompositeUtils
{
    public  class FloppyDisk:Equipment // наследуем от родительского класса, то есть нам доступны все его методы и свойства
    {
        private readonly string name;
        private readonly decimal netPrice;
        private readonly decimal discountPrice;

        // переопределяем виртуальное свойство класса - родителя
        public override string Name
        {
            get { return name; }
        }

        // переопределяем виртуальное свойство класса - родителя
        public override decimal DiscountPrice
        {
            get { return discountPrice; }
        }

        // переопределяем виртуальное свойство класса - родителя
        public override decimal NetPrice
        {
            get { return netPrice; }
        }

        public FloppyDisk(string name, Decimal netPrice, Decimal discountPrice)
        {
            this.name = name;
            this.netPrice = netPrice;
            this.discountPrice = discountPrice;
        }
    }
}
