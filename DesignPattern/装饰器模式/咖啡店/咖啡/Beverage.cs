namespace DesignPattern.装饰器模式.咖啡店.咖啡
{
    internal abstract class Beverage
    {
        public abstract string GetDescription();

        public abstract decimal Cost();
    }
}
