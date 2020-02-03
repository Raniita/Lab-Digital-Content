using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Net.Mail;

namespace smtp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Send_Click(object sender, EventArgs e)
        {
            // Si usamos gmail es necesario permitir cuentas no seguras
            try
            {
                MailMessage msg = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                // Obtenemos la info del Form y hacemos attach
                msg.From = new MailAddress(T2.Text);
                MailAddress to = new MailAddress(T1.Text);
                msg.To.Add(to);
                msg.Subject = T3.Text;
                msg.Body = T4.Text;

                // Comprobamos si se ha subido archivo
                if (fileAttach.HasFile)
                {
                    String filename = System.IO.Path.GetFileName(fileAttach.PostedFile.FileName);
                    Attachment info = new Attachment(fileAttach.PostedFile.InputStream, filename);
                    msg.Attachments.Add(info);
                }

                // SMTP CONFIG
                // Pruebo directamente con el SMTP de la upct (correo delegacion estudiantes)
                smtp.UseDefaultCredentials = false;
                smtp.Port = 587;
                smtp.Host = "mail.upct.es";
                smtp.Credentials = new System.Net.NetworkCredential("passw", password.Text);
                smtp.EnableSsl = true;
                smtp.Send(msg);

                status.Text = "Email Send";

            } catch(System.Net.Mail.SmtpException error){
                status.Text = error.Message;
            }
        }

        protected void status_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
