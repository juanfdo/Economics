using System;
using System.IO;
using System.Net;

namespace http_dollar_request
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			MainClass.recuest();
            
        }
		public static string recuest(){
			HttpWebRequest peticion = (HttpWebRequest)WebRequest.Create("http://www.elcolombiano.com");         
			HttpWebResponse respuesta = (HttpWebResponse)peticion.GetResponse();
			string html = new StreamReader(respuesta.GetResponseStream()).ReadToEnd();

			string aBuscar = "<div class=\"indicador\"> <h5>DOLAR</h5> <span> $";

			int i = html.IndexOf(aBuscar, StringComparison.InvariantCultureIgnoreCase);
			i += aBuscar.Length;
			int f = html.IndexOf("\r", i, StringComparison.InvariantCultureIgnoreCase);

			string str = html.Substring(i,f-i);
            
            Console.WriteLine(str);
			return (str);
		}
    }
}
