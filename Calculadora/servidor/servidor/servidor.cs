using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

namespace servidor
{
    class servidor
    {
        static void Main(string[] args)
        {
            // Creamos el canal http
            HttpServerChannel channel = new HttpServerChannel(9090);

            // Registramos el canal creado
            ChannelServices.RegisterChannel(channel, false);

            // Registramos el objeto remoto a usar
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(objeto_op.operaciones),
                "Operaciones",
                WellKnownObjectMode.SingleCall);
            
            // Quedamos en espera del usuario
            Console.WriteLine("Press ENTER to exit");
            Console.ReadLine();
            Console.WriteLine("Exiting...");
        }
    }
}
