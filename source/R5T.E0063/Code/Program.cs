using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Rendering;

using R5T.D0118;
using R5T.D0118.I000;
using R5T.F0033;
using R5T.F0064;
using R5T.R0003;
using R5T.Z0015;


namespace R5T.E0063
{
    class Program
    {
        static async Task Main()
        {
            //// Missing too many services...
            //var services = new ServiceCollection();

            //services.AddLogging();
            //services.AddRazorPages();

            //var serviceProvider = services.BuildServiceProvider();

            // So just use the web application builder!
            var builder = WebApplication.CreateBuilder();

            var services = builder.Services;

            //ServiceCollectionOperator.Instance.DescribeToTextFile_Synchronous(
            //    FilePaths.Instance.OutputTextFilePath,
            //    builder.Services);

            //NotepadPlusPlusOperator.Instance.Open(
            //    FilePaths.Instance.OutputTextFilePath);

            services.AddRazorPages();

            services.AddSingleton<IServiceC, ServiceC01>();

            var serviceProvider = services.BuildServiceProvider();

            var helper = serviceProvider.GetService<IHtmlHelper>();
            var context = Operations.Instance.CreateDefaultContext(serviceProvider);
            //var html = await Operations.Instance.RenderAsync<Component04>(helper, context, new
            //{
            //    Data = new Component04.Test()
            //    {
            //        Title = "Stack Overflow Test",
            //        FirstName = "user",
            //        LastName = "489566"
            //    }
            //});
            //var parameters = new
            //{
            //    Title = "The Title",
            //    Person = new Component05.Name
            //    {
            //        FirstName = "David",
            //        LastName = "Coats"
            //    }
            //};
            //var parameters = new Dictionary<string, object>
            //{
            //    { "Title", "The Title" },
            //    { "Person", new Component05.Name
            //    {
            //        FirstName = "David",
            //        LastName = "Coats"
            //    }
            //    },
            //};
            //var html = await Operations.Instance.RenderAsync<Component05>(helper, context, parameters);

            //var html = await Operations.Instance.RenderAsync<Component03>(helper, context, null);
            //var html = await Operations.Instance.RenderAsync<Component06>(helper, context, null);
            //var html = await Operations.Instance.RenderAsync<Component07>(helper, context, null);
            var html = await Operations.Instance.RenderAsync<Component09>(helper, context, null);

            NotepadPlusPlusOperator.Instance.WriteTextAndOpen(
                FilePaths.Instance.OutputHtmlFilePath,
                html);
        }
    }
}