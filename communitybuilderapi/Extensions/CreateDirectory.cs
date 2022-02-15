using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace communitybuilderapi.Extensions
{
    public static class CreateDirectory
    {
        public static void Directories(this IServiceCollection service)
        {
            try
            {
                //var folder = Path.Combine(
                //(string)AppDomain.CurrentDomain.GetData("ContentRootPath"),
                //"~/Upload/Business");
                var folder = Path.Combine("",
               "~/Upload/Business");
                //var folder = Microsoft.AspNetCore.Http.HttpContext.Current.Server.MapPath("~/App_Data/uploads/random");
                //var folder = MyServer.MapPath("~/Upload/Business");
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
        public static class MyServer
        {
            public static string MapPath(string path)
            {
                return Path.Combine(
                    (string)AppDomain.CurrentDomain.GetData("ContentRootPath"),
                    path);
            }
        }
    }
}
