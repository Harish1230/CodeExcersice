using System;

namespace DeveloperSample.ClassRefactoring
{
    public abstract class Swallow
    {
        public abstract double GetBaseAirspeed();

        public abstract double GetAirspeedVelocity();
    }

    public class AfricanSwallow : Swallow
    {
        private const double BaseAirspeed = 22;
        private const double CoconutModifier = 4;

        public override double GetBaseAirspeed() => BaseAirspeed;

        public override double GetAirspeedVelocity()
        {
            return Load == SwallowLoad.None ? GetBaseAirspeed() : GetBaseAirspeed() - CoconutModifier;
        }
    }

    public class EuropeanSwallow : Swallow
    {
        private const double BaseAirspeed = 20;
        private const double CoconutModifier = 4;

        public override double GetBaseAirspeed() => BaseAirspeed;

        public override double GetAirspeedVelocity()
        {
            return Load == SwallowLoad.None ? GetBaseAirspeed() : GetBaseAirspeed() - CoconutModifier;
        }
    }

    public enum SwallowType
    {
        African,
        European
    }

    public enum SwallowLoad
    {
        None,
        Coconut
    }

    public class SwallowFactory
    {
        public Swallow GetSwallow(SwallowType swallowType)
        {
            return swallowType switch
            {
                SwallowType.African => new AfricanSwallow(),
                SwallowType.European => new EuropeanSwallow(),
                _ => throw new ArgumentException("Invalid swallow type"),
            };
        }
    }
}
