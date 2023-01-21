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
            this.buttonLoadClients = new System.Windows.Forms.Button();
            this.columnHeaderDocument = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderClientBirthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.listViewClients.Location = new System.Drawing.Point(9, 8);
            this.listViewClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewClients.MultiSelect = false;
            this.listViewClients.Name = "listViewClients";
            this.listViewClients.Size = new System.Drawing.Size(826, 157);
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
            // buttonLoadClients
            // 
            this.buttonLoadClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadClients.Location = new System.Drawing.Point(694, 169);
            this.buttonLoadClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLoadClients.Name = "buttonLoadClients";
            this.buttonLoadClients.Size = new System.Drawing.Size(141, 31);
            this.buttonLoadClients.TabIndex = 1;
            this.buttonLoadClients.Text = "Загрузить список клиентов";
            this.buttonLoadClients.UseVisualStyleBackColor = true;
            this.buttonLoadClients.Click += new System.EventHandler(this.buttonLoadClients_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(843, 668);
            this.Controls.Add(this.buttonLoadClients);
            this.Controls.Add(this.listViewClients);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}

