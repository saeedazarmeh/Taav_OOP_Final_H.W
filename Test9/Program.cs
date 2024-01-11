using Test9;
using Test9.Enum;
while (true)
{
    Console.WriteLine("Choose your Operation Index:\n" +
    "1-Add Pizza\n" +
     "2-Add HotDog\n" +
     "3-Add KentuckyChicken\n" +
     "4-Finalize Order \n" +
     "5-Show Orders\n \n" +
     "6-Set Order Served\n");
    var choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            {
                Console.WriteLine("Enter Number");
                var number = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter uniPrice");
                var uniPrice = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter ReadyTime");
                var readyTime = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter Pizza Size: 1-Mini 2-Medium 3-Big");
                Enum.TryParse(Console.ReadLine(), out PizzaSize pizzaSize);
                Console.WriteLine("Enter Pizza Model: 1-American 2-Italian");
                Enum.TryParse(Console.ReadLine(), out PizzaModdel pizzaModdel);
                Console.WriteLine("Enter Pizza Type: 1-Mini 2-Medium 3-Big");
                Enum.TryParse(Console.ReadLine(), out PizzaType pizzaType);
                var food = new Pizza(readyTime, number, uniPrice, pizzaSize, pizzaModdel, pizzaType);
                FastFood.AddToList(food);
            }
            break;
        case 2:
            {
                Console.WriteLine("Enter Number");
                var number = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter uniPrice");
                var uniPrice = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter ReadyTime");
                var readyTime = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter HotDog Model: 1-Spicy 2-Normal");
                Enum.TryParse(Console.ReadLine(), out HotDogModel hotDogModel);
                Console.WriteLine("Enter HotDog Type: 1-OvenMeet 2-Meet 3-OvenSausage 4-Sausage");
                Enum.TryParse(Console.ReadLine(), out HotDogType hotDogType);
                var food = new HotDog(readyTime, number, uniPrice, hotDogType, hotDogModel);
                FastFood.AddToList(food);
            }
            break;
        case 3:
            {
                Console.WriteLine("Enter Number");
                var number = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter uniPrice");
                var uniPrice = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter ReadyTime");
                var readyTime = TimeOnly.Parse(Console.ReadLine());
                Console.WriteLine("Enter KentuckyChicken Model: 1-Spicy 2-Normal");
                Enum.TryParse(Console.ReadLine(), out KentuckyChickenModel kentuckyChickenModel);
                Console.WriteLine("Enter KentuckyChicken Type: 1-3Pieces 2-4Pieces 3-CrispyChicken 4-Stripce");
                Enum.TryParse(Console.ReadLine(), out KentuckyChickenType kentuckyChickenType);
                var food = new KentuckyChicken(readyTime, number, uniPrice, kentuckyChickenType, kentuckyChickenModel);
                FastFood.AddToList(food);
            }
            break;
        case 4:
            {
                Order.FinalizeOrder();
            }
            break;
        case 5:
            {
                Order.ShowOrders();
            }
            break;
        case 6:
            {
                Console.WriteLine("Enter OrderId");
                var orderId = int.Parse(Console.ReadLine());
                var order = Order.Orders.FirstOrDefault(o => o.Id == orderId);
                order.SetServed();
            }
            break;
    }
}

