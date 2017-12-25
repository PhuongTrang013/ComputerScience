using System.Collections.Generic;
using PPCRental.Controllers;
using PPCRental.Models;
using PPCRental.AcceptanceTests.Support;
using System.Linq;
using System.Web.Mvc;
using TechTalk.SpecFlow;
using System;
using PPCRental.AcceptanceTests.Common;
using FluentAssertions;


namespace PPCRental.AcceptanceTests.Driver.Property
{
    class ViewListDriver
    {
        private readonly PropertyContext _context = new PropertyContext();
        private ActionResult _result;

        public void InsertToDb(Table projects)
        {
            using (var db = new PPCEntities())
            {
                foreach (var insert in projects.Rows)
                {
                    var name = insert["Project Name"].ToString();
                    var ward = insert["Ward"].ToString();
                    var street = insert["Street"].ToString();
                    var district = insert["District"].ToString();
                    var price = insert["Price"].ToString();
                    var projectType = insert["Project Type"].ToString();
                    var statuss = insert["Status"].ToString();

                    PROPERTY pro = new PROPERTY()
                    {

                        PropertyName = insert["Project Name"].ToString(),
                        PropertyType_ID = db.PROPERTY_TYPE.ToList().FirstOrDefault(t => t.CodeType == insert["Project Type"]).ID,
                        Street_ID = db.STREETs.FirstOrDefault(s => s.StreetName == insert["Street"].ToString()).ID,
                        District_ID = db.DISTRICTs.ToList().FirstOrDefault(d => d.DistrictName == insert["District"]).ID,
                        Ward_ID = db.WARDs.ToList().FirstOrDefault(d => d.WardName == insert["Ward"]).ID,
                        Price = int.Parse(insert["Price"].ToString()),
                        Status_ID = db.PROJECT_STATUS.ToList().FirstOrDefault(a => a.Status_Name == insert["Status"].ToString()).ID
                    };
                    _context.ReferenceViewList.Add(projects.Header.Contains("ID") ? insert["ID"] : pro.PropertyName, pro);
                    db.PROPERTies.Add(pro);
                }
                db.SaveChanges();
            }
        }

        public void ShowProject(Table ShowProject)
        {
            ////Arrange
            //var expectedviewlist = ShowProject.Rows.Select(r => r["Property_Name"]);

            //////Act
            //var actualviewlist = _result.Model<IEnumerable<PPCRental.Models.PROPERTY_TYPE>>();

            ////Assert
            //ProjectAssertions.HomeScreenShouldShow(actualviewlist, expectedviewlist);

            //Arrange
            var expectedProject = ShowProject.Rows.Single();

            //Act
            var actualProject = _result.Model<PROPERTY>();

            //Assert
            actualProject.Should().Match<PROPERTY>(
                b => b.PropertyName == expectedProject["PropertyName"]);


        }

        public void OpenProperty(string PropertyName)
        {
            var db = new PPCEntities();

            int _Id = db.PROPERTies.FirstOrDefault(r => r.PropertyName == PropertyName).ID;

            using (var controller = new ViewListOfProjectController())
            {
                _result = controller.ViewListOfProjectUser(_Id);
            }
        }
    }
}
