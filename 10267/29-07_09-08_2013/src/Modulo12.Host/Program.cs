namespace Modulo12.Host
{
	using Topshelf;

	internal class Program
	{
		private static void Main(string[] args)
		{
			HostFactory.Run(x =>
			{
				x.UseNLog();

				x.Service<HostBootstrapper>(
					s =>
					{
						s.ConstructUsing(z => new HostBootstrapper());
						s.WhenStarted(tc => tc.Start());
						s.WhenStopped(tc => tc.Stop());
					});

				x.RunAsLocalSystem();

				x.SetDescription("Host do Modulo12");
				x.SetDisplayName("Modulo12.Host");
				x.SetServiceName("Modulo12.Host");
			});
		}
	}
}