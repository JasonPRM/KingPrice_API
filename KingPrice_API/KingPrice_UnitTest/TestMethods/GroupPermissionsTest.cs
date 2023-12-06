using KingPrice_API.Data;
using KingPrice_API.Models;
using KingPrice_API.Services.GroupPermissionsService;
using KingPrice_API.Services.UserService;
using Microsoft.AspNetCore.Builder;
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
    public class GroupPermissionsTest
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
        public async Task TestDeleteGroupPermissions()
        {
            var builder = WebApplication.CreateBuilder(new WebApplicationOptions() { });

            builder.Services.AddDbContext<KingPriceDBContext>(options => options.UseSqlServer(
            builder.Configuration.GetConnectionString("KingPriceConnection")));
            builder.Services.AddSingleton<IGroupPermissionsService, GroupPermissionsService>();

            var app = builder.Build();

            var serviceProvider = new DependencyResolverHelper(app);
            var userService = serviceProvider.GetService<IGroupPermissionsService>();

            GroupPermissions? groupPerms = RuntimeHelpers.GetUninitializedObject(typeof(GroupPermissions)) as GroupPermissions;
            GroupPermissions? gpResult = RuntimeHelpers.GetUninitializedObject(typeof(GroupPermissions)) as GroupPermissions;

            if (!(groupPerms is null))
            {
                groupPerms.GroupID = 3;
                groupPerms.PermissionsID = 2;

                gpResult = await userService.AddGroupPerms(groupPerms);

                if (!(gpResult is null))
                {
                    var deletedAddedUser = await userService.DeleteGroupPerms(gpResult.ID);
                }
            }
            else
            {
                gpResult = null;
            }

            Assert.IsTrue(!(gpResult is null));
        }
    }
}
