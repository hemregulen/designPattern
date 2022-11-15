using HEG.AbstractFactoryDesignPattern.Structural.AbstractFactory.AbstractProduct;
using HEG.AbstractFactoryDesignPattern.Structural.AbstractFactory.AbstractProduct.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.AbstractFactoryDesignPattern.Structural.AbstractFactory.ConcreteFactory
{
    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
