namespace Modulo12.Host
{
	using System;
	using System.ServiceModel;
	using Core.Services;
	using NLog;

	public class HostBootstrapper
	{
		private Logger _logger = LogManager.GetCurrentClassLogger();
		private ServiceHost _host;

		public void Start()
		{
			_logger.Debug("Start");

			_host = new ServiceHost(typeof (CatalogoService), new Uri[0]);
			
			_host.Open();
		}

		public void Stop()
		{
			_logger.Debug("Stop");

			if (_host != null)
			{
				_host.Close();
			}
		}
	}
}