namespace CsharpLibrary.DesignPattern.Factory
{

    /// <summary>
    /// 抽象工厂方法用于管理一组相关的产品 （产品直接由依赖或者关联的）
    /// 举个例子（各种牌子的汽车生产，不同型号的电脑）
    /// </summary>
    public class AbstractFactory : IAbstractFactory
    {
        public IAbstractProduct GetProduct()
        {
            IAbstractProduct product = new AbstractProduct();
            return product;
        }

        public IAbstractProduct2 GetProduct2()
        {
            IAbstractProduct2 product2 = new AbstractProduct2();
            return product2;
        }
    }
}
