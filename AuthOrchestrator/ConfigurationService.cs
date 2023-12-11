//using Microsoft.IdentityModel.Tokens;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using StackExchange.Redis;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
//using System.Text;
//using System.Reflection;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.Hosting;
//using AuthOrchestrator.Redis;

//namespace AuthOrchestrator
//{
//    public static class ConfigurationService
//    {
//        public static IConfigurationBuilder LoadConfigurationBuilder(IHostEnvironment env)
//        {
//            var builder = new ConfigurationBuilder()
//                .SetBasePath(env.ContentRootPath)
//                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
//                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

//            return builder;
//        }

//        public static IConfigurationRoot LoadConfiguration()
//        {
//            var builder = new ConfigurationBuilder()
//                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
//                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
//                .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: true);

//            return builder.Build();
//        }

//        public static void AddRedisServices(this IServiceCollection services, IConfiguration configuration)
//        {
//            // Configure Redis
//            var redisSettings = new RedisSettings();
//            configuration.GetSection("Redis").Bind(redisSettings);

//            services.AddSingleton(redisSettings);
//            services.AddSingleton<IConnectionMultiplexer>(sp =>
//                ConnectionMultiplexer.Connect(redisSettings.Configuration));

//            services.AddSingleton<IRedisHelper, RedisHelper>();
//            services.AddTransient<IRedisService, RedisService>();
//        }

//        public static void ConfigureJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
//        {
//            var jwtSettings = configuration.GetSection("JwtSettings");
//            var key = Encoding.ASCII.GetBytes(jwtSettings["Key"]);

//            services.AddAuthentication(x =>
//            {
//                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//            })
//            .AddJwtBearer(x =>
//            {
//                x.RequireHttpsMetadata = false;
//                x.SaveToken = true;
//                x.TokenValidationParameters = new TokenValidationParameters
//                {
//                    ValidateIssuerSigningKey = true,
//                    IssuerSigningKey = new SymmetricSecurityKey(key),
//                    ValidateIssuer = false,
//                    //ValidIssuer = jwtSettings["Issuer"],
//                    ValidateAudience = false,
//                    //ValidAudience = jwtSettings["Audience"]
//                };
//            });
//        }
//    }
//}
