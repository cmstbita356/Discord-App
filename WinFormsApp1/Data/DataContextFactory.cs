//using DiscordApp.Data
//using Microsoft.EntityFrameworkCore.Design;
//using Microsoft.EntityFrameworkCore;

//internal class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
//{
//	public DataContext CreateDbContext(string[] args)
//	{
//		var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
//		optionsBuilder.UseSqlServer("Data Source=.\\BITA;Initial Catalog=Mail;Integrated Security=True;Trust Server Certificate=True");

//		return new DataContext(optionsBuilder.Options);
//	}
//}