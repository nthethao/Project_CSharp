namespace Setting_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Path1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Path2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_Overwrite = new System.Windows.Forms.RadioButton();
            this.rb_NewFile = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Path1 = new System.Windows.Forms.Label();
            this.lbl_Path2 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_LoadSetting = new System.Windows.Forms.Button();
            this.btn_SaveSetting = new System.Windows.Forms.Button();
            this.txt_Timer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "受信フォルダ";
            // 
            // btn_Path1
            // 
            this.btn_Path1.Location = new System.Drawing.Point(350, 28);
            this.btn_Path1.Name = "btn_Path1";
            this.btn_Path1.Size = new System.Drawing.Size(75, 23);
            this.btn_Path1.TabIndex = 1;
            this.btn_Path1.Text = "編集";
            this.btn_Path1.UseVisualStyleBackColor = true;
            this.btn_Path1.Click += new System.EventHandler(this.btn_Path1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ローカルログ";
            // 
            // btn_Path2
            // 
            this.btn_Path2.Location = new System.Drawing.Point(350, 70);
            this.btn_Path2.Name = "btn_Path2";
            this.btn_Path2.Size = new System.Drawing.Size(75, 23);
            this.btn_Path2.TabIndex = 2;
            this.btn_Path2.Text = "編集";
            this.btn_Path2.UseVisualStyleBackColor = true;
            this.btn_Path2.Click += new System.EventHandler(this.btn_Path2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "送信間隔（ms）";
            // 
            // rb_Overwrite
            // 
            this.rb_Overwrite.AutoSize = true;
            this.rb_Overwrite.Location = new System.Drawing.Point(24, 179);
            this.rb_Overwrite.Name = "rb_Overwrite";
            this.rb_Overwrite.Size = new System.Drawing.Size(77, 17);
            this.rb_Overwrite.TabIndex = 4;
            this.rb_Overwrite.TabStop = true;
            this.rb_Overwrite.Text = "上書きする";
            this.rb_Overwrite.UseVisualStyleBackColor = true;
            // 
            // rb_NewFile
            // 
            this.rb_NewFile.AutoSize = true;
            this.rb_NewFile.Checked = true;
            this.rb_NewFile.Location = new System.Drawing.Point(115, 179);
            this.rb_NewFile.Name = "rb_NewFile";
            this.rb_NewFile.Size = new System.Drawing.Size(87, 17);
            this.rb_NewFile.TabIndex = 5;
            this.rb_NewFile.TabStop = true;
            this.rb_NewFile.Text = "上書きしない";
            this.rb_NewFile.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "受信ファイル上書き設定";
            // 
            // lbl_Path1
            // 
            this.lbl_Path1.AutoSize = true;
            this.lbl_Path1.Location = new System.Drawing.Point(93, 28);
            this.lbl_Path1.Name = "lbl_Path1";
            this.lbl_Path1.Size = new System.Drawing.Size(0, 13);
            this.lbl_Path1.TabIndex = 3;
            // 
            // lbl_Path2
            // 
            this.lbl_Path2.AutoSize = true;
            this.lbl_Path2.Location = new System.Drawing.Point(112, 70);
            this.lbl_Path2.Name = "lbl_Path2";
            this.lbl_Path2.Size = new System.Drawing.Size(0, 13);
            this.lbl_Path2.TabIndex = 3;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(267, 226);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(348, 226);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "Cancer";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_LoadSetting
            // 
            this.btn_LoadSetting.Location = new System.Drawing.Point(15, 226);
            this.btn_LoadSetting.Name = "btn_LoadSetting";
            this.btn_LoadSetting.Size = new System.Drawing.Size(86, 23);
            this.btn_LoadSetting.TabIndex = 6;
            this.btn_LoadSetting.Text = "Load from INI";
            this.btn_LoadSetting.UseVisualStyleBackColor = false;
            this.btn_LoadSetting.Click += new System.EventHandler(this.btn_LoadSetting_Click_1);
            // 
            // btn_SaveSetting
            // 
            this.btn_SaveSetting.Location = new System.Drawing.Point(115, 226);
            this.btn_SaveSetting.Name = "btn_SaveSetting";
            this.btn_SaveSetting.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveSetting.TabIndex = 7;
            this.btn_SaveSetting.Text = "Save to INI";
            this.btn_SaveSetting.UseVisualStyleBackColor = false;
            this.btn_SaveSetting.Click += new System.EventHandler(this.btn_SaveSetting_Click);
            // 
            // txt_Timer
            // 
            this.txt_Timer.Location = new System.Drawing.Point(115, 123);
            this.txt_Timer.Name = "txt_Timer";
            this.txt_Timer.Size = new System.Drawing.Size(100, 20);
            this.txt_Timer.TabIndex = 3;
            this.txt_Timer.Text = "1000";
            this.txt_Timer.TextChanged += new System.EventHandler(this.txt_Time_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(454, 259);
            this.Controls.Add(this.txt_Timer);
            this.Controls.Add(this.lbl_Path2);
            this.Controls.Add(this.lbl_Path1);
            this.Controls.Add(this.rb_NewFile);
            this.Controls.Add(this.rb_Overwrite);
            this.Controls.Add(this.btn_SaveSetting);
            this.Controls.Add(this.btn_LoadSetting);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Path2);
            this.Controls.Add(this.btn_Path1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Path1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Path2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_Overwrite;
        private System.Windows.Forms.RadioButton rb_NewFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Path1;
        private System.Windows.Forms.Label lbl_Path2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_LoadSetting;
        private System.Windows.Forms.Button btn_SaveSetting;
        private System.Windows.Forms.TextBox txt_Timer;
    }
}

