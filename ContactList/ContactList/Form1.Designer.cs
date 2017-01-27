namespace ContactList
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblErr = new System.Windows.Forms.Label();
            this.pbSave = new System.Windows.Forms.PictureBox();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.smallImageList = new System.Windows.Forms.ImageList(this.components);
            this.largeImageList = new System.Windows.Forms.ImageList(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.LargeImageList = this.largeImageList;
            this.listView1.Location = new System.Drawing.Point(0, 292);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(353, 145);
            this.listView1.SmallImageList = this.smallImageList;
            this.listView1.TabIndex = 1;
            this.listView1.TileSize = new System.Drawing.Size(200, 200);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // tbFirstName
            // 
            this.tbFirstName.BackColor = System.Drawing.SystemColors.Control;
            this.tbFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFirstName.Location = new System.Drawing.Point(75, 93);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(93, 13);
            this.tbFirstName.TabIndex = 5;
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.SystemColors.Control;
            this.tbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPhone.Location = new System.Drawing.Point(97, 121);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(177, 13);
            this.tbPhone.TabIndex = 7;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.Control;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Location = new System.Drawing.Point(97, 162);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(177, 13);
            this.tbEmail.TabIndex = 8;
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.Location = new System.Drawing.Point(89, 273);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(0, 13);
            this.lblErr.TabIndex = 11;
            // 
            // pbSave
            // 
            this.pbSave.Image = global::ContactList.Properties.Resources.commit;
            this.pbSave.Location = new System.Drawing.Point(258, 219);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(16, 16);
            this.pbSave.TabIndex = 13;
            this.pbSave.TabStop = false;
            this.pbSave.Click += new System.EventHandler(this.pbSave_Click);
            // 
            // pbEdit
            // 
            this.pbEdit.Image = global::ContactList.Properties.Resources.delete;
            this.pbEdit.InitialImage = global::ContactList.Properties.Resources.edit;
            this.pbEdit.Location = new System.Drawing.Point(236, 219);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.Size = new System.Drawing.Size(16, 16);
            this.pbEdit.TabIndex = 12;
            this.pbEdit.TabStop = false;
            this.pbEdit.Click += new System.EventHandler(this.pbEdit_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ContactList.Properties.Resources.email;
            this.pictureBox3.InitialImage = global::ContactList.Properties.Resources.email;
            this.pictureBox3.Location = new System.Drawing.Point(75, 160);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ContactList.Properties.Resources.phone;
            this.pictureBox2.InitialImage = global::ContactList.Properties.Resources.phone;
            this.pictureBox2.Location = new System.Drawing.Point(75, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pbIcon
            // 
            this.pbIcon.Image = global::ContactList.Properties.Resources.profile;
            this.pbIcon.InitialImage = global::ContactList.Properties.Resources.profile;
            this.pbIcon.Location = new System.Drawing.Point(155, 52);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(32, 32);
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // tbLastName
            // 
            this.tbLastName.BackColor = System.Drawing.SystemColors.Control;
            this.tbLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLastName.Location = new System.Drawing.Point(174, 93);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 13);
            this.tbLastName.TabIndex = 14;
            // 
            // smallImageList
            // 
            this.smallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImageList.ImageStream")));
            this.smallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.smallImageList.Images.SetKeyName(0, "profile16x16.png");
            // 
            // largeImageList
            // 
            this.largeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImageList.ImageStream")));
            this.largeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.largeImageList.Images.SetKeyName(0, "profile.png");
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Contacts";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 437);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.pbEdit);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pbIcon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.PictureBox pbEdit;
        private System.Windows.Forms.PictureBox pbSave;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.ImageList smallImageList;
        private System.Windows.Forms.ImageList largeImageList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

