namespace ClinicDesktop
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewClients = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSurName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPatronymic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDocument = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClientBirthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonLoadClients = new System.Windows.Forms.Button();
            this.buttonCreateClient = new System.Windows.Forms.Button();
            this.listViewPets = new System.Windows.Forms.ListView();
            this.columnHeaderPetId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClientId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPetBirthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonLoadPets = new System.Windows.Forms.Button();
            this.listViewConsultations = new System.Windows.Forms.ListView();
            this.columnHeaderConsultationId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderConsultationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonLoadConsultations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewClients
            // 
            this.listViewClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderSurName,
            this.columnHeaderFirstName,
            this.columnHeaderPatronymic,
            this.columnHeaderDocument,
            this.columnHeaderClientBirthday});
            this.listViewClients.FullRowSelect = true;
            this.listViewClients.GridLines = true;
            this.listViewClients.HideSelection = false;
            this.listViewClients.Location = new System.Drawing.Point(12, 11);
            this.listViewClients.MultiSelect = false;
            this.listViewClients.Name = "listViewClients";
            this.listViewClients.Size = new System.Drawing.Size(793, 212);
            this.listViewClients.TabIndex = 0;
            this.listViewClients.UseCompatibleStateImageBehavior = false;
            this.listViewClients.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "#";
            this.columnHeaderId.Width = 30;
            // 
            // columnHeaderSurName
            // 
            this.columnHeaderSurName.Text = "Фамилия";
            this.columnHeaderSurName.Width = 150;
            // 
            // columnHeaderFirstName
            // 
            this.columnHeaderFirstName.Text = "Имя";
            this.columnHeaderFirstName.Width = 150;
            // 
            // columnHeaderPatronymic
            // 
            this.columnHeaderPatronymic.Text = "Отчество";
            this.columnHeaderPatronymic.Width = 150;
            // 
            // columnHeaderDocument
            // 
            this.columnHeaderDocument.Text = "Документ";
            this.columnHeaderDocument.Width = 150;
            // 
            // columnHeaderClientBirthday
            // 
            this.columnHeaderClientBirthday.Text = "Дата рождения";
            this.columnHeaderClientBirthday.Width = 150;
            // 
            // buttonLoadClients
            // 
            this.buttonLoadClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadClients.Location = new System.Drawing.Point(618, 230);
            this.buttonLoadClients.Name = "buttonLoadClients";
            this.buttonLoadClients.Size = new System.Drawing.Size(188, 44);
            this.buttonLoadClients.TabIndex = 1;
            this.buttonLoadClients.Text = "Загрузить список клиентов";
            this.buttonLoadClients.UseVisualStyleBackColor = true;
            this.buttonLoadClients.Click += new System.EventHandler(this.buttonLoadClients_Click);
            // 
            // buttonCreateClient
            // 
            this.buttonCreateClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateClient.Location = new System.Drawing.Point(423, 230);
            this.buttonCreateClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreateClient.Name = "buttonCreateClient";
            this.buttonCreateClient.Size = new System.Drawing.Size(188, 42);
            this.buttonCreateClient.TabIndex = 2;
            this.buttonCreateClient.Text = "Создать нового клиента";
            this.buttonCreateClient.UseVisualStyleBackColor = true;
            this.buttonCreateClient.Click += new System.EventHandler(this.buttonCreateClient_Click);
            // 
            // listViewPets
            // 
            this.listViewPets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPetId,
            this.columnHeaderClientId,
            this.columnHeaderName,
            this.columnHeaderPetBirthday});
            this.listViewPets.FullRowSelect = true;
            this.listViewPets.GridLines = true;
            this.listViewPets.HideSelection = false;
            this.listViewPets.Location = new System.Drawing.Point(12, 279);
            this.listViewPets.MultiSelect = false;
            this.listViewPets.Name = "listViewPets";
            this.listViewPets.Size = new System.Drawing.Size(794, 218);
            this.listViewPets.TabIndex = 3;
            this.listViewPets.UseCompatibleStateImageBehavior = false;
            this.listViewPets.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderPetId
            // 
            this.columnHeaderPetId.Text = "Id Питимца";
            this.columnHeaderPetId.Width = 140;
            // 
            // columnHeaderClientId
            // 
            this.columnHeaderClientId.Text = "Id Владельца";
            this.columnHeaderClientId.Width = 140;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Кличка Питомца";
            this.columnHeaderName.Width = 250;
            // 
            // columnHeaderPetBirthday
            // 
            this.columnHeaderPetBirthday.Text = "Дата рождения питомца";
            this.columnHeaderPetBirthday.Width = 250;
            // 
            // buttonLoadPets
            // 
            this.buttonLoadPets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadPets.Location = new System.Drawing.Point(583, 502);
            this.buttonLoadPets.Name = "buttonLoadPets";
            this.buttonLoadPets.Size = new System.Drawing.Size(222, 43);
            this.buttonLoadPets.TabIndex = 4;
            this.buttonLoadPets.Text = "Загрузить список питомцев";
            this.buttonLoadPets.UseVisualStyleBackColor = true;
            this.buttonLoadPets.Click += new System.EventHandler(this.buttonLoadPets_Click);
            // 
            // listViewConsultations
            // 
            this.listViewConsultations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewConsultations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderConsultationId,
            this.columnHeaderClient,
            this.columnHeaderPet,
            this.columnHeaderConsultationDate,
            this.columnHeaderDescription});
            this.listViewConsultations.FullRowSelect = true;
            this.listViewConsultations.GridLines = true;
            this.listViewConsultations.HideSelection = false;
            this.listViewConsultations.Location = new System.Drawing.Point(12, 551);
            this.listViewConsultations.MultiSelect = false;
            this.listViewConsultations.Name = "listViewConsultations";
            this.listViewConsultations.Size = new System.Drawing.Size(794, 217);
            this.listViewConsultations.TabIndex = 5;
            this.listViewConsultations.UseCompatibleStateImageBehavior = false;
            this.listViewConsultations.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderConsultationId
            // 
            this.columnHeaderConsultationId.Text = "Id Консультации";
            this.columnHeaderConsultationId.Width = 120;
            // 
            // columnHeaderClient
            // 
            this.columnHeaderClient.Text = "Id Клиента";
            this.columnHeaderClient.Width = 130;
            // 
            // columnHeaderPet
            // 
            this.columnHeaderPet.Text = "Id Животного";
            this.columnHeaderPet.Width = 130;
            // 
            // columnHeaderConsultationDate
            // 
            this.columnHeaderConsultationDate.Text = "Дата консультации";
            this.columnHeaderConsultationDate.Width = 200;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Примечание";
            this.columnHeaderDescription.Width = 200;
            // 
            // buttonLoadConsultations
            // 
            this.buttonLoadConsultations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadConsultations.Location = new System.Drawing.Point(583, 774);
            this.buttonLoadConsultations.Name = "buttonLoadConsultations";
            this.buttonLoadConsultations.Size = new System.Drawing.Size(222, 42);
            this.buttonLoadConsultations.TabIndex = 6;
            this.buttonLoadConsultations.Text = "Загрузить список консультаций";
            this.buttonLoadConsultations.UseVisualStyleBackColor = true;
            this.buttonLoadConsultations.Click += new System.EventHandler(this.buttonLoadConsultations_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(817, 946);
            this.Controls.Add(this.buttonLoadConsultations);
            this.Controls.Add(this.listViewConsultations);
            this.Controls.Add(this.buttonLoadPets);
            this.Controls.Add(this.listViewPets);
            this.Controls.Add(this.buttonCreateClient);
            this.Controls.Add(this.buttonLoadClients);
            this.Controls.Add(this.listViewClients);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моя клиника";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewClients;
        private System.Windows.Forms.Button buttonLoadClients;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderSurName;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderPatronymic;
        private System.Windows.Forms.ColumnHeader columnHeaderDocument;
        private System.Windows.Forms.ColumnHeader columnHeaderClientBirthday;
        private System.Windows.Forms.Button buttonCreateClient;
        private System.Windows.Forms.ListView listViewPets;
        private System.Windows.Forms.ColumnHeader columnHeaderPetId;
        private System.Windows.Forms.ColumnHeader columnHeaderClientId;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderPetBirthday;
        private System.Windows.Forms.Button buttonLoadPets;
        private System.Windows.Forms.ListView listViewConsultations;
        private System.Windows.Forms.ColumnHeader columnHeaderConsultationId;
        private System.Windows.Forms.ColumnHeader columnHeaderClient;
        private System.Windows.Forms.ColumnHeader columnHeaderPet;
        private System.Windows.Forms.ColumnHeader columnHeaderConsultationDate;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.Button buttonLoadConsultations;
    }
}

