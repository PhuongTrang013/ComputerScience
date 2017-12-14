﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace PPCRental.AcceptanceTests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class US03_PPCRentalFilterFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "US01_PPCRentalFilter.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "US03_PPCRentalFilter", "\tIn order to filter\r\n\tAs a User\r\n\tI want to filter project", ProgrammingLanguage.CSharp, new string[] {
                        "automated"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "US03_PPCRentalFilter")))
            {
                global::PPCRental.AcceptanceTests.Features.US03_PPCRentalFilterFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 10
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property_Name",
                        "Property_Type",
                        "Ward_ID",
                        "Price",
                        "Bedroom",
                        "District_ID",
                        "Bathroom"});
            table1.AddRow(new string[] {
                        "PIS Top Apartment",
                        "Apartment",
                        "TT Tây Đằng",
                        "10000",
                        "3",
                        "Ba Vì",
                        "3"});
            table1.AddRow(new string[] {
                        "Modern Style Apartment",
                        "Villa",
                        "Ba Trại",
                        "30000",
                        "2",
                        "Ba Vì",
                        "4"});
            table1.AddRow(new string[] {
                        "PIS Serviced Apartment",
                        "Villa",
                        "Ba Vì",
                        "70000",
                        "3",
                        "Ba Vì",
                        "2"});
#line 11
 testRunner.Given("the following property", ((string)(null)), table1, "Given ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Property Name should be matched")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "US03_PPCRentalFilter")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("automated")]
        public virtual void PropertyNameShouldBeMatched()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Property Name should be matched", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 10
this.FeatureBackground();
#line 18
 testRunner.Given("User at the Home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.When("I search for property by the pharse \'Property name\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Property_Name"});
            table2.AddRow(new string[] {
                        "PIS Top Apartment"});
            table2.AddRow(new string[] {
                        "Modern Style Apartment"});
            table2.AddRow(new string[] {
                        "PIS Serviced Apartment"});
#line 20
 testRunner.Then("User should see the list name of project", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion