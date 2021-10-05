using Architecture.Implementations;
using Architecture.Implementations.Authenticate;
using Architecture.Persistence.Entity.Data;
using Domain.Contract;
using Domain.Contract.Authenticate;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Text;

namespace TravelApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidAudience = Configuration["Jwt:Issuer"],
                    ValidIssuer = Configuration["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                };
            });

            Assembly a = Assembly.Load("Application");
            services.AddMediatR(a);

            string conexion = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DataContext>(x => x.UseSqlServer(conexion));

            services.AddScoped<ICreateAuthor, EntityFrameworkCreateAuthor>();
            services.AddScoped<IAuthUserRepository, InEntityAuthUserRepository>();
            services.AddScoped<ICreateUserRepository, InEntityCreateUserRepository>();
            services.AddScoped<ICreateEditorial, EntityFrameworkCreateEditorial>();
            services.AddScoped<ICreateBook, EntityFrameworkCreateBook>();
            services.AddScoped<ICreateCustomer, EntityFrameworkCreateCustomer>();
            services.AddScoped<ICreateInvoice, EntityFrameworkCreateInvoice>();
            services.AddScoped<IUpdateBalance, EntityFrameworkUpdateBalance>();
            services.AddScoped<ISearchBook, InEntitySearchBookRepository>();
            services.AddLogging();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
