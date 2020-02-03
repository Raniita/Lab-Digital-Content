using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace ClientChat
{
    public partial class Form1 : Form
    {
        private UdpClient client;
        private IPAddress multicast;
        private IPEndPoint remote;
        private String msg2send;
        private byte[] encodedMsg;
        private String uuid;

        public Form1()
        {
            InitializeComponent();
            // Inicializamos el componente UDP y lo conectamos al grupo multicast
            client = new UdpClient();
            multicast = IPAddress.Parse("224.1.0.1");
            remote = new IPEndPoint(multicast, 8080);

            // Actualizamos informacion
            textBox1.Text = String.Format("Connected to: {0}", multicast.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Generamos un identificador 
                if (textBox2.Text == "")
                {
                    uuid ="client";
                }
                else
                {
                    uuid = textBox2.Text;
                }

                // Extraemos el mensaje y lo encodeamos
                msg2send = String.Format("{0} > {1}", uuid, richTextBox1.Text);
                encodedMsg = Encoding.UTF8.GetBytes(msg2send);

                // Enviamos el mensaje
                client.Send(encodedMsg, encodedMsg.Length, remote);
            }
            catch
            {
                MessageBox.Show("Error al enviar el mensaje");
            }
        }
    }
}
