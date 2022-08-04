using Credit_Score_App_TDD_Style;

namespace Credit_Score_App_TDD_Style_NUnitTests
{
    public class MissedPaymentPointCalculatorTests
    {
        private MissedPaymentPointCalculator _calculator;
        [SetUp]
        public void Setup()
        {
            //Arrange
            _calculator = new MissedPaymentPointCalculator();
        }

        [TestCase(-100, 0)]
        [TestCase(0, 0)]
        [TestCase(1, -1)]
        [TestCase(2, -3)]
        [TestCase(3, -6)]
        [TestCase(5, -6)]

        public void CalculatePoint_GivenBureauScore_ShouldReturnCorrectPoints(int missedPayment, int expectedPoints)
        {
            //Act
            int points = _calculator.CalculatePoint(missedPayment);

            //Assert
            Assert.AreEqual(expectedPoints, points, $"\nCount of Missed Payments : {missedPayment}\nPoints should be equal");
        }

        [TearDown]
        public void TearDown()
        {
            _calculator = null;
        }
    }
}