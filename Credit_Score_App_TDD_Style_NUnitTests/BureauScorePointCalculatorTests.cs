using Credit_Score_App_TDD_Style;

namespace Credit_Score_App_TDD_Style_NUnitTests
{
    public class BureauScorePointCalculatorTests
    {
        private BureauScorePointCalculator _calculator;
        [SetUp]
        public void Setup()
        {
            //Arrange
            _calculator = new BureauScorePointCalculator();
        }

        [TestCase(-100, 0)]
        [TestCase(100, 0)]
        [TestCase(500, 1)]
        [TestCase(750, 2)]
        [TestCase(900, 3)]
        [TestCase(1300, 0)]

        public void CalculatePoint_GivenBureauScore_ShouldReturnCorrectPoints(int bureauScore, int expectedPoints)
        {
            //Act
            int points = _calculator.CalculatePoint(bureauScore);

            //Assert
            Assert.AreEqual(expectedPoints, points, $"\nCount of Bureau Score : {bureauScore}\nPoints should be equal");
        }

        [TearDown]
        public void TearDown()
        {
            _calculator = null;
        }
    }
}