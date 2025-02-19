using BussinessLayer.Abstract;
using BussinessLayer.Concrate;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession();

// Authentication ve Authorization ayarlarý
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(x =>
    {
        x.LoginPath = "/Login/Index/";
    });

builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
                      .RequireAuthenticatedUser()
                      .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});

// Scoped Servis Baðýmlýlýklarý
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ICategoryDal, EfCategoryRepository>();

builder.Services.AddScoped<IBlogService, BlogManager>();
builder.Services.AddScoped<IBlogDal, EfBlogRepository>();

builder.Services.AddScoped<ICommentService, CommentManager>();
builder.Services.AddScoped<ICommentDal, EfCommentRepository>();

builder.Services.AddScoped<IWriterService, WriterManager>();
builder.Services.AddScoped<IWriterDal, EfWriterRepository>();

builder.Services.AddScoped<INewsLetterService, NewsLetterManager>();
builder.Services.AddScoped<INewsLetterDal, EfNewsLetterRepository>();

builder.Services.AddScoped<IAboutService, AboutManager>();
builder.Services.AddScoped<IAboutDal, EfAboutRepository>();

builder.Services.AddScoped<IContactService, ContactManager>();
builder.Services.AddScoped<IContactDal, EfContactRepository>();

var app = builder.Build();

// Middleware yapýlandýrmasý
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?code={0}");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSession();

app.UseRouting();
app.UseAuthentication(); // Önce kimlik doðrulama
app.UseAuthorization();  // Sonra yetkilendirme

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");





app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});


app.Run();


//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddControllersWithViews();

//builder.Services.AddSession();


////Authorize Ýþlemi
//builder.Services.AddMvc(config =>
//{
//    var policy = new AuthorizationPolicyBuilder()
//                      .RequireAuthenticatedUser()
//                      .Build();
//    config.Filters.Add(new AuthorizeFilter(policy));
//});

//builder.Services.AddMvc();
//builder.Services.AddAuthentication(
//    CookieAuthenticationDefaults.AuthenticationScheme)
//    .AddCookie(x =>
//    {
//        x.LoginPath = "/Login/Index/";
//    });


//builder.Services.AddScoped<ICategoryService, CategoryManager>();
//builder.Services.AddScoped<ICategoryDal, EfCategoryRepository>();


//builder.Services.AddScoped<IBlogService, BlogManager>();
//builder.Services.AddScoped<IBlogDal, EfBlogRepository>();


//builder.Services.AddScoped<ICommentService, CommentManager>();
//builder.Services.AddScoped<ICommentDal, EfCommentRepository>();

//builder.Services.AddScoped<IWriterService, WriterManager>();
//builder.Services.AddScoped<IWriterDal, EfWriterRepository>();

//builder.Services.AddScoped<INewsLetterService, NewsLetterManager>();
//builder.Services.AddScoped<INewsLetterDal, EfNewsLetterRepository>();

//builder.Services.AddScoped<IAboutService, AboutManager>();
//builder.Services.AddScoped<IAboutDal, EfAboutRepository>();

//builder.Services.AddScoped<IContactService, ContactManager>();
//builder.Services.AddScoped<IContactDal, EfContactRepository>();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?code={0}");

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseSession();

//app.UseAuthentication();
//app.UseRouting();

//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();




