using DesignPattern.装饰器模式.咖啡店.咖啡;
using DesignPattern.装饰器模式.咖啡店.装饰器;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰器模式.咖啡店
{
    internal class BeverageBuilder
    {
        private Beverage beverage;
        private SizeType size;
        private List<SeasoningType> seasoningTypes = new List<SeasoningType>();

        public void SetBeverage(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public void SetSize(SizeType size) { this.size = size; }

        public void AddCondiment(SeasoningType condiment)
        {
            seasoningTypes.Add(condiment);
        }

        public Beverage Build()
        {
            Beverage result = beverage;
            if (result == null)
            {
                result = new DarkRoast();
            }

            switch(size)
            {
                case SizeType.Tall:
                    result = new Tall(result);
                    break;
                case SizeType.Grande:
                    result = new Grande(result);
                    break;
                case SizeType.Venti:
                    result = new Venti(result);
                    break;
            }

            foreach (var condiment in seasoningTypes)
            {
                switch (condiment)
                {
                    case SeasoningType.SteamedMilk:
                        result = new SteamedMilk(result);
                        break;
                    case SeasoningType.Mocha:
                        result = new Mocha(result);
                        break;
                    case SeasoningType.Soy:
                        result = new Soy(result);
                        break;
                    case SeasoningType.Whip:
                        result = new Whip(result);
                        break;
                }
            }
            return result;
        }
    }

    enum SizeType
    {
        Tall,
        Grande,
        Venti
    }

    enum SeasoningType
    {
        SteamedMilk,
        Mocha,
        Soy,
        Whip
    }
}
