using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
namespace JamesApp
{
    class FTPServer
    {
        private static string host = "home194014715.1and1-data.host";
        // Enter your sftp username here
        private static string username = "u44016516-twineview";
        // Enter your sftp password here
        private static string password = @"Sara!@#100";
        public static int Send(string fileName)
        {
            var connectionInfo = new ConnectionInfo(host, "u44016516-twineview", new PasswordAuthenticationMethod(username, password));
            // Upload File
            using (var sftp = new SftpClient(connectionInfo))
            {

                sftp.Connect();
                //sftp.ChangeDirectory("/MyFolder");
                using (var uplfileStream = System.IO.File.OpenRead(fileName))
                {
                    sftp.UploadFile(uplfileStream, fileName, true);
                }
                sftp.Disconnect();
            }
            return 0;
        }
    }
}
