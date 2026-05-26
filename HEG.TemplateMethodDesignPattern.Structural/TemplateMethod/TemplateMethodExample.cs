namespace HEG.TemplateMethodDesignPattern.Structural.TemplateMethod
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Hook();
        }

        protected abstract void PrimitiveOperation1();
        protected abstract void PrimitiveOperation2();
        protected virtual void Hook()
        {
        }
    }

    public class ConcreteClass1 : AbstractClass
    {
        protected override void PrimitiveOperation1() => Console.WriteLine("ConcreteClass1.PrimitiveOperation1");
        protected override void PrimitiveOperation2() => Console.WriteLine("ConcreteClass1.PrimitiveOperation2");
    }

    public class ConcreteClass2 : AbstractClass
    {
        protected override void PrimitiveOperation1() => Console.WriteLine("ConcreteClass2.PrimitiveOperation1");
        protected override void PrimitiveOperation2() => Console.WriteLine("ConcreteClass2.PrimitiveOperation2");
        protected override void Hook() => Console.WriteLine("ConcreteClass2.Hook");
    }
}
