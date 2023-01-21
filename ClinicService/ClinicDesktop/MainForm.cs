using ClinicServiceClientNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicDesktop
{
    /// <summary>
    /// НЕОБХОДИМО ПОДКЛЮЧИТЬ СБОРКУ: System.Runtime.Serialization
    /// 
    /// 
    /// ДОМАШНЕЕ ЗАДАНИЕ:
    /// 
    /// Разработать приложение ClinicDesctop, подключить ClinicService к вашему клиентскому приложению.
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonLoadClients_Click(object sender, EventArgs e)
        {
            ClinicServiseClient clinicServiseClient = 
                new ClinicServiseClient("http://localhost:5231/", new System.Net.Http.HttpClient());

            ICollection<Client> clients = clinicServiseClient.ClientGetAllAsync().Result;   

            listViewClients.Items.Clear();
            foreach (Client client in clients)
            {
                ListViewItem item = new ListViewItem();
                item.Text = client.ClientId.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.SurName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.FirstName
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Patronymic
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Document
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = client.Birthday.ToString()
                });

                listViewClients.Items.Add(item);
            }
        }
    }
}
