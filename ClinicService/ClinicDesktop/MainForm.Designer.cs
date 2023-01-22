﻿namespace ClinicDesktop
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
            this.listViewClients.Size = new System.Drawing.Size(827, 221);
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
            this.buttonLoadClients.Location = new System.Drawing.Point(652, 239);
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
            this.buttonCreateClient.Location = new System.Drawing.Point(458, 241);
            this.buttonCreateClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreateClient.Name = "buttonCreateClient";
            this.buttonCreateClient.Size = new System.Drawing.Size(188, 42);
            this.buttonCreateClient.TabIndex = 2;
            this.buttonCreateClient.Text = "Создать нового клиента";
            this.buttonCreateClient.UseVisualStyleBackColor = true;
            this.buttonCreateClient.Click += new System.EventHandler(this.buttonCreateClient_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(851, 946);
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
    }
}

