using System.Collections.Generic;
using System.Linq;
using OOP.Solutions.CompositeUtils;

namespace OOP.CompositeUtils
{
    public abstract class CompositeEquipment:Equipment
    {
        private readonly List<Equipment> equipments = new List<Equipment>();
        protected decimal netPrice;
        protected decimal discountPrice; // модификатор доступа protected указывае на то, что это поле "видно" в этом классе и во всех наследниках, но не видно остальным

        // переопределяем виртуальное свойство класса - родителя
        public override decimal DiscountPrice
        {
            get { return equipments.Sum(e => e.DiscountPrice) + discountPrice; }
        }

        // переопределяем виртуальное свойство класса - родителя
        public override decimal NetPrice
        {
            get
            {
                return equipments.Sum(e => e.NetPrice) + netPrice;
            }
        }
        // переопределяем виртуальный метод класса - родителя
        public override void Add(Equipment equipment)
        {
            equipments.Add(equipment);
        
        }

        // переопределяем виртуальный метод класса - родителя
        public override void Remove(Equipment equipment)
        {
            equipments.Remove(equipment);
        }
    }
}
