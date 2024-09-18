namespace PROG7312_Part_1_ST10055559
{
    partial class Report_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_Form));
            this.locationInput_txt = new System.Windows.Forms.TextBox();
            this.description_txt = new System.Windows.Forms.RichTextBox();
            this.media_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.submit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.categories_box = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // locationInput_txt
            // 
            this.locationInput_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationInput_txt.Location = new System.Drawing.Point(136, 26);
            this.locationInput_txt.Name = "locationInput_txt";
            this.locationInput_txt.Size = new System.Drawing.Size(147, 20);
            this.locationInput_txt.TabIndex = 0;
            // 
            // description_txt
            // 
            this.description_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.description_txt.Location = new System.Drawing.Point(55, 161);
            this.description_txt.Name = "description_txt";
            this.description_txt.Size = new System.Drawing.Size(228, 96);
            this.description_txt.TabIndex = 2;
            this.description_txt.Text = "";
            // 
            // media_btn
            // 
            this.media_btn.BackColor = System.Drawing.Color.White;
            this.media_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.media_btn.Location = new System.Drawing.Point(94, 274);
            this.media_btn.Name = "media_btn";
            this.media_btn.Size = new System.Drawing.Size(141, 60);
            this.media_btn.TabIndex = 3;
            this.media_btn.Text = "Attach Media File";
            this.media_btn.UseVisualStyleBackColor = false;
            this.media_btn.Click += new System.EventHandler(this.media_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.Window;
            this.back_btn.Location = new System.Drawing.Point(12, 375);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(123, 54);
            this.back_btn.TabIndex = 4;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // submit_btn
            // 
            this.submit_btn.BackColor = System.Drawing.SystemColors.Window;
            this.submit_btn.Location = new System.Drawing.Point(203, 375);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(122, 54);
            this.submit_btn.TabIndex = 5;
            this.submit_btn.Text = "Submit Report";
            this.submit_btn.UseVisualStyleBackColor = false;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Categorie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Description:";
            // 
            // categories_box
            // 
            this.categories_box.FormattingEnabled = true;
            this.categories_box.Location = new System.Drawing.Point(136, 66);
            this.categories_box.Name = "categories_box";
            this.categories_box.Size = new System.Drawing.Size(147, 21);
            this.categories_box.TabIndex = 12;
            // 
            // Report_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(337, 441);
            this.Controls.Add(this.categories_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.media_btn);
            this.Controls.Add(this.description_txt);
            this.Controls.Add(this.locationInput_txt);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(353, 480);
            this.MinimumSize = new System.Drawing.Size(353, 480);
            this.Name = "Report_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Submit Report";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox locationInput_txt;
        private System.Windows.Forms.RichTextBox description_txt;
        private System.Windows.Forms.Button media_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox categories_box;
    }
}