using System;
using Xunit;

namespace DDDCourse.Tests
{
    public class Entity_Spec
    {
        [Fact]
        public void Payment_should_be_valid()
        {
            // Arrange
            Payment payment = new Payment("123", "32323", DateTime.Now, 10m, "KinderBueno");

            // Assert
            Assert.NotNull(payment.Id);
            Assert.NotNull(payment.CardNumber);
            Assert.NotNull(payment.CVV);
        }
    }
}
