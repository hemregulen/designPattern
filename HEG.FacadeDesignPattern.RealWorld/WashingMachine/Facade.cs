using HEG.FacadeDesignPattern.RealWorld.WashingMachine.SubSystem;

namespace HEG.FacadeDesignPattern.RealWorld.WashingMachine
{
    public class Facade
    {
        private readonly RinsingSystem rinsingSystem;
        private readonly SpinningSystem spinningSystem;
        private readonly WashingSystem washingSystem;
        public Facade()
        {
            rinsingSystem = new RinsingSystem();
            spinningSystem = new SpinningSystem();
            washingSystem = new WashingSystem();
        }
        public void Colors(int weight)
        {
            Console.WriteLine("Makine kontrol ediliyor.");
            var rissing = rinsingSystem.RinsingSystemControl(weight);
            var spinning = spinningSystem.SpinningSystemControl(weight);
            var washing = washingSystem.WashingSystemControl(weight);
            if (!rissing)
                Console.WriteLine("Ağırlık durulama sistemi için çok fazla");
            if (!spinning)
                Console.WriteLine("Ağırlık döndürme sistemi için çok fazla");
            if (!washing)
                Console.WriteLine("Ağırlık yıkama sistemi için çok fazla");
            if (rissing && spinning && washing)
                Console.WriteLine("Makineyi çalıştırmak için ağırlık tüm bileşenler için uygundur.");
        }
        public void Blacks(int weight)
        {
            Console.WriteLine("Makine kontrol ediliyor.");
            var rissing = rinsingSystem.RinsingSystemControl(weight);
            var spinning = spinningSystem.SpinningSystemControl(weight);
            var washing = washingSystem.WashingSystemControl(weight);
            if (!rissing)
                Console.WriteLine("Ağırlık durulama sistemi için çok fazla");
            if (!spinning)
                Console.WriteLine("Ağırlık döndürme sistemi için çok fazla");
            if (!washing)
                Console.WriteLine("Ağırlık yıkama sistemi için çok fazla");
            if (rissing && spinning && washing)
                Console.WriteLine("Makineyi çalıştırmak için ağırlık tüm bileşenler için uygundur.");
        }
    }
}
