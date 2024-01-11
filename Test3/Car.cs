using Test3.ValueObject;

namespace Test3
{
    public abstract class Car
    {
        internal static List<Car> RentedCars = new List<Car>();
        internal static List<Car> BackedCars = new List<Car>();

        public Car(int customerId, string carName, decimal rentPriceDollar, TimeUnit timeUnit, int number, decimal guaranteePaymentDollar)
        {
            Guard(rentPriceDollar, guaranteePaymentDollar);
            CustomerId = customerId;
            CarName = carName;
            RentPricePerDollar = rentPriceDollar;
            Duration = new Duration(timeUnit, number);
            GuaranteePaymentDollar = guaranteePaymentDollar;
        }
        public int Id { get;protected set; }
        public int CustomerId { get; protected set; }
        public string CarName { get;protected  set; }
        public decimal RentPricePerDollar { get;protected  set; }
        public DateTime RentingStartTime { get;protected  set; } = DateTime.Now;
        public Duration Duration { get; protected set; }
        public decimal GuaranteePaymentDollar { get;protected  set; }
        public bool IsGetBacked { get;protected  set; } = false;

        public void SetId()
        {
            int rentId = 0;
            int backedId = 0;
            if (RentedCars.Count > 0)
            rentId= RentedCars.Last().Id;
            if (BackedCars.Count > 0)
                backedId = BackedCars.Last().Id;

             Id = Math.Max(rentId,backedId)+1;
        }
        public abstract void AddtoRentedCarList(Car car);
        public abstract void RentedCarDetails();
        public abstract void GetBackCar(Car car);
        protected void Guard(decimal rentPrice, decimal guaranteePayment)
        {
            if (rentPrice <= 0 || guaranteePayment <= 0)
            {
                throw new Exception("Salary cant be less than zero");
            }
        }
    }
}
