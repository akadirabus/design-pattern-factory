using DesignPatternFactory.Interfaces;

namespace DesignPatternFactory.Models
{
    public class Mercedes : ICar
    {
        private readonly string _color;
        private readonly double _price;

        public Mercedes(Car car)
        {
            _color = car.Color;
            _price = car.Price;
        }

        public string GetColor()
        {
            return _color;
        }
        public double GetPrice()
        {
            return _price;
        }
        public string GetInfo() => $"{_color} renkli Mercedes aracın mağaza satış fiyatı: {_price}TL'dir.";
    }
}