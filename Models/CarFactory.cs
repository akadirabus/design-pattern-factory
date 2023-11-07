using DesignPatternFactory.Interfaces;

namespace DesignPatternFactory.Models
{
    public class CarFactory
    {
        public static ICar CreateCar(Brand brand, Car car)
        {
            return brand switch
            {
                Brand.MERCEDES => new Mercedes(car),
                Brand.BMW => new Bmw(car),
                Brand.VOLVO => new Volvo(car),
                _ => throw new NotImplementedException()
            };
        }
    }
}