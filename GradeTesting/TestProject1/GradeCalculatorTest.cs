using System.ComponentModel.DataAnnotations;

namespace GradeTesting
{
    public class GradeCalculatorTest
    {
        private GradeCalculator _gradeCalculator { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _gradeCalculator = new GradeCalculator();
        }

        [TestCase(99)]
        [TestCase(98)]
        [TestCase(97)]
        [TestCase(96)]
        public void GetGrade_EqualTests(int percent)
        {
            //var percent = 99;
            var grade=_gradeCalculator.GetGrade(percent);
            Assert.AreEqual("A", grade);
        }
    }
}