using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class chapter_21
    {
        var customers = new[] {
new { CustomerID = 1, FirstName = "Kim", LastName = "Abercrombie",
CompanyName = "Alpine Ski House" },
new { CustomerID = 2, FirstName = "Jeff", LastName = "Hay",
CompanyName = "Coho Winery" },
new { CustomerID = 3, FirstName = "Charlie", LastName = "Herb",
CompanyName = "Alpine Ski House" },
new { CustomerID = 4, FirstName = "Chris", LastName = "Preston",
CompanyName = "Trey Research" },
new { CustomerID = 5, FirstName = "Dave", LastName = "Barnett",
CompanyName = "Wingtip Toys" },
new { CustomerID = 6, FirstName = "Ann", LastName = "Beebe",
CompanyName = "Coho Winery" },
new { CustomerID = 7, FirstName = "John", LastName = "Kane",
CompanyName = "Wingtip Toys" },
new { CustomerID = 8, FirstName = "David", LastName = "Simpson",
CompanyName = "Trey Research" },
new { CustomerID = 9, FirstName = "Greg", LastName = "Chapman",
CompanyName = "Wingtip Toys" },
new { CustomerID = 10, FirstName = "Tim", LastName = "Litton",
CompanyName = "Wide World Importers" }
};


        var addresses = new[] {
new { CompanyName = "Alpine Ski House", City = "Berne",
Country = "Switzerland"},
new { CompanyName = "Coho Winery", City = "San Francisco",
Country = "United States"},
new { CompanyName = "Trey Research", City = "New York",
Country = "United States"},
new { CompanyName = "Wingtip Toys", City = "London",
Country = "United Kingdom"},
new { CompanyName = "Wide World Importers", City = "Tetbury",
Country = "United Kingdom"}
};

    }
}
