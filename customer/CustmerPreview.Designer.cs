﻿
namespace customer
{
    partial class CustmerPreview
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
            this.lbCustmerName = new System.Windows.Forms.Label();
            this.lbCuntry = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbHobby = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.NameData = new System.Windows.Forms.Label();
            this.CuntryData = new System.Windows.Forms.Label();
            this.sexData = new System.Windows.Forms.Label();
            this.HobbyData = new System.Windows.Forms.Label();
            this.StatusData = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCustmerName
            // 
            this.lbCustmerName.AutoSize = true;
            this.lbCustmerName.Location = new System.Drawing.Point(61, 66);
            this.lbCustmerName.Name = "lbCustmerName";
            this.lbCustmerName.Size = new System.Drawing.Size(130, 25);
            this.lbCustmerName.TabIndex = 0;
            this.lbCustmerName.Text = "Custmer Name";
            // 
            // lbCuntry
            // 
            this.lbCuntry.AutoSize = true;
            this.lbCuntry.Location = new System.Drawing.Point(61, 124);
            this.lbCuntry.Name = "lbCuntry";
            this.lbCuntry.Size = new System.Drawing.Size(64, 25);
            this.lbCuntry.TabIndex = 1;
            this.lbCuntry.Text = "Cuntry";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Location = new System.Drawing.Point(61, 184);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(39, 25);
            this.lbSex.TabIndex = 2;
            this.lbSex.Text = "Sex";
            // 
            // lbHobby
            // 
            this.lbHobby.AutoSize = true;
            this.lbHobby.Location = new System.Drawing.Point(61, 240);
            this.lbHobby.Name = "lbHobby";
            this.lbHobby.Size = new System.Drawing.Size(67, 25);
            this.lbHobby.TabIndex = 3;
            this.lbHobby.Text = "Hobby";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(61, 315);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(60, 25);
            this.lbStatus.TabIndex = 4;
            this.lbStatus.Text = "Status";
            // 
            // NameData
            // 
            this.NameData.AutoSize = true;
            this.NameData.Location = new System.Drawing.Point(300, 66);
            this.NameData.Name = "NameData";
            this.NameData.Size = new System.Drawing.Size(0, 25);
            this.NameData.TabIndex = 5;
            // 
            // CuntryData
            // 
            this.CuntryData.AutoSize = true;
            this.CuntryData.Location = new System.Drawing.Point(300, 124);
            this.CuntryData.Name = "CuntryData";
            this.CuntryData.Size = new System.Drawing.Size(0, 25);
            this.CuntryData.TabIndex = 6;
            // 
            // sexData
            // 
            this.sexData.AutoSize = true;
            this.sexData.Location = new System.Drawing.Point(300, 184);
            this.sexData.Name = "sexData";
            this.sexData.Size = new System.Drawing.Size(0, 25);
            this.sexData.TabIndex = 7;
            // 
            // HobbyData
            // 
            this.HobbyData.AutoSize = true;
            this.HobbyData.Location = new System.Drawing.Point(300, 240);
            this.HobbyData.Name = "HobbyData";
            this.HobbyData.Size = new System.Drawing.Size(0, 25);
            this.HobbyData.TabIndex = 8;
            // 
            // StatusData
            // 
            this.StatusData.AutoSize = true;
            this.StatusData.Location = new System.Drawing.Point(300, 315);
            this.StatusData.Name = "StatusData";
            this.StatusData.Size = new System.Drawing.Size(0, 25);
            this.StatusData.TabIndex = 9;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(94, 380);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(164, 46);
            this.BtnBack.TabIndex = 10;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(377, 380);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(156, 46);
            this.BtnSubmit.TabIndex = 11;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // CustmerPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 438);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.StatusData);
            this.Controls.Add(this.HobbyData);
            this.Controls.Add(this.sexData);
            this.Controls.Add(this.CuntryData);
            this.Controls.Add(this.NameData);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbHobby);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.lbCuntry);
            this.Controls.Add(this.lbCustmerName);
            this.Name = "CustmerPreview";
            this.Text = "Custmer_Preview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCustmerName;
        private System.Windows.Forms.Label lbCuntry;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label lbHobby;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label NameData;
        private System.Windows.Forms.Label CuntryData;
        private System.Windows.Forms.Label sexData;
        private System.Windows.Forms.Label HobbyData;
        private System.Windows.Forms.Label StatusData;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnSubmit;
    }
}