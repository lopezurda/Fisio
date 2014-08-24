using System;
using System.Web;
using System.Web.UI;
using log4net;
using log4net.Config;


namespace Fisio
{
	public partial class Default : System.Web.UI.Page
	{
		private static readonly ILog logger = LogManager.GetLogger(typeof(Default));

		public void button1Clicked (object sender, EventArgs args)
		{

			log4net.Config.XmlConfigurator.Configure();
//			BasicConfigurator.Configure();
			button1.Text = "You clicked me";
			logger.Info ("--------- Hecho -------");
		}
	}
}

