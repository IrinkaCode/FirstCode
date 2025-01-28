using FirstCode;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();

builder.SetBasePath(Directory.GetCurrentDirectory());
// получаем конфигурацию из файла myDataBaseConfigurations.json

builder.AddJsonFile("configuration_database.json");
// создаем конфигурацию

var config = builder.Build();
// получаем строку подключения

var connectionString = config.GetConnectionString("DefaultConnection");
var optionsBuilder = new DbContextOptionsBuilder<DataBaseContext>();
var version = new MySqlServerVersion(new Version(8, 0, 25));
var options = optionsBuilder.UseMySql(connectionString, version).Options;


List<User> users = new List<User>()
{
    new User("user1","user1@mail.ry",45,"To tam to tam",new TelephoneNumber("79812343434")),
    new User("user2","use2@mail.ry",23,"dfghgk",new TelephoneNumber("7981258967")),
    new User("user3","user3@mail.ry",35,"ertrhjk",new TelephoneNumber("79216125854"))

};
using (DataBaseContext context = new DataBaseContext())
{
    context.AddRange(users);
    context.SaveChanges();
}

