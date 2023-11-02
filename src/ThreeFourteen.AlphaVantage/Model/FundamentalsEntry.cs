using System;
using Newtonsoft.Json;

namespace ThreeFourteen.AlphaVantage.Model
{
    public class FundamentalsEntry
    {
        public string Symbol { get; internal set; }
        public string AssetType { get; internal set; }
        public string Name { get; internal set; }
        public string Description { get; internal set; }
        public int? CIK { get; internal set; }
        public string Exchange { get; internal set; }
        public string Currency { get; internal set; }
        public string Country { get; internal set; }
        public string Sector { get; internal set; }
        public string Industry { get; internal set; }
        public string Address { get; internal set; }
        public string FiscalYearEnd { get; internal set; }
        public DateTime? LatestQuarter { get; internal set; }
        public int? MarketCapitalization { get; internal set; }
        public int EBITDA { get; internal set; }
        public double? PERatio { get; internal set; }
        public double? PEGRatio { get; internal set; }
        public double? BookValue { get; internal set; }
        public double? DividendPerShare { get; internal set; }
        public float? DividendYield { get; internal set; }
        public double? EPS { get; internal set; }
        public double? RevenuePerShareTTM { get; internal set; }
        public float? ProfitMargin { get; internal set; }
        public float? OperatingMarginTTM { get; internal set; }
        public float? ReturnOnAssetsTTM { get; internal set; }
        public float? ReturnOnEquityTTM { get; internal set; }
        public string RevenueTTM { get; internal set; }
        public int GrossProfitTTM { get; internal set; }
        public double? DilutedEPSTTM { get; internal set; }
        public float? QuarterlyEarningsGrowthYOY { get; internal set; }
        public float? QuarterlyRevenueGrowthYOY { get; internal set; }
        public double? AnalystTargetPrice { get; internal set; }
        public double? TrailingPE { get; internal set; }
        public double? ForwardPE { get; internal set; }
        public float? PriceToSalesRatioTTM { get; internal set; }
        public double? PriceToBookRatio { get; internal set; }
        public double? EVToRevenue { get; internal set; }
        public double? EVToEBITDA { get; internal set; }
        public double? Beta { get; internal set; }
        [JsonProperty("52WeekHigh")] public double? _52WeekHigh { get; internal set; }
        [JsonProperty("52WeekLow")] public double? _52WeekLow { get; internal set; }
        [JsonProperty("50DayMovingAverage")] public double? _50DayMovingAverage { get; internal set; }
        [JsonProperty("200DayMovingAverage")] public double? _200DayMovingAverage { get; internal set; }
        public int? SharesOutstanding { get; internal set; }
        public DateTime? DividendDate { get; internal set; }
        public DateTime? ExDividendDate { get; internal set; }
    }
}
