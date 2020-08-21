using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class MyStartup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async context => {
                await context.Response.WriteAsync("Hello world");
            
            });
        }
    }
    
}
