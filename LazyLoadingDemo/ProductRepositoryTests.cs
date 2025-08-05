using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LazyLoadingDemo.Tests
{
    [TestClass]
    public class ProductRepositoryTests
    {
        [TestMethod]
        public void GetProducts_WithNullPageNumber_ShouldNotThrowException()
        {
            // Arrange
            var repository = new ProductRepository();

            // Act
            try
            {
                repository.GetProducts(null);
            }
            catch (System.Exception)
            {
                Assert.Fail("Expected no exception, but one was thrown.");
            }
        }
    }
}
