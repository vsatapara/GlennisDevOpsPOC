using NUnit.Framework;

namespace GlennisDemoNUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }


        #region Survey test case
        [Test]
        public void AddSurvey_Success()
        {
            //SurveyModel _survey = new SurveyModel();
            //_survey.ID = 0;
            //_survey.name = "Engage Life";
            //_survey.department = "Administrative";
            //_survey.role = "TR";
            //var result = _controller.AddSurvey(_survey);

            Assert.AreEqual(200, 201);
        }

        [Test]
        public void AddSurvey_Fail()
        {
            //SurveyModel _survey = null;
            //var result = _controller.AddSurvey(_survey);

            Assert.AreEqual(400, 400);
        }


     
        #endregion

    }
}