using FluentAssertions;
using HelperStockBeta.Domain.Entities;

namespace HelperStockBeta.Domain.Test
{
    public class ProductUnitTestBase
    {
        #region Testes positivos de Produto
        [Fact(DisplayName = "Product test image URL null.")]
        public void CreateProduct_WithNullImageName_ResultValid()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, null);
            action.Should()
                .NotThrow<HelperStockBeta.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact(DisplayName = "Product test image URL null.")]
        public void CreateProduct_WithNullImageName_ResulValidForNull()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, null);
            action.Should()
                .NotThrow<NullReferenceException>();
        }

        [Fact(DisplayName = "Product name is not null")]
        public void CreateProduct_WithValidParameters_ResultValid()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m,
                99, "product image");
            action.Should()
                .NotThrow<HelperStockBeta.Domain.Validation.DomainExceptionValidation>();
        }
        [Fact(DisplayName = "Product image URL is empty")]
        public void CreateProduct_WithEmptyImageName_ResultValid()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, "");
            action.Should().NotThrow<HelperStockBeta.Domain.Validation.DomainExceptionValidation>();
        }
        #endregion

        #region Testes Negativos de Produto
        [Fact(DisplayName = "Product negative id")]
        public void CreateProduct_NegativeIdValue_ResultException()
        {
            Action action = () => new Product(-1, "Product Name", "Product Description", 9.99m,
                99, "product image");

            action.Should().Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid negative values for id.");
        }

        [Fact(DisplayName = "Product a short name")]
        public void CreateProduct_ShortNameValue_ResultException()
        {
            Action action = () => new Product(1, "Pr", "Product Description", 9.99m, 99,
                "product image");
            action.Should().Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>()
                 .WithMessage("Invalid short names, minimum 3 characteres.");
        }

        [Fact(DisplayName = "Product image URL is long for use")]
        public void CreateProduct_LongImageName_ResultException()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m,
                99, "https://www.helperstock.com.br/RVNTQSBJTUFHRU0gw4kgR0lHQU5URSBFIEUgRVNUQSBVUkwgTsODTyDDiSBQRVJNSVRJREEgSsOBIFFVRSBPQ1VQQSBNQUlTIERFIDI1MCBDQVJBQ1RFUkVTIE5PIFRPVEFMLiARVNTQSBJTUFHRU0gw4kgR0lHQU5URSBFIEUgRVNUQSBVUkwgTsODTyDDiSBQRVJNSVRJREEgSsOBIFFVRSBPQ");

            action.Should()
                .Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>()
                 .WithMessage("Invalid long URL, maximum 250 characteres.");
        }
        [Fact(DisplayName = "Prtoduct is negative price")]
        public void CreateProduct_InvalidPriceValue_ResultException()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", -9.99m,
                99, "");
            action.Should().Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>()
                 .WithMessage("Invalid negative values for price.");
        }

        [Theory]
        [InlineData(-5)]
        public void CreateProduct_InvalidStockValue_ExceptionDomainNegativeValue(int value)
        {
            Action action = () => new Product(1, "Pro", "Product Description", 9.99m, value,
                "product image");
            action.Should().Throw<HelperStockBeta.Domain.Validation.DomainExceptionValidation>()
                   .WithMessage("Invalid negative values for stock.");
        }
    }
    #endregion
}
