using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithWebSite.Models
{
    public class SeedData
    {
        public static void Initialize(ZenithContext db)
        {
            if (!db.Activities.Any())
            {
                db.Activities.Add(new Activity
                {
                    Description = "Pool Party",
                    CreationDate = new DateTime(2017, 01, 01)
                });
                db.Activities.Add(new Activity
                {
                    Description = "Super Pool Party",
                    CreationDate = new DateTime(2017, 01, 03)
                });
                db.SaveChanges();

                db.Events.Add(new Event
                {
                    Start = new DateTime(2017, 01, 01),
                    End = new DateTime(2017, 01, 02),
                    CreatedBy = "mister x",
                    ActivityId = 1,
                    CreationDate = new DateTime(2017, 01, 01),
                    IsActive = true
                });
                db.Events.Add(new Event
                {
                    Start = new DateTime(2017, 01, 03),
                    End = new DateTime(2017, 01, 05),
                    CreatedBy = "mister y",
                    ActivityId = 2,
                    CreationDate = new DateTime(2017, 01, 02),
                    IsActive = true
                });
                db.SaveChanges();
            }
        }
    }
}
