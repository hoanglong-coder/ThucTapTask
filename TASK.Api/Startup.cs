using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using TASK.Application.MChiTietTuan;
using TASK.Application.MDuAn;
using TASK.Application.MLogin;
using TASK.Application.MQuyen;
using TASK.Application.MTuanLamViec;
using TASK.Application.MUser;
using TASK.Application.MToDoList;
using TASK.Application.MChart;
using TASK.Application.MCongViec;
using TASK.Data;
using TASK.Application.MDanhGiaNhanSu;

namespace TASK.Api
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

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));


            //Add sql
            services.AddDbContext<TaskDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            //Add DI

            services.AddScoped<IQuyenService, QuyenService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IDuAnService, DuAnService>();
            services.AddScoped<ITuanLamViecService, TuanLamViecService>();
            services.AddScoped<IChiTietTuanService, ChiTietTuanService>();
            services.AddScoped<IToDoListService, ToDoListService>();
            services.AddScoped<IChartService, ChartService>();
            services.AddScoped<ICongViecService, CongViecService>();
            services.AddScoped<IDanhGiaThangService, DanhGiaThangService>();
            services.AddScoped<IDanhGiaTuanService, DanhGiaTuanService>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TASK.Api", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TASK.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("MyPolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
