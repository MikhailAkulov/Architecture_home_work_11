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

        private void buttonCreateClient_Click(object sender, EventArgs e)
        {
            ClinicServiseClient clinicServiseClient =
                new ClinicServiseClient("http://localhost:5231/", new System.Net.Http.HttpClient());

            int res = clinicServiseClient.ClientCreateAsync(new CreateClientRequest()
            {
                Birthday = DateTime.Now,
                Document = "Документ",
                FirstName = "Имя",
                SurName = "Фамилия",
                Patronymic = "Отчество",
            }).Result;
        }

        private void buttonLoadPets_Click(object sender, EventArgs e)
        {
            ClinicServiseClient clinicServiseClient = 
                new ClinicServiseClient("http://localhost:5231/", new System.Net.Http.HttpClient());

            ICollection<Pet> pets = clinicServiseClient.PetGetAllAsync().Result;

            listViewPets.Items.Clear();
            foreach (Pet pet in pets)
            {
                ListViewItem item = new ListViewItem();
                item.Text = pet.PetId.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = pet.ClientId.ToString()
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = pet.Name
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = pet.Birthday.ToString()
                });
                
                listViewPets.Items.Add(item);
            }
        }

        private void buttonLoadConsultations_Click(object sender, EventArgs e)
        {
            ClinicServiseClient clinicServiseClient = 
                new ClinicServiseClient("http://localhost:5231/", new System.Net.Http.HttpClient());

            ICollection<Consultation> consultations = clinicServiseClient.ConsultationGetAllAsync().Result;

            listViewConsultations.Items.Clear();
            foreach (Consultation consultation in consultations)
            {
                ListViewItem item = new ListViewItem();
                item.Text = consultation.ConsultationId.ToString();
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = consultation.ClientId.ToString()
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = consultation.PetId.ToString()
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = consultation.ConsultationDate.ToString()
                });
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = consultation.Description
                });

                listViewConsultations.Items.Add(item);
            }
        }
    }
}
