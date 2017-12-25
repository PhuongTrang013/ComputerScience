using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPCRental.UITests.Selenium.Support;
using OpenQA.Selenium;
using PPCRental.Models;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;

namespace PPCRental.UITests.Selenium
{
    [Binding, Scope(Tag = "web")]
    class DetailSteps : SeleniumStepsBase
    {
        [Given(@"the following projects")]
        public void GivenTheFollowingProjects()
        {
            Browser.NavigateTo("Home/Index");
        }

        [When(@"I open the details of '(.*)'")]
        public void WhenIOpenTheDetailsOf(string givenPrjName)
        {
            using (var db = new PPCEntities())
            {
                var id = db.PROPERTies.ToList().FirstOrDefault(x => x.PropertyName == givenPrjName).ID;
                Browser.FindElement(By.Id(id.ToString()));
            }
            
        }

        [Then(@"the project details should show")]
        public void ThenTheProjectDetailsShouldShow(Table shownProject)
        {
            //Arrange
            string expectedTitle = shownProject.Rows.Single().ToString();

            //Act
            string actualTitle = Browser.FindElement(By.XPath("//*[@id='section1']/div/div[1]/h1")).Text;

            //Assert
            true.Equals(actualTitle.Contains(expectedTitle));
        }
    }
}
