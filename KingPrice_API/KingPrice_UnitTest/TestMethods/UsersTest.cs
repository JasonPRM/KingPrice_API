using KingPrice_API.Data;
using KingPrice_API.Models;
using KingPrice_API.Services.UserService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KingPrice_UnitTest.TestMethods
{
    public class UsersTest
    {
        public class DependencyResolverHelper
        {
            private readonly WebApplication _app;

            /// <inheritdoc />
            public DependencyResolverHelper(WebApplication app) => _app = app;


            public T GetService<T>()
            {
                var serviceScope = _app.Services.CreateScope();
                var services = serviceScope.ServiceProvider;
                try
                {
                    var scopedService = services.GetRequiredService<T>();
                    return scopedService;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }


        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public async Task TestAddUser()
        {
            var builder = WebApplication.CreateBuilder(new WebApplicationOptions() { });

            builder.Services.AddDbContext<KingPriceDBContext>(options => options.UseSqlServer(
            builder.Configuration.GetConnectionString("KingPriceConnection")));
            builder.Services.AddSingleton<IUserService, UserService>();

            var app = builder.Build();

            var serviceProvider = new DependencyResolverHelper(app);
            var userService = serviceProvider.GetService<IUserService>();

            Users? newUser = RuntimeHelpers.GetUninitializedObject(typeof(Users)) as Users;
            Users? userResult = RuntimeHelpers.GetUninitializedObject(typeof(Users)) as Users;

            if (!(newUser is null))
            {
                newUser.Firstname = "Test";
                newUser.Surname = "Test";
                newUser.Email = "Test20@gmail.com";

                userResult = await userService.AddUser(newUser);

                //This is just to delete the added user so we don't fill the db unnecessarily if we wanted too
                //if (!(userResult is null))
                //{
                //    var deletedAddedUser = await userService.DeleteUser(userResult.ID);
                //}
            }
            else
            {
                userResult = null;
            }

            Assert.IsTrue(!(userResult is null));
        }
    }
}
