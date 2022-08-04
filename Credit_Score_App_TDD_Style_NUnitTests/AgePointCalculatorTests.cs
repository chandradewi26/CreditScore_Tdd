using Credit_Score_App_TDD_Style;

namespace Credit_Score_App_TDD_Style_NUnitTests
{
    public class AgePointCalculatorTests
    {
        private AgePointCalculator _calculator;
        [SetUp]
        public void Setup()
        {
            //Arrange
            _calculator = new AgePointCalculator();
        }

        [TestCase(-100, 0)]
        [TestCase(15, 0)]
        [TestCase(20, 3)]
        [TestCase(26, 4)]
        [TestCase(39, 5)]
        [TestCase(55, 6)]

        public void CalculatePoint_GivenBureauScore_ShouldReturnCorrectPoints(int age, int expectedPoints)
        {
            //Act
            int points = _calculator.CalculatePoint(age);

            //Assert
            Assert.AreEqual(expectedPoints, points, $"\nAge : {age}\nPoints should be equal");
        }

        [TearDown]
        public void TearDown()
        {
            _calculator = null;
        }
    }
}