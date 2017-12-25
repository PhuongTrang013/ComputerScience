using TechTalk.SpecFlow;
using PPCRental.AcceptanceTests.Driver.Property;
using PPCRental.Models;

namespace PPCRental.AcceptanceTests.Step
{
    [Binding, Scope(Tag = "automated")]
    class ViewListSteps
    {
        PPCEntities db = new PPCEntities();
        private readonly ViewListDriver _viewlistdriver;

        public ViewListSteps(ViewListDriver driver)
        {
            _viewlistdriver = driver;
        }

        //asd
        [Given(@"following the projects")]
        public void GivenFollowingTheProjects(Table expectedproject)
        {
            _viewlistdriver.InsertToDb(expectedproject);
        }

        [When(@"I click DUAN")]
        public void WhenIClickDUAN(string PropertyName)
        {
            _viewlistdriver.OpenProperty(PropertyName);
        }

        [Then(@"I should see the list of project")]
        public void ThenIShouldSeeTheListOfProject(Table viewlistproject)
        {
            _viewlistdriver.ShowProject(viewlistproject);
        }


    }
}
