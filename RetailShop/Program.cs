using Microsoft.EntityFrameworkCore;
using RetailShop.Repository;
using RetailShop.Repository.Implementation;
using RetailShop.Service;

var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

           builder.Services.AddTransient<IProductService, ProductService>();
           builder.Services.AddTransient<ProductRepository>();
           builder.Services.AddAutoMapper(typeof(mapper));
     
//TODO: add connectionstring
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ProductCs")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();