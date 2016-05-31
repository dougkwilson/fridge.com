using AspNet.Identity.PostgreSQL;

namespace Website.Models
{
	public class ApplicationDbContext : PostgreSQLDatabase
	{
		public ApplicationDbContext()
				: base(WebApiApplication.ConnectionStringName) {
		}

		public static ApplicationDbContext Create() {
			return new ApplicationDbContext();
		}
	}
}