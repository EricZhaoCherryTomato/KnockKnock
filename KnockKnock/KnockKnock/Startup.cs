using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.Owin;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Owin;

[assembly: OwinStartup(typeof(KnockKnock.Startup))]

namespace KnockKnock
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            //ConfigureAuth(app);
            WebApiConfig.Register(config);
            app.UseWebApi(config);

            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Formatters.JsonFormatter.SerializerSettings.Converters.Add(new StringEnumConverter());
        }
    }
}
