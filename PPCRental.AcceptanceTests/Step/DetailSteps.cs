using TechTalk.SpecFlow;
using PPCRental.AcceptanceTests.Driver.Property;
using System;

namespace PPCRental.AcceptanceTests.Step
{
    [Binding, Scope(Tag = "automated")]
    class DetailSteps
    {

        private readonly DetailPropertyDriver _propertyDriver;

        public DetailSteps(DetailPropertyDriver driver)
        {
            _propertyDriver = driver;
        }
        
        [Given(@"the following projects")]
        public void GivenTheFollowingProjects(Table givenProjects)
        {
            _propertyDriver.InsertProjectToDB(givenProjects);
        }

        [When(@"I open the details of '(.*)'")]
        public void WhenIOpenTheDetailsOf(string givenPrjName)
        {
            _propertyDriver.OpenPropertyDetails(givenPrjName);
        }

        [Then(@"the project details should show")]
        public void ThenTheProjectDetailsShouldShow(Table shownProject)
        {
            _propertyDriver.ShowDetailProject(shownProject);
        }

    }
}
