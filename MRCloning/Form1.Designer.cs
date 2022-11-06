namespace MRCloning
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_start_cloning = new System.Windows.Forms.Button();
            this.button_update_dir = new System.Windows.Forms.Button();
            this.comboBox_dir = new System.Windows.Forms.ComboBox();
            this.textBox_json = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_msg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_start_cloning
            // 
            this.button_start_cloning.Location = new System.Drawing.Point(392, 39);
            this.button_start_cloning.Name = "button_start_cloning";
            this.button_start_cloning.Size = new System.Drawing.Size(139, 27);
            this.button_start_cloning.TabIndex = 0;
            this.button_start_cloning.Text = "Start Cloning";
            this.button_start_cloning.UseVisualStyleBackColor = true;
            this.button_start_cloning.Click += new System.EventHandler(this.button_start_cloning_Click);
            // 
            // button_update_dir
            // 
            this.button_update_dir.Location = new System.Drawing.Point(392, 99);
            this.button_update_dir.Name = "button_update_dir";
            this.button_update_dir.Size = new System.Drawing.Size(94, 29);
            this.button_update_dir.TabIndex = 2;
            this.button_update_dir.Text = "Update";
            this.button_update_dir.UseVisualStyleBackColor = true;
            this.button_update_dir.Click += new System.EventHandler(this.button_update_dir_Click);
            // 
            // comboBox_dir
            // 
            this.comboBox_dir.FormattingEnabled = true;
            this.comboBox_dir.Location = new System.Drawing.Point(12, 39);
            this.comboBox_dir.Name = "comboBox_dir";
            this.comboBox_dir.Size = new System.Drawing.Size(318, 27);
            this.comboBox_dir.TabIndex = 4;
            this.comboBox_dir.DropDown += new System.EventHandler(this.comboBox_dir_DropDown);
            this.comboBox_dir.SelectedIndexChanged += new System.EventHandler(this.comboBox_dir_SelectedIndexChanged);
            // 
            // textBox_json
            // 
            this.textBox_json.Location = new System.Drawing.Point(12, 99);
            this.textBox_json.Multiline = true;
            this.textBox_json.Name = "textBox_json";
            this.textBox_json.ReadOnly = true;
            this.textBox_json.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_json.Size = new System.Drawing.Size(318, 94);
            this.textBox_json.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cloning File";
            // 
            // textBox_msg
            // 
            this.textBox_msg.Location = new System.Drawing.Point(12, 224);
            this.textBox_msg.Multiline = true;
            this.textBox_msg.Name = "textBox_msg";
            this.textBox_msg.ReadOnly = true;
            this.textBox_msg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_msg.Size = new System.Drawing.Size(551, 150);
            this.textBox_msg.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cloning Config";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.textBox_msg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_json);
            this.Controls.Add(this.comboBox_dir);
            this.Controls.Add(this.button_update_dir);
            this.Controls.Add(this.button_start_cloning);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_start_cloning;
        private Button button_update_dir;
        private ComboBox comboBox_dir;
        private TextBox textBox_json;
        private Label label2;
        private TextBox textBox_msg;
        private Label label1;
    }
}