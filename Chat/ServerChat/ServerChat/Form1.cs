using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ServerChat
{
    public partial class Form1 : Form
    {
        private UdpClient udpclient;
        private IPAddress multicast;
        private IPEndPoint remote;
        private byte[] receive;
        private String msg;
        private String prev_msg;
        private String timestamp;

        public Form1()
        {
            // Una solucion para modificar el Form desde el Thread es: (no la mas elegante)
            Control.CheckForIllegalCrossThreadCalls = false;

            InitializeComponent();
            // Creamos el cliente UDP que dejamos a la escucha
            udpclient = new UdpClient(8080);
            // Definimos la IP del grupo multicast
            multicast = IPAddress.Parse("224.1.0.1");
            // Unimos el cliente UDP al grupo multicast
            udpclient.JoinMulticastGroup(multicast);
            // Definimos que no tiene destino
            remote = null;

            // Configuracion de los threads
            Thread thread = new Thread(new ThreadStart(UDP_newMsg_handler));
            thread.Start();

             // Actualizamos el Form
            textBox2.Text = String.Format("Started on: {0}", multicast.ToString());
        }

        private void UpdateForm_newMsg(String mMsg)
        {
            prev_msg = textBox1.Text;

            listBox1.Items.Add(prev_msg);
            textBox1.Text = String.Format("{0} >> {1}", timestamp, mMsg);
        }

        private void UDP_newMsg_handler(){
            while (true)
            {
                // Recibimos la informacion del canal
                receive = udpclient.Receive(ref remote);
                msg = Encoding.UTF8.GetString(receive, 0, receive.Length);
                // Actualizamos el timestamp con el ultimo mensaje
                timestamp = DateTime.Now.ToString("HH:mm");

                // Actualizamos la lista de mensajes recibidos
                UpdateForm_newMsg(msg);
            }
        }
    }
}
