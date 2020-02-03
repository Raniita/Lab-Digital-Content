using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

namespace Calculadora
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Creamos el canal para el cliente
            HttpClientChannel channel = new HttpClientChannel();

            // Registramos el canal
            ChannelServices.RegisterChannel(channel, false);

            // Registramos el objeto remoto del servidor
            WellKnownClientTypeEntry remote = new WellKnownClientTypeEntry(typeof(objeto_op.operaciones), "http://localhost:9090/Operaciones");
            RemotingConfiguration.RegisterWellKnownClientType(remote);

            // Ya podemos arrancar la aplicacion
            Application.Run(new Form1());
        }
    }
}
