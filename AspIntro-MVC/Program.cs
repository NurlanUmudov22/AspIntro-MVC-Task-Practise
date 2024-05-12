var builder = WebApplication.CreateBuilder(args);


//middleware suzgec hissesi filtrlenme


builder.Services.AddControllersWithViews();  //mvc istifade edildiyini gosterir.


var app = builder.Build();


//middleware suzgec hissesi filtrlenme


app.MapControllerRoute(                     //important
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");




app.Run();
