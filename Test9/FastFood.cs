using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test9.Enum;

namespace Test9
{
    internal class FastFood
    {
        internal static List<FastFood> foods = new List<FastFood>();

        public FastFood( TimeOnly readyTime,int number, decimal unitPrice)
        {
            ReadyTime = readyTime;
            UnitPrice = unitPrice;
            Number = number;
        }

        public int Id { get; protected set; }
        public int Number { get; protected set; }
        public decimal UnitPrice { get; protected set; }
        public TimeOnly ReadyTime { get; protected set; }
        internal void SetId()
        {
            if (foods.Count > 0)
                Id = foods.Last().Id + 1;

            else Id = 1;
        }

        internal static void AddToList(FastFood fastFood)
        {
            foods.Add(fastFood);
        } 

        public virtual void ShowDetails()
        {
            Console.WriteLine($"its A Good FastFood");
        }
    }
    internal class Pizza : FastFood
    {
        public Pizza( TimeOnly readyTime, int number, decimal unitPrice, PizzaSize pizzaSize, PizzaModdel pizzaModdel, PizzaType pizzaType) : base( readyTime, number, unitPrice)
        {
            this.pizzaSize = pizzaSize;
            this.pizzaModdel = pizzaModdel;
            this.pizzaType = pizzaType;
        }

        public PizzaSize pizzaSize { get; set; }
        public PizzaModdel pizzaModdel { get; set; }
        public PizzaType pizzaType { get; set; }

        public override void ShowDetails()
        {
            Console.WriteLine($"Pizza=> Number:{Number} ReadyTime:{ReadyTime} UnitPrice:{UnitPrice} TotalPrice:{UnitPrice*Number} ");
            Console.WriteLine($"Size:{pizzaSize} Model:{pizzaModdel} Type:{pizzaType} ");
        }

    }
    internal class KentuckyChicken : FastFood
    {

        public KentuckyChicken( TimeOnly readyTime, int number, decimal unitPrice, KentuckyChickenType kentuckyChickenType, KentuckyChickenModel kentuckyChickenModel) : base( readyTime, number, unitPrice)
        {
            KentuckyChickenType = kentuckyChickenType;
            KentuckyChickenModel = kentuckyChickenModel;
        }
        public KentuckyChickenType KentuckyChickenType { get; set; }
        public KentuckyChickenModel KentuckyChickenModel { get; set; }
        public override void ShowDetails()
        {
            Console.WriteLine($"KentuckyChicken=> Number:{Number} ReadyTime:{ReadyTime} UnitPrice:{UnitPrice} TotalPrice:{UnitPrice * Number} ");
            Console.WriteLine($"Model:{KentuckyChickenModel} Type:{KentuckyChickenType} ");
        }

    }
    internal class HotDog : FastFood
    {
        public HotDog( TimeOnly readyTime, int number, decimal unitPrice, HotDogType hotDogType, HotDogModel hotDogModel) : base( readyTime,number, unitPrice)
        {
            HotDogType = hotDogType;
            HotDogModel = hotDogModel;
        }

        public HotDogType HotDogType { get; set; }
        public HotDogModel HotDogModel { get; set; }
        public override void ShowDetails()
        {
            Console.WriteLine($"HotDog=> Number:{Number} ReadyTime:{ReadyTime} UnitPrice:{UnitPrice} TotalPrice:{UnitPrice * Number} ");
            Console.WriteLine($"Model:{HotDogModel} Type:{HotDogType} ");
        }
    }
}
