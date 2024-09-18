namespace PROG7312_Part_1_ST10055559
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.navbar_panel = new System.Windows.Forms.Panel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_panel = new System.Windows.Forms.Panel();
            this.service_btn = new System.Windows.Forms.Button();
            this.events_btn = new System.Windows.Forms.Button();
            this.report_btn = new System.Windows.Forms.Button();
            this.navbar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.button_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navbar_panel
            // 
            this.navbar_panel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.navbar_panel.Controls.Add(this.title_lbl);
            this.navbar_panel.Controls.Add(this.pictureBox1);
            this.navbar_panel.Location = new System.Drawing.Point(0, 0);
            this.navbar_panel.Name = "navbar_panel";
            this.navbar_panel.Size = new System.Drawing.Size(1440, 64);
            this.navbar_panel.TabIndex = 0;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Calisto MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.Gold;
            this.title_lbl.Location = new System.Drawing.Point(125, 13);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(290, 37);
            this.title_lbl.TabIndex = 3;
            this.title_lbl.Text = "Bloem Municipality";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 58);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button_panel
            // 
            this.button_panel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button_panel.Controls.Add(this.service_btn);
            this.button_panel.Controls.Add(this.events_btn);
            this.button_panel.Controls.Add(this.report_btn);
            this.button_panel.Location = new System.Drawing.Point(0, 70);
            this.button_panel.Name = "button_panel";
            this.button_panel.Size = new System.Drawing.Size(200, 539);
            this.button_panel.TabIndex = 1;
            // 
            // service_btn
            // 
            this.service_btn.BackColor = System.Drawing.Color.Honeydew;
            this.service_btn.Location = new System.Drawing.Point(3, 125);
            this.service_btn.Name = "service_btn";
            this.service_btn.Size = new System.Drawing.Size(194, 55);
            this.service_btn.TabIndex = 2;
            this.service_btn.Text = "Service Request Status";
            this.service_btn.UseVisualStyleBackColor = false;
            this.service_btn.Click += new System.EventHandler(this.service_btn_Click);
            // 
            // events_btn
            // 
            this.events_btn.BackColor = System.Drawing.Color.Honeydew;
            this.events_btn.Location = new System.Drawing.Point(3, 64);
            this.events_btn.Name = "events_btn";
            this.events_btn.Size = new System.Drawing.Size(194, 55);
            this.events_btn.TabIndex = 1;
            this.events_btn.Text = "Local Events and Announcements";
            this.events_btn.UseVisualStyleBackColor = false;
            this.events_btn.Click += new System.EventHandler(this.events_btn_Click);
            // 
            // report_btn
            // 
            this.report_btn.BackColor = System.Drawing.Color.Honeydew;
            this.report_btn.Location = new System.Drawing.Point(3, 3);
            this.report_btn.Name = "report_btn";
            this.report_btn.Size = new System.Drawing.Size(194, 55);
            this.report_btn.TabIndex = 0;
            this.report_btn.Text = "Report";
            this.report_btn.UseVisualStyleBackColor = false;
            this.report_btn.Click += new System.EventHandler(this.report_btn_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1021, 645);
            this.Controls.Add(this.button_panel);
            this.Controls.Add(this.navbar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1037, 684);
            this.MinimumSize = new System.Drawing.Size(1037, 684);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.navbar_panel.ResumeLayout(false);
            this.navbar_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.button_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navbar_panel;
        private System.Windows.Forms.Panel button_panel;
        private System.Windows.Forms.Button service_btn;
        private System.Windows.Forms.Button events_btn;
        private System.Windows.Forms.Button report_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label title_lbl;
    }
}

