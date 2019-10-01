namespace ProjectWform
{
    partial class salelogtab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salelogtab));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtsid = new System.Windows.Forms.TextBox();
            this.getdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDatepicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.getdateto = new System.Windows.Forms.TextBox();
            this.searchbutton = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 543);
            this.dataGridView1.TabIndex = 0;
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuDatepicker1.FormatCustom = "dd/MM/yyyy";
            this.bunifuDatepicker1.Location = new System.Drawing.Point(447, 4);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(220, 35);
            this.bunifuDatepicker1.TabIndex = 1;
            this.bunifuDatepicker1.Value = new System.DateTime(2019, 10, 1, 0, 0, 0, 0);
            this.bunifuDatepicker1.onValueChanged += new System.EventHandler(this.BunifuDatepicker1_onValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Searching Bill From";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(10, 22);
            this.textBox2.TabIndex = 4;
            // 
            // txtsid
            // 
            this.txtsid.Location = new System.Drawing.Point(19, 2);
            this.txtsid.Name = "txtsid";
            this.txtsid.Size = new System.Drawing.Size(10, 22);
            this.txtsid.TabIndex = 5;
            // 
            // getdate
            // 
            this.getdate.Location = new System.Drawing.Point(35, 3);
            this.getdate.Name = "getdate";
            this.getdate.Size = new System.Drawing.Size(10, 22);
            this.getdate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(671, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDatepicker2
            // 
            this.bunifuDatepicker2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.bunifuDatepicker2.BorderRadius = 0;
            this.bunifuDatepicker2.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuDatepicker2.FormatCustom = "dd/MM/yyyy";
            this.bunifuDatepicker2.Location = new System.Drawing.Point(711, 4);
            this.bunifuDatepicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDatepicker2.Name = "bunifuDatepicker2";
            this.bunifuDatepicker2.Size = new System.Drawing.Size(220, 35);
            this.bunifuDatepicker2.TabIndex = 1;
            this.bunifuDatepicker2.Value = new System.DateTime(2019, 10, 1, 0, 0, 0, 0);
            this.bunifuDatepicker2.onValueChanged += new System.EventHandler(this.BunifuDatepicker1_onValueChanged);
            // 
            // getdateto
            // 
            this.getdateto.Location = new System.Drawing.Point(51, 3);
            this.getdateto.Name = "getdateto";
            this.getdateto.Size = new System.Drawing.Size(10, 22);
            this.getdateto.TabIndex = 8;
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.Black;
            this.searchbutton.Image = ((System.Drawing.Image)(resources.GetObject("searchbutton.Image")));
            this.searchbutton.ImageActive = null;
            this.searchbutton.Location = new System.Drawing.Point(953, 3);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(40, 35);
            this.searchbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.searchbutton.TabIndex = 9;
            this.searchbutton.TabStop = false;
            this.searchbutton.Zoom = 10;
            this.searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // salelogtab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.getdateto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.getdate);
            this.Controls.Add(this.txtsid);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuDatepicker2);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "salelogtab";
            this.Size = new System.Drawing.Size(1016, 585);
            this.Load += new System.EventHandler(this.Salelogtab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchbutton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtsid;
        private System.Windows.Forms.TextBox getdate;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker2;
        private System.Windows.Forms.TextBox getdateto;
        private Bunifu.Framework.UI.BunifuImageButton searchbutton;
    }
}
