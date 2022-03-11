using FluentApi.Configurations;
using FluentApi.Interfaces;
using FluentApi.Models;

namespace FluentApi.Apis
{
    public class FluentPussy : 
        IOwnerSelectionStage,
        ISemenAmountSelectionStage,
        IDickSelectionStage,
        IToySelectionStage,
        IPussyInitiallizerStage
    {
        private readonly Pussy _pussy;
        
        private FluentPussy(Action<WetConfiguration> config)
        {
            var wetConfig = new WetConfiguration();
            config?.Invoke(wetConfig);
            
            _pussy = new Pussy
            {
                Status = wetConfig.Status
            };
        }
    
        public static IOwnerSelectionStage CreatePussy(Action<WetConfiguration> config)
        {
            return new FluentPussy(config);
        }
            
        public ISemenAmountSelectionStage FromOwner(string owner)
        {
            _pussy.Owner = owner;
            return this;
        }
        
        public IDickSelectionStage WithSemenAmount(int semenAmount)
        {
            _pussy.SemenAmount = semenAmount;
            return this;
        }
        
        public IToySelectionStage FromDick(string dick)
        {
            _pussy.Dick = dick;
            return this;
        }
    
        public IPussyInitiallizerStage WithToy(string toy)
        {
            _pussy.Toy = toy;
            return this;
        }
    
        public Pussy Build()
        {
            return _pussy;
        }
    }
}