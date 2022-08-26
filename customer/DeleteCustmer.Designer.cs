
namespace customer
{
    partial class DeleteCustmer
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
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.dltCustNameData = new System.Windows.Forms.TextBox();
            this.dltCustIdData = new System.Windows.Forms.TextBox();
            this.dtCustmerName = new System.Windows.Forms.Label();
            this.DtCustmerId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrid
            // 
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Location = new System.Drawing.Point(40, 271);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.RowHeadersWidth = 62;
            this.dtGrid.RowTemplate.Height = 33;
            this.dtGrid.Size = new System.Drawing.Size(1025, 279);
            this.dtGrid.TabIndex = 0;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(1071, 90);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(136, 65);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dltCustNameData
            // 
            this.dltCustNameData.Location = new System.Drawing.Point(216, 107);
            this.dltCustNameData.Name = "dltCustNameData";
            this.dltCustNameData.Size = new System.Drawing.Size(284, 31);
            this.dltCustNameData.TabIndex = 2;
            // 
            // dltCustIdData
            // 
            this.dltCustIdData.Location = new System.Drawing.Point(726, 107);
            this.dltCustIdData.Name = "dltCustIdData";
            this.dltCustIdData.Size = new System.Drawing.Size(236, 31);
            this.dltCustIdData.TabIndex = 3;
            // 
            // dtCustmerName
            // 
            this.dtCustmerName.AutoSize = true;
            this.dtCustmerName.Location = new System.Drawing.Point(55, 107);
            this.dtCustmerName.Name = "dtCustmerName";
            this.dtCustmerName.Size = new System.Drawing.Size(155, 25);
            this.dtCustmerName.TabIndex = 4;
            this.dtCustmerName.Text = "Custemer Name :-";
            // 
            // DtCustmerId
            // 
            this.DtCustmerId.AutoSize = true;
            this.DtCustmerId.Location = new System.Drawing.Point(582, 107);
            this.DtCustmerId.Name = "DtCustmerId";
            this.DtCustmerId.Size = new System.Drawing.Size(115, 25);
            this.DtCustmerId.TabIndex = 5;
            this.DtCustmerId.Text = "Custmer Id :-";
            // 
            // DeleteCustmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 579);
            this.Controls.Add(this.DtCustmerId);
            this.Controls.Add(this.dtCustmerName);
            this.Controls.Add(this.dltCustIdData);
            this.Controls.Add(this.dltCustNameData);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.dtGrid);
            this.Name = "DeleteCustmer";
            this.Text = "Delete Custmer record";
            this.Load += new System.EventHandler(this.DeleteCustmer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrid;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox dltCustNameData;
        private System.Windows.Forms.TextBox dltCustIdData;
        private System.Windows.Forms.Label dtCustmerName;
        private System.Windows.Forms.Label DtCustmerId;
    }
}