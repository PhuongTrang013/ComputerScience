using PPCRental.Models;
using TechTalk.SpecFlow;

namespace PPCRental.AcceptanceTests.Support
{
    [Binding, Scope(Tag ="automated")]
    public class DatabaseTools
    {
        [BeforeScenario]
        public void CleanDatabase()
        {
            using (var db = new PPCEntities())
            {
                db.PROPERTY_FEATURE.RemoveRange(db.PROPERTY_FEATURE);
                db.PROPERTies.RemoveRange(db.PROPERTies);
                db.SaveChanges();
            }
        }
    }
}
