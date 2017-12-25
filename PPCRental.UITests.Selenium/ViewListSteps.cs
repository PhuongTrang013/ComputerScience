using System.Linq;
using TechTalk.SpecFlow;
using PPCRental.AcceptanceTests.Common;
using PPCRental.UITests.Selenium.Support;
using PPCRental.Models;
using OpenQA.Selenium;

namespace PPCRental.UITests.Selenium
{
    [Binding, Scope(Tag = "automated")]
    class ViewListSteps : SeleniumStepsBase
    {
        [Given(@"following the projects")]
        public void GivenFollowingTheProjects(Table tableproject)
        {
            Browser.NavigateTo("Home"); 
        }

        [When(@"I click DUAN")]
        public void WhenIClickDUAN(string PropertyName)
        {
            Browser.SubmitForm("DUAN");
        }

        [Then(@"I should see the list of project")]
        public void ThenIShouldSeeTheListOfProject(Table viewlistproject)
        {
                
        }
    }
}
