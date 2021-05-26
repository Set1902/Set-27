namespace ComForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.b_con = new System.Windows.Forms.Button();
            this.cb_PortNames = new System.Windows.Forms.ComboBox();
            this.b_OpenPort = new System.Windows.Forms.Button();
            this.b_ChooseFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.b_Connection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(21, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(512, 380);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // b_con
            // 
            this.b_con.BackColor = System.Drawing.Color.White;
            this.b_con.Location = new System.Drawing.Point(557, 121);
            this.b_con.Name = "b_con";
            this.b_con.Size = new System.Drawing.Size(141, 23);
            this.b_con.TabIndex = 4;
            this.b_con.Text = "Проверить соединение";
            this.b_con.UseVisualStyleBackColor = false;
            this.b_con.Click += new System.EventHandler(this.b_con_Click);
            // 
            // cb_PortNames
            // 
            this.cb_PortNames.FormattingEnabled = true;
            this.cb_PortNames.Location = new System.Drawing.Point(557, 36);
            this.cb_PortNames.Name = "cb_PortNames";
            this.cb_PortNames.Size = new System.Drawing.Size(141, 21);
            this.cb_PortNames.TabIndex = 6;
            // 
            // b_OpenPort
            // 
            this.b_OpenPort.BackColor = System.Drawing.Color.White;
            this.b_OpenPort.Location = new System.Drawing.Point(557, 59);
            this.b_OpenPort.Name = "b_OpenPort";
            this.b_OpenPort.Size = new System.Drawing.Size(141, 23);
            this.b_OpenPort.TabIndex = 7;
            this.b_OpenPort.Text = "Подтвердить выбор";
            this.b_OpenPort.UseVisualStyleBackColor = false;
            this.b_OpenPort.Click += new System.EventHandler(this.b_OpenPort_Click);
            // 
            // b_ChooseFile
            // 
            this.b_ChooseFile.BackColor = System.Drawing.Color.White;
            this.b_ChooseFile.Location = new System.Drawing.Point(557, 184);
            this.b_ChooseFile.Name = "b_ChooseFile";
            this.b_ChooseFile.Size = new System.Drawing.Size(141, 23);
            this.b_ChooseFile.TabIndex = 8;
            this.b_ChooseFile.Text = "Отправить файл";
            this.b_ChooseFile.UseVisualStyleBackColor = false;
            this.b_ChooseFile.Click += new System.EventHandler(this.b_ChooseFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(553, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Выбор порта:";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(557, 152);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(141, 23);
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Visible = false;
            // 
            // b_Connection
            // 
            this.b_Connection.BackColor = System.Drawing.Color.White;
            this.b_Connection.Location = new System.Drawing.Point(557, 91);
            this.b_Connection.Name = "b_Connection";
            this.b_Connection.Size = new System.Drawing.Size(141, 23);
            this.b_Connection.TabIndex = 13;
            this.b_Connection.Text = "Установить соединение";
            this.b_Connection.UseVisualStyleBackColor = false;
            this.b_Connection.Click += new System.EventHandler(this.b_Connection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(712, 413);
            this.Controls.Add(this.b_Connection);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_ChooseFile);
            this.Controls.Add(this.b_OpenPort);
            this.Controls.Add(this.cb_PortNames);
            this.Controls.Add(this.b_con);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Курсовая Работа. ИУ5-62 : Шашурин А.С., Ковалев С.А., Мелконьянц А.Р. ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button b_con;
        private System.Windows.Forms.ComboBox cb_PortNames;
        private System.Windows.Forms.Button b_OpenPort;
        private System.Windows.Forms.Button b_ChooseFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button b_Connection;
    }
}

