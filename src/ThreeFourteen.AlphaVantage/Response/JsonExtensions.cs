using System;
using Newtonsoft.Json.Linq;
using ThreeFourteen.AlphaVantage.Model;

namespace ThreeFourteen.AlphaVantage.Response
{
    public static class JsonExtensions
    {
        public static TimeSeriesEntry ToTimeSeries(this JProperty token)
        {
            var date = Formats.ParseDateTime(token.Name);
            var entry = new TimeSeriesEntry
            {
                Timestamp = date,
                Open = token.First.Value<double>("1. open"),
                High = token.First.Value<double>("2. high"),
                Low = token.First.Value<double>("3. low"),
                Close = token.First.Value<double>("4. close"),
                Volume = token.First.Value<long>("5. volume")
            };

            return entry;
        }

        public static TimeSeriesAdjustedEntry ToTimeSeriesAdjusted(this JProperty token)
        {
            var date = Formats.ParseDateTime(token.Name);
            var entry = new TimeSeriesAdjustedEntry
            {
                Timestamp = date,
                Open = token.First.Value<double>("1. open"),
                High = token.First.Value<double>("2. high"),
                Low = token.First.Value<double>("3. low"),
                Close = token.First.Value<double>("4. close"),
                AdjustedClose = token.First.Value<double>("5. adjusted close"),
                Volume = token.First.Value<long>("6. volume"),
                DividendAmount = token.First.Value<double>("7. dividend amount"),
                SplitCoefficient = token.First.Value<double>("8. split coefficient")
            };

            return entry;
        }

        public static FxEntry ToFx(this JProperty token)
        {
            var date = Formats.ParseDateTime(token.Name);
            var entry = new FxEntry
            {
                Timestamp = date,
                Open = token.First.Value<double>("1. open"),
                High = token.First.Value<double>("2. high"),
                Low = token.First.Value<double>("3. low"),
                Close = token.First.Value<double>("4. close")
            };

            return entry;
        }

        public static CryptoEntry ToCrypto(this JProperty token, string market)
        {
            var date = Formats.ParseDateTime(token.Name);
            var entry = new CryptoEntry
            {
                Timestamp = date,
                Open = token.First.Value<double>($"1a. open ({market})"),
                High = token.First.Value<double>($"2a. high ({market})"),
                Low = token.First.Value<double>($"3a. low ({market})"),
                Close = token.First.Value<double>($"4a. close ({market})"),
                OpenUsd = token.First.Value<double>("1b. open (USD)"),
                HighUsd = token.First.Value<double>("2b. high (USD)"),
                LowUsd = token.First.Value<double>("3b. low (USD)"),
                CloseUsd = token.First.Value<double>("4b. close (USD)"),
                Volume = token.First.Value<double>("5. volume"),
                MarketCapUsd = token.First.Value<double>("6. market cap (USD)")
            };

            return entry;
        }

        public static FundamentalsEntry ToOverview(this JProperty token)
        {
            var entry = new FundamentalsEntry
            {
                Symbol = token.First.Value<string>("Symbol"),
                AssetType = token.First.Value<string>("AssetType"),
                Name = token.First.Value<string>("Name"),
                Description = token.First.Value<string>("Description"),
                CIK = token.First.Value<int>("CIK"),
                Exchange = token.First.Value<string>("Exchange"),
                Currency = token.First.Value<string>("Currency"),
                Country = token.First.Value<string>("Country"),
                Sector = token.First.Value<string>("Sector"),
                Industry = token.First.Value<string>("Industry"),
                Address = token.First.Value<string>("Address"),
                FiscalYearEnd = token.First.Value<string>("FiscalYearEnd"),
                LatestQuarter = token.First.Value<DateTime>("LatestQuarter"),
                MarketCapitalization = token.First.Value<int>("MarketCapitalization"),
                EBITDA = token.First.Value<int>("EBITDA"),
                PERatio = token.First.Value<double>("PERatio"),
                PEGRatio = token.First.Value<double>("PEGRatio"),
                BookValue = token.First.Value<double>("BookValue"),
                DividendPerShare = token.First.Value<double>("DividendPerShare"),
                DividendYield = token.First.Value<float>("DividendYield"),
                EPS = token.First.Value<double>("EPS"),
                RevenuePerShareTTM = token.First.Value<double>("RevenuePerShareTTM"),
                ProfitMargin = token.First.Value<float>("ProfitMargin"),
                OperatingMarginTTM = token.First.Value<float>("OperatingMarginTTM"),
                ReturnOnAssetsTTM = token.First.Value<float>("ReturnOnAssetsTTM"),
                ReturnOnEquityTTM = token.First.Value<float>("ReturnOnEquityTTM"),
                RevenueTTM = token.First.Value<string>("RevenueTTM"),
                GrossProfitTTM = token.First.Value<int>("GrossProfitTTM"),
                DilutedEPSTTM = token.First.Value<int>("DilutedEPSTTM"),
                QuarterlyEarningsGrowthYOY = token.First.Value<float>("QuarterlyEarningsGrowthYOY"),
                QuarterlyRevenueGrowthYOY = token.First.Value<float>("QuarterlyRevenueGrowthYOY"),
                AnalystTargetPrice = token.First.Value<double>("AnalystTargetPrice"),
                TrailingPE = token.First.Value<double>("TrailingPE"),
                ForwardPE = token.First.Value<double>("ForwardPE"),
                PriceToSalesRatioTTM = token.First.Value<float>("PriceToSalesRationTTM"),
                PriceToBookRatio = token.First.Value<double>("PriceToBookRatio"),
                EVToRevenue = token.First.Value<double>("EVToRevenue"),
                EVToEBITDA = token.First.Value<double>("EVToEBITDA"),
                Beta = token.First.Value<double>("Beta"),
                _52WeekHigh = token.First.Value<double>("52WeekHigh"),
                _52WeekLow = token.First.Value<double>("52WeekLow"),
                _50DayMovingAverage = token.First.Value<double>("50DayMovingAverage"),
                _200DayMovingAverage = token.First.Value<double>("200DayMovingAverage"),
                SharesOutstanding = token.First.Value<int>("SharesOutstanding"),
                DividendDate = token.First.Value<DateTime>("DividendDate"),
                ExDividendDate = token.First.Value<DateTime>("ExDividendDate")
                
                
            };

            return entry;
        }

        public static TechnicalEntry ToTechnical(this JProperty token, string valueKey)
        {
            var date = Formats.ParseDateTime(token.Name);
            var entry = new TechnicalEntry
            {
                Timestamp = date,
                Value = token.First.Value<double>(valueKey),
            };

            return entry;
        }
    }
}
