using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using ThreeFourteen.AlphaVantage.Model;
using ThreeFourteen.AlphaVantage.Response;
using ThreeFourteen.AlphaVantage.Service;

namespace ThreeFourteen.AlphaVantage.Builders.Fundamentals
{
    public class FundamentalsOverviewBuilder : BuilderBase, IHaveData<Result<FundamentalsEntry>>, ICanSetOutputSize
    {
        public FundamentalsOverviewBuilder(IAlphaVantageService service, string symbol) : base(service)
        {
            SetField(ParameterFields.Symbol, symbol);
        }

        protected override string[] RequiredFields { get; }
        protected override Function Function { get; }

        public Task<Result<FundamentalsEntry>> GetAsync()
        {
            return GetSeriesDataAsync(Parse);
        }

        private IEnumerable<FundamentalsEntry> Parse(JToken token)
        {
            var properties = token as JProperty;
            return properties.First.Children()
                .Select(x => ((JProperty)x).ToOverview())
                .ToList();
        }
    }
}