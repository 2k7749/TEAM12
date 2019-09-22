namespace ProjectWform
{
    partial class customerstab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerstab));
            this.dgvcustomers = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtcid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtcname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtcphone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtcaddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtrepoints = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtsearchbyid = new System.Windows.Forms.TextBox();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcustomers
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvcustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvcustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dgvcustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvcustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.DeepPink;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcustomers.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvcustomers.DoubleBuffered = true;
            this.dgvcustomers.EnableHeadersVisualStyles = false;
            this.dgvcustomers.GridColor = System.Drawing.Color.HotPink;
            this.dgvcustomers.HeaderBgColor = System.Drawing.Color.DeepPink;
            this.dgvcustomers.HeaderForeColor = System.Drawing.Color.DeepPink;
            this.dgvcustomers.Location = new System.Drawing.Point(0, 0);
            this.dgvcustomers.Name = "dgvcustomers";
            this.dgvcustomers.ReadOnly = true;
            this.dgvcustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvcustomers.RowHeadersWidth = 51;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvcustomers.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvcustomers.RowTemplate.Height = 24;
            this.dgvcustomers.Size = new System.Drawing.Size(749, 585);
            this.dgvcustomers.TabIndex = 1;
            this.dgvcustomers.DoubleClick += new System.EventHandler(this.Dgvcustomers_DoubleClick);
            // 
            // txtcid
            // 
            this.txtcid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtcid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcid.HintForeColor = System.Drawing.Color.Empty;
            this.txtcid.HintText = "Customers ID";
            this.txtcid.isPassword = false;
            this.txtcid.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcid.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcid.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcid.LineThickness = 3;
            this.txtcid.Location = new System.Drawing.Point(773, 73);
            this.txtcid.Margin = new System.Windows.Forms.Padding(4);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(182, 33);
            this.txtcid.TabIndex = 2;
            this.txtcid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtcname
            // 
            this.txtcname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtcname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcname.HintForeColor = System.Drawing.Color.Empty;
            this.txtcname.HintText = "Customers Name";
            this.txtcname.isPassword = false;
            this.txtcname.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcname.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcname.LineThickness = 3;
            this.txtcname.Location = new System.Drawing.Point(773, 115);
            this.txtcname.Margin = new System.Windows.Forms.Padding(4);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(225, 33);
            this.txtcname.TabIndex = 3;
            this.txtcname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtcphone
            // 
            this.txtcphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtcphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcphone.HintForeColor = System.Drawing.Color.Empty;
            this.txtcphone.HintText = "Customers Phone";
            this.txtcphone.isPassword = false;
            this.txtcphone.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcphone.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcphone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcphone.LineThickness = 3;
            this.txtcphone.Location = new System.Drawing.Point(773, 155);
            this.txtcphone.Margin = new System.Windows.Forms.Padding(4);
            this.txtcphone.Name = "txtcphone";
            this.txtcphone.Size = new System.Drawing.Size(225, 33);
            this.txtcphone.TabIndex = 4;
            this.txtcphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtcaddress
            // 
            this.txtcaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtcaddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcaddress.HintForeColor = System.Drawing.Color.Empty;
            this.txtcaddress.HintText = "Customers Address";
            this.txtcaddress.isPassword = false;
            this.txtcaddress.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcaddress.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcaddress.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcaddress.LineThickness = 3;
            this.txtcaddress.Location = new System.Drawing.Point(773, 196);
            this.txtcaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtcaddress.Name = "txtcaddress";
            this.txtcaddress.Size = new System.Drawing.Size(225, 33);
            this.txtcaddress.TabIndex = 5;
            this.txtcaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtrepoints
            // 
            this.txtrepoints.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtrepoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtrepoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtrepoints.HintForeColor = System.Drawing.Color.Empty;
            this.txtrepoints.HintText = "Reward Points";
            this.txtrepoints.isPassword = false;
            this.txtrepoints.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtrepoints.LineIdleColor = System.Drawing.Color.Gray;
            this.txtrepoints.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtrepoints.LineThickness = 3;
            this.txtrepoints.Location = new System.Drawing.Point(773, 237);
            this.txtrepoints.Margin = new System.Windows.Forms.Padding(4);
            this.txtrepoints.Name = "txtrepoints";
            this.txtrepoints.Size = new System.Drawing.Size(225, 33);
            this.txtrepoints.TabIndex = 5;
            this.txtrepoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.White;
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Location = new System.Drawing.Point(790, 412);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(94, 56);
            this.btnclear.TabIndex = 8;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.Btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Location = new System.Drawing.Point(790, 351);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(94, 56);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Yellow;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnupdate.Location = new System.Drawing.Point(890, 289);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(94, 56);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.Btnupdate_Click);
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.DarkViolet;
            this.btninsert.FlatAppearance.BorderSize = 0;
            this.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsert.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btninsert.Location = new System.Drawing.Point(790, 289);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(94, 56);
            this.btninsert.TabIndex = 11;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.Btninsert_Click);
            // 
            // txtsearchbyid
            // 
            this.txtsearchbyid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchbyid.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtsearchbyid.Location = new System.Drawing.Point(773, 3);
            this.txtsearchbyid.Name = "txtsearchbyid";
            this.txtsearchbyid.Size = new System.Drawing.Size(233, 38);
            this.txtsearchbyid.TabIndex = 13;
            this.txtsearchbyid.Text = "Keyword Here";
            this.txtsearchbyid.TextChanged += new System.EventHandler(this.Txtsearchbyid_TextChanged);
            this.txtsearchbyid.Enter += new System.EventHandler(this.Txtsearchbyid_Enter);
            this.txtsearchbyid.Leave += new System.EventHandler(this.Txtsearchbyid_Leave);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Cyan;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(963, 71);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(35, 35);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bunifuImageButton2.TabIndex = 12;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.BunifuImageButton2_Click);
            // 
            // customerstab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.txtsearchbyid);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtrepoints);
            this.Controls.Add(this.txtcaddress);
            this.Controls.Add(this.txtcphone);
            this.Controls.Add(this.txtcname);
            this.Controls.Add(this.txtcid);
            this.Controls.Add(this.dgvcustomers);
            this.Name = "customerstab";
            this.Size = new System.Drawing.Size(1016, 585);
            this.Load += new System.EventHandler(this.Customerstab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvcustomers;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcphone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcaddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtrepoints;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtsearchbyid;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
    }
}
