using TestApp.API.Models;

namespace TestApp.API.Data
{
    public class SeedDB
    {
        private readonly TestDBContext _context;

        public SeedDB(TestDBContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.Client.Any())
            {
                return;
            }


            Client client1 = new()
            {
                Id = Guid.NewGuid(),
                Name = "Bill",
                Phone = "555-555-1000",
                Email = "bill@gmail.com"
            };

            Client client2 = new()
            {
                Id = Guid.NewGuid(),
                Name = "Jeff",
                Phone = "555-555-2000",
                Email = "jeff@outlook.com"
            };

            _context.Add(client1);
            _context.Add(client2);

            Doctor doctor1 = new()
            {
                Id = Guid.NewGuid(),
                Name = "Doctor1"
            };

            Doctor doctor2 = new()
            {
                Id = Guid.NewGuid(),
                Name = "Doctor2"
            };

            _context.Add(doctor1);
            _context.Add(doctor2);

            _context.SaveChanges();
        }
    }
}
