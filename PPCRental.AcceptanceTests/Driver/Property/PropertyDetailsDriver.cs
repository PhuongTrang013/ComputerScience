using System;
using System.Linq;
using System.Web.Mvc;
using PPCRental.Models;
using PPCRental.AcceptanceTests.Support;
using PPCRental.Controllers;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace PPCRental.AcceptanceTests.Driver.Property
{
    class PropertyDetailsDriver
    {
        private readonly PropertyContext _context = new PropertyContext();
        private ActionResult _result;


        public void InsertProjectToDB(Table project)
        {
            using (var db = new PPCEntities())
            {

                foreach (var item in project.Rows)
                {
                    var street = item["Street"].ToString();
                    var district = item["District"].ToString();
                    var ward = item["Ward"].ToString();
                    var property = item["PropertyName"].ToString();
                    var content = item["Content"].ToString();
                    var price = item["Price"].ToString();
                    var bath = item["Bathroom"].ToString();
                    var bed = item["Bedroom"].ToString();
                    var pkplace = item["PackingPlace"].ToString();

                    PROPERTY pro = new PROPERTY()
                    {
                        PropertyName = property,
                        Content = content,
                        Street_ID = db.STREETs.FirstOrDefault(s => s.StreetName == street).ID,
                        Ward_ID = db.WARDs.FirstOrDefault(s => s.WardName == ward).ID,
                        District_ID = db.DISTRICTs.FirstOrDefault(s => s.DistrictName == district).ID,
                        Price = int.Parse(price),
                        BathRoom = int.Parse(bath),
                        BedRoom = int.Parse(bed),
                        PackingPlace = int.Parse(pkplace),

                    };
                    _context.ReferenceDetails.Add(project.Header.Contains("ID") ? item["ID"] : pro.PropertyName, pro);
                    db.PROPERTies.Add(pro);
                }
                db.SaveChanges();

            }
        }
        public void ShowDetailProject(Table ShowDetailProject)
        {
            //Arrange
            var expectedProjectDetails = ShowDetailProject.Rows.Single();

            //Act
            var actualProjectDetails = _result.Model<PROPERTY>();

            //Assert
            actualProjectDetails.Should().Match<PROPERTY>(
                b => b.PropertyName == expectedProjectDetails["PropertyName"]);
        }

        public void OpenPropertyDetails(string PropertyName)
        {
            var db = new PPCEntities();

            int property_Id = db.PROPERTies.FirstOrDefault(r => r.PropertyName == PropertyName).ID;

            using (var controller = new ViewDetailOfProjectUserController())
            {
                _result = controller.ViewDetailOfProject(property_Id);
            }
        }
    }
}
