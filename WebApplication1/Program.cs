var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    //pattern: "{controller=Home}/{action=Index}/{id?}");
    pattern: "{controller=Ogrenci}/{action=Index}/{id?}");

//controller parametresi gönder eger aprametre gelemzse home controlleri cagir
//action method ismi gönderilecek /'tan sonrasi, action gonderilmezse default olarak index calistir
//? ister gönder ister gonderme olarak çalisir id.


app.Run();

//mvc niy  var front end backend ve db kismini ayirmak icin cikmisitir, tek dosyada olmasin 
//kullanim ve denetim daha kolay olsun diye kullaniliyor

//standar web root nerede framework 6 da
//Program cs veya startup cs ayni anda olmaz

//      _____/ogrlist.php?classid=15  -> php, get method
//      /ogrenci/listele/15
