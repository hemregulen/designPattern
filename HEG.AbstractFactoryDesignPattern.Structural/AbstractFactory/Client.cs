using HEG.AbstractFactoryDesignPattern.Structural.AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEG.AbstractFactoryDesignPattern.Structural.AbstractFactory
{
    public class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;
        // Constructor
        public Client(AbstractFactory factory)
        {
            _abstractProductB = factory.CreateProductB();
            _abstractProductA = factory.CreateProductA();
        }
        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}
