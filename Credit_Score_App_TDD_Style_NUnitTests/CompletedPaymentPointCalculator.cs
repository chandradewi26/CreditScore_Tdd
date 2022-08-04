using Credit_Score_App_TDD_Style;

namespace Credit_Score_App_TDD_Style_NUnitTests
{
    public class CompletedPaymentPointCalculatorTests
    {
        private CompletedPaymentPointCalculator _calculator;
        [SetUp]
        public void Setup()
        {
            //Arrange
            _calculator = new CompletedPaymentPointCalculator();
        }

        [TestCase(-100, 0)]
        [TestCase(0, 0)]
        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 4)]
        [TestCase(5, 4)]

        public void CalculatePoint_GivenBureauScore_ShouldReturnCorrectPoints(int completedPayment, int expectedPoints)
        {
            //Act
            int points = _calculator.CalculatePoint(completedPayment);

            //Assert
            Assert.AreEqual(expectedPoints, points, $"\nCount of Completed Payments : {completedPayment}\nPoints should be equal");
        }

        [TearDown]
        public void TearDown()
        {
            _calculator = null;
        }
    }
}