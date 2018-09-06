﻿using Shouldly;
using System.Linq;
using Xunit;

namespace ThreeFourteen.AlphaVantage.Test.Builders.Fx
{
    public class ExchangeRateBuilderTests : BuilderTestsBase
    {
        [Fact]
        public async void Get_ShouldReturnValidData()
        {
            var result = await AlphaVantage.Fx.ExchangeRate("BTC", "CNY")
                .GetAsync();

            ServiceMock.LatestParameters[ParameterFields.FromCurrency].ShouldBe("BTC");
            ServiceMock.LatestParameters[ParameterFields.ToCurrency].ShouldBe("CNY");
            ServiceMock.LatestParameters[ParameterFields.Function].ShouldBe(Function.Fx.ExchangeRate.Value);

            result.Data.FromCurrencyCode.ShouldBe("BTC");
            result.Data.FromCurrencyName.ShouldBe("Bitcoin");
            result.Data.ToCurrencyCode.ShouldBe("CNY");
            result.Data.ToCurrencyName.ShouldBe("Chinese Yuan");
            result.Data.ExchangeRate.ShouldBe(43742.96736490);
            result.Data.LastRefreshed.ShouldBe(Formats.ParseDateTime("2018-09-06 06:16:38"));
            result.Data.TimeZone.ShouldBe("UTC");
        }
    }
}