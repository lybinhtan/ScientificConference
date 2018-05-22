namespace ScientificConference
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAudience = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuest = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInstructor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFind = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.txbFind = new Bunifu.Framework.UI.BunifuTextbox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 67);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(77)))));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageActive = null;
            this.btnHome.Location = new System.Drawing.Point(25, 10);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(43, 37);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 2;
            this.btnHome.TabStop = false;
            this.btnHome.Zoom = 10;
            this.btnHome.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(176, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(573, 43);
            this.panel3.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(74, 25);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(76, 18);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = " Register";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.btnAudience);
            this.panel2.Controls.Add(this.btnGuest);
            this.panel2.Controls.Add(this.btnInstructor);
            this.panel2.Location = new System.Drawing.Point(-1, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 262);
            this.panel2.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.BorderRadius = 0;
            this.btnLogOut.ButtonText = "LogOut";
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogOut.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Iconimage")));
            this.btnLogOut.Iconimage_right = null;
            this.btnLogOut.Iconimage_right_Selected = null;
            this.btnLogOut.Iconimage_Selected = null;
            this.btnLogOut.IconMarginLeft = 0;
            this.btnLogOut.IconMarginRight = 0;
            this.btnLogOut.IconRightVisible = true;
            this.btnLogOut.IconRightZoom = 0D;
            this.btnLogOut.IconVisible = true;
            this.btnLogOut.IconZoom = 90D;
            this.btnLogOut.IsTab = false;
            this.btnLogOut.Location = new System.Drawing.Point(-1, 196);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLogOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogOut.selected = false;
            this.btnLogOut.Size = new System.Drawing.Size(178, 68);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Textcolor = System.Drawing.Color.White;
            this.btnLogOut.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAudience
            // 
            this.btnAudience.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAudience.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAudience.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAudience.BorderRadius = 0;
            this.btnAudience.ButtonText = "Audience";
            this.btnAudience.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAudience.DisabledColor = System.Drawing.Color.Gray;
            this.btnAudience.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAudience.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAudience.Iconimage")));
            this.btnAudience.Iconimage_right = null;
            this.btnAudience.Iconimage_right_Selected = null;
            this.btnAudience.Iconimage_Selected = null;
            this.btnAudience.IconMarginLeft = 0;
            this.btnAudience.IconMarginRight = 0;
            this.btnAudience.IconRightVisible = true;
            this.btnAudience.IconRightZoom = 0D;
            this.btnAudience.IconVisible = true;
            this.btnAudience.IconZoom = 90D;
            this.btnAudience.IsTab = false;
            this.btnAudience.Location = new System.Drawing.Point(-1, 129);
            this.btnAudience.Name = "btnAudience";
            this.btnAudience.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAudience.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAudience.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAudience.selected = false;
            this.btnAudience.Size = new System.Drawing.Size(178, 68);
            this.btnAudience.TabIndex = 3;
            this.btnAudience.Text = "Audience";
            this.btnAudience.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAudience.Textcolor = System.Drawing.Color.White;
            this.btnAudience.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudience.Click += new System.EventHandler(this.btnAudience_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuest.BorderRadius = 0;
            this.btnGuest.ButtonText = "Guest";
            this.btnGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuest.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuest.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuest.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGuest.Iconimage")));
            this.btnGuest.Iconimage_right = null;
            this.btnGuest.Iconimage_right_Selected = null;
            this.btnGuest.Iconimage_Selected = null;
            this.btnGuest.IconMarginLeft = 0;
            this.btnGuest.IconMarginRight = 0;
            this.btnGuest.IconRightVisible = true;
            this.btnGuest.IconRightZoom = 0D;
            this.btnGuest.IconVisible = true;
            this.btnGuest.IconZoom = 90D;
            this.btnGuest.IsTab = false;
            this.btnGuest.Location = new System.Drawing.Point(0, 64);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGuest.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGuest.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuest.selected = false;
            this.btnGuest.Size = new System.Drawing.Size(178, 68);
            this.btnGuest.TabIndex = 3;
            this.btnGuest.Text = "Guest";
            this.btnGuest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuest.Textcolor = System.Drawing.Color.White;
            this.btnGuest.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // btnInstructor
            // 
            this.btnInstructor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInstructor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInstructor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInstructor.BorderRadius = 0;
            this.btnInstructor.ButtonText = "Instructor";
            this.btnInstructor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstructor.DisabledColor = System.Drawing.Color.Gray;
            this.btnInstructor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInstructor.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInstructor.Iconimage")));
            this.btnInstructor.Iconimage_right = null;
            this.btnInstructor.Iconimage_right_Selected = null;
            this.btnInstructor.Iconimage_Selected = null;
            this.btnInstructor.IconMarginLeft = 0;
            this.btnInstructor.IconMarginRight = 0;
            this.btnInstructor.IconRightVisible = true;
            this.btnInstructor.IconRightZoom = 0D;
            this.btnInstructor.IconVisible = true;
            this.btnInstructor.IconZoom = 90D;
            this.btnInstructor.IsTab = false;
            this.btnInstructor.Location = new System.Drawing.Point(1, -3);
            this.btnInstructor.Name = "btnInstructor";
            this.btnInstructor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInstructor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnInstructor.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInstructor.selected = false;
            this.btnInstructor.Size = new System.Drawing.Size(178, 68);
            this.btnInstructor.TabIndex = 0;
            this.btnInstructor.Text = "Instructor";
            this.btnInstructor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstructor.Textcolor = System.Drawing.Color.White;
            this.btnInstructor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructor.Click += new System.EventHandler(this.btnInstructor_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.Controls.Add(this.btnFind);
            this.panel4.Controls.Add(this.btnEdit);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.txbFind);
            this.panel4.Location = new System.Drawing.Point(178, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(586, 47);
            this.panel4.TabIndex = 7;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.White;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageActive = null;
            this.btnFind.Location = new System.Drawing.Point(344, 8);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(40, 29);
            this.btnFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFind.TabIndex = 6;
            this.btnFind.TabStop = false;
            this.btnFind.Zoom = 10;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageActive = null;
            this.btnEdit.Location = new System.Drawing.Point(529, 8);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(41, 29);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 4;
            this.btnEdit.TabStop = false;
            this.btnEdit.Zoom = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageActive = null;
            this.btnDelete.Location = new System.Drawing.Point(466, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(39, 29);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 3;
            this.btnDelete.TabStop = false;
            this.btnDelete.Zoom = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageActive = null;
            this.btnAdd.Location = new System.Drawing.Point(403, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(41, 29);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 2;
            this.btnAdd.TabStop = false;
            this.btnAdd.Zoom = 10;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbFind
            // 
            this.txbFind.BackColor = System.Drawing.Color.Silver;
            this.txbFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbFind.BackgroundImage")));
            this.txbFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txbFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbFind.Icon = ((System.Drawing.Image)(resources.GetObject("txbFind.Icon")));
            this.txbFind.Location = new System.Drawing.Point(15, 6);
            this.txbFind.Name = "txbFind";
            this.txbFind.Size = new System.Drawing.Size(249, 35);
            this.txbFind.TabIndex = 0;
            this.txbFind.text = "";
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(175, 46);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(587, 282);
            this.dgvData.TabIndex = 8;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 332);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnAudience;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuest;
        private Bunifu.Framework.UI.BunifuFlatButton btnInstructor;
        private Bunifu.Framework.UI.BunifuImageButton btnHome;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuImageButton btnFind;
        private Bunifu.Framework.UI.BunifuImageButton btnEdit;
        private Bunifu.Framework.UI.BunifuImageButton btnDelete;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd;
        private Bunifu.Framework.UI.BunifuTextbox txbFind;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogOut;
        private System.Windows.Forms.DataGridView dgvData;
    }
}