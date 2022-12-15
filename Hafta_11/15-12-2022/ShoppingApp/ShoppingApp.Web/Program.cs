using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Business.Concrete;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete;
using ShoppingApp.Data.Concrete.EfCore.Contexts;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.EmailServices.Abstract;
using ShoppingApp.Web.EmailServices.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<IdentityContext>(optipns=>optipns.UseSqlite("Data Source=ShoppingApp.db"));
builder.Services.AddDbContext<ShopAppContext>();


builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IEmailSender, SmtpEmailSender>(x=> new
SmtpEmailSender (
    "smtp.office365.com",587,true,"wissen_core@hotmail.com","wissen123."
    ));


builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<IdentityContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    #region PasswordSettings
    options.Password.RequireDigit=true;//Þifrede içinde mutlaka rakam bulunsun dedik.
    options.Password.RequireLowercase=true;//Þifrede içinde mutlaka küçük harf bulunsun dedik.
    options.Password.RequireUppercase=true;//Þifrede içinde mutlaka büyük harf bulunsun dedik.
    options.Password.RequiredLength=6;//Þifre en az 6 karakter olsun
    options.Password.RequireNonAlphanumeric=true;//Þifre içinde en az bir alfanumerik karakter (.,*/) gibi bulunmasý zorunlu olsun.
    #endregion
    #region LoginSettings
    options.Lockout.MaxFailedAccessAttempts=5;// BAþarýsýz giriþ deneme sayýsý max 5 olsun dedik . % kez ahatalý giriþ olursa hesap kilitlenir
    options.Lockout.DefaultLockoutTimeSpan=TimeSpan.FromSeconds(30); // Kilitlenmiþ hesabýn tkerar giriþ denemesi yapasý için 5 dk beklemesi gerek dedik.
    #endregion
    #region UserSettings
    options.User.RequireUniqueEmail = true; // Benzersiz email adresi ile kayýt olunur. Yani önceden kayýt olunmuþ e mail ile kayýt olunamaz.
    #region UserSettings
    options.User.RequireUniqueEmail = true; // Benzersiz email adresi ile kayýt olunur. Yani önceden kayýt olunmuþ e mail ile kayýt olunamaz.
    #endregion
    #region UserSettings
    options.User.RequireUniqueEmail = true; // Benzersiz email adresi ile kayýt olunur. Yani önceden kayýt olunmuþ e mail ile kayýt olunamaz.
    #endregion
    #region UserSettings
    options.User.RequireUniqueEmail = true; // Benzersiz email adresi ile kayýt olunur. Yani önceden kayýt olunmuþ e mail ile kayýt olunamaz.
    #region UserSettings
    options.User.RequireUniqueEmail = true; // Benzersiz email adresi ile kayýt olunur. Yani önceden kayýt olunmuþ e mail ile kayýt olunamaz.
    #endregion
    #region UserSettings
    options.User.RequireUniqueEmail = true; // Benzersiz email adresi ile kayýt olunur. Yani önceden kayýt olunmuþ e mail ile kayýt olunamaz.
    #endregion
    #endregion
    #endregion
    #region SignInSettings
    options.SignIn.RequireConfirmedEmail = false; // Kullanýcýdan e mail onayý istenir.
    options.SignIn.RequireConfirmedPhoneNumber = false;// Tel no ile onaylama
    #endregion
});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/account/login"; // Eðer açýlabilmesi için login olmanýn zorunlu olduðu bir istekte bulunulursa,kullanýcýnýn yönlendireceði sayfa burasý olacaktýr.(account controller daki login action metotu)
    options.LogoutPath = "/account/logout";// Kullanýcý çýkýþ yaptýðýnda yönlendirecek sayfa
    options.AccessDeniedPath = "/account/accessdenied";//Yetkisiz giriþ sýrasýnda yönlendirilecek sayfa.
    options.SlidingExpiration = true;//Varsayýlan cookie yaþam süresinin(20dk) yada ayarlanan yaþam süresinin her yeni istek sýrasýnda sýfýrlanacak yeniden baþlamýsný saðlar
    options.ExpireTimeSpan=TimeSpan.FromMinutes(5);// Yaþam süresini ayarlama 
    options.Cookie = new CookieBuilder
    {
        HttpOnly = true,// Http formatýnda çalýþacak
        Name=".ShoppingApp.Security.Cookie",
        SameSite=SameSiteMode.Strict
    };

});


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "products",
    pattern: "kategori/{categoryurl?}",
    defaults: new { controller = "Shop", action = "ProductList" }
    );

app.MapControllerRoute(
    name:"productdetails",
    pattern:"urunler/{producturl}",
    defaults: new {controller="Shop", action="ProductDetails"}
    );


app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"); ;

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
