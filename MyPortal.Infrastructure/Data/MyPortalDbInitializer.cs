using MyPortal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortal.Infrastructure.Data
{
    public  class MyPortalDbInitializer
    {

        private readonly Dictionary<int, Client> Clients = new Dictionary<int, Client>();
        private readonly Dictionary<int, User> Users = new Dictionary<int, User>();
        private readonly Dictionary<int, Menu> Menus = new Dictionary<int, Menu>();
        private readonly Dictionary<int, Dashboard> Dashboards = new Dictionary<int, Dashboard>();
        private readonly Dictionary<int, UserDashBoards> UserDashboards = new Dictionary<int, UserDashBoards>();


        public  void Seed(MyPortalDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Clients.Any())
            {
                return;
            }

            SeedClients(context);

            SeedUsers(context);

            SeedDasBoards(context);
            SeedMenu(context);
            SeeUserDashboards(context);
        }

        public static void Initialize(MyPortalDbContext context)
        {
            var initializer = new MyPortalDbInitializer();
            initializer.Seed(context);


             
        }

        private static IList<T> ConvertToList<T>(Dictionary<int, T> map)
        {
            var list1 = new List<T>();
            foreach (var employee in map.Values)
            {
                list1.Add(employee);
            }

            return list1;

        }

        private  void SeedClients(MyPortalDbContext context)
        {
            Clients.Add(1, new Client { Name = "Toyoto" });
            Clients.Add(2, new Client { Name = "TJMax" });
            Clients.Add(3, new Client { Name = "Honda" });
            Clients.Add(4, new Client { Name = "Walmart" });

            context.Clients.AddRange(ConvertToList<Client>(Clients));
            context.SaveChanges();

        }

        private void SeedUsers(MyPortalDbContext context)
        {
            Users.Add(1, new User { FirstName = "Mani",
                    LastName="Rad",
                    BirthDate= DateTime.Parse("Jan 27 1966 12:00AM"),
                    Client = Clients[1] });

            Users.Add(2, new User
            {
                FirstName = "John",
                LastName = "Smith",
                BirthDate = DateTime.Parse("Dec 27 1966 12:00AM"),
                Client = Clients[1]
            });

            Users.Add(3, new User
            {
                FirstName = "Ron",
                LastName = "Bigda",
                BirthDate = DateTime.Parse("Jan 1 1926 12:00AM"),
                Client = Clients[2]
            });

            Users.Add(4, new User
            {
                FirstName = "Bin",
                LastName = "Cave",
                BirthDate = DateTime.Parse("Jan 27 1965 12:00AM"),
                Client = Clients[3]
            });

            Users.Add(5, new User
            {
                FirstName = "Chandran",
                LastName = "Navjith",
                BirthDate = DateTime.Parse("Jan 27 1961 12:00AM"),
                Client = Clients[3]
            });

            Users.Add(6, new User
            {
                FirstName = "Bill",
                LastName = "Warner",
                BirthDate = DateTime.Parse("Jan 27 1976 12:00AM"),
                Client = Clients[4]
            });

            Users.Add(7, new User
            {
                FirstName = "Ravi",
                LastName = "Kumar",
                BirthDate = DateTime.Parse("Jan 27 1966 12:00AM"),
                Client = Clients[1]
            });

            context.Users.AddRange(ConvertToList<User>(Users));
            context.SaveChanges();
        }

        private void SeedDasBoards(MyPortalDbContext context)
        {
            Dashboards.Add(1, new Dashboard
            {
                Name = "DashBoard1",
                Description = "Primary Dashboard",
                CreatedOn = DateTime.Parse("Jan 2 2019 12:00AM")
            });
            Dashboards.Add(2, new Dashboard
            {
                Name = "DashBoard-2",
                Description = "Secondary Dashboard",
                CreatedOn = DateTime.Parse("Jan 2 2019 12:00AM")
            });
            Dashboards.Add(3, new Dashboard
            {
                Name = "DashBoard-31",
                Description = "Sales Dashboard",
                CreatedOn = DateTime.Parse("Jan 2 2019 12:00AM")
            });
            Dashboards.Add(4, new Dashboard
            {
                Name = "DashBoard1",
                Description = "Monhtly Target By Zone",
                CreatedOn = DateTime.Parse("Jan 2 2019 12:00AM")
            });
            context.Dashboards.AddRange(ConvertToList<Dashboard>(Dashboards));
            context.SaveChanges();
        }
        private void SeedMenu(MyPortalDbContext context)
        {
            Menus.Add(0, new Menu { Name = "Root"});
            Menus.Add(1, new Menu { Name = "Clients", Url = "/elementum.html" ,ParentMenu=Menus[0]});
            Menus.Add(2, new Menu
            {
                Name = "Garden",
                Url = "/pellentesque/ultrices/mattis/odio/donec.html",
                ParentMenu = Menus[0]
            });
            Menus.Add(3, new Menu
            {
                Name = "Service",
                Url = "/congue/diam/id/ornare.jsp",
                ParentMenu = Menus[1]
            });
            Menus.Add(4, new Menu
            {
                Name = "Games",
                Url = "/magna/at/nunc/commodo/placerat.html",
                ParentMenu = Menus[1]
            });
            Menus.Add(5, new Menu
            {
                Name = "Music",
                Url = "/nulla/ultrices/aliquet/maecenas/leo/odio/condimentum.js",
                ParentMenu = Menus[2]
            });
            Menus.Add(6, new Menu
            {
                Name = "Electronics",
                Url = "/consequat.xml",
                ParentMenu = Menus[2]
            });
            Menus.Add(7, new Menu
            {
                Name = "Books",
                Url = "/vulputate/vitae/nisl/aenean/lectus/pellentesque.js",
                ParentMenu = Menus[2]
            });
            Menus.Add(8, new Menu
            {
                Name = "Kids",
                Url = "/ligula.aspx",
                ParentMenu = Menus[3]
            });
            Menus.Add(9, new Menu
            {
                Name = "Movies",
                Url = "/lacinia.xml",
                ParentMenu = Menus[4]
            });
            Menus.Add(10, new Menu
            {
                Name = "Grocery",
                Url = "/velit/nec/nisi/vulputate.aspx",
                ParentMenu = Menus[2]
            });
            Menus.Add(11, new Menu
            {
                Name = "Health",
                Url = "/est/quam/pharetra/magna/ac.html",
                ParentMenu = Menus[2]
            });
            Menus.Add(12, new Menu
            {
                Name = "Garden",
                Url= "/mi/in/porttitor/pede/justo/eu.jsp",
                ParentMenu = Menus[3]
            });

            context.Menus.AddRange(ConvertToList<Menu>(Menus));
            context.SaveChanges();

        }

        public void SeeUserDashboards(MyPortalDbContext context)
        {
            var userDashboards = new List<UserDashBoards>()
            {
                new UserDashBoards{User=Users[1],Dashboard= Dashboards[1]},
                new UserDashBoards{User=Users[1],Dashboard= Dashboards[2]},
                new UserDashBoards{User=Users[2],Dashboard= Dashboards[3]},
                new UserDashBoards{User=Users[3],Dashboard= Dashboards[1]},
                new UserDashBoards{User=Users[4],Dashboard= Dashboards[1]},
                new UserDashBoards{User=Users[4],Dashboard= Dashboards[2]},
                new UserDashBoards{User=Users[4],Dashboard= Dashboards[3]},

            };
            context.UserDashBoards.AddRange(userDashboards);
            context.SaveChanges();
        }

    }

    

}
