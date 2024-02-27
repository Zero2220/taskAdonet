using taskentity;
using System.Linq;

AppDbContext context = new AppDbContext();

Brands brand = new Brands()
{
    Id = 1,
    Name = "akif"

};

context.Add(brand);
context.SaveChanges();

var brands = context.Brands.ToList();  

