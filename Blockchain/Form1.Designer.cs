namespace Blockchain
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
            this.block_groupbox = new System.Windows.Forms.GroupBox();
            this.data_text = new System.Windows.Forms.Label();
            this.user_text = new System.Windows.Forms.Label();
            this.Genez_Block_btn = new System.Windows.Forms.Button();
            this.index_file_Tb = new System.Windows.Forms.TextBox();
            this.prev_hash_text = new System.Windows.Forms.Label();
            this.Get_BlockInfo_Btn = new System.Windows.Forms.Button();
            this.timestamp_text = new System.Windows.Forms.Label();
            this.hash_text = new System.Windows.Forms.Label();
            this.index_text = new System.Windows.Forms.Label();
            this.data_label = new System.Windows.Forms.Label();
            this.user_label = new System.Windows.Forms.Label();
            this.prev_hash_label = new System.Windows.Forms.Label();
            this.timestamp_label = new System.Windows.Forms.Label();
            this.hash__label = new System.Windows.Forms.Label();
            this.index_label = new System.Windows.Forms.Label();
            this.Auth_groupbox = new System.Windows.Forms.GroupBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.user_name_textbox = new System.Windows.Forms.TextBox();
            this.transaction_groupBox = new System.Windows.Forms.GroupBox();
            this.current_money_label = new System.Windows.Forms.Label();
            this.start_transaction_btn = new System.Windows.Forms.Button();
            this.money_value_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.second_user_comboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.block_groupbox.SuspendLayout();
            this.Auth_groupbox.SuspendLayout();
            this.transaction_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // block_groupbox
            // 
            this.block_groupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.block_groupbox.Controls.Add(this.button2);
            this.block_groupbox.Controls.Add(this.data_text);
            this.block_groupbox.Controls.Add(this.user_text);
            this.block_groupbox.Controls.Add(this.Genez_Block_btn);
            this.block_groupbox.Controls.Add(this.index_file_Tb);
            this.block_groupbox.Controls.Add(this.prev_hash_text);
            this.block_groupbox.Controls.Add(this.Get_BlockInfo_Btn);
            this.block_groupbox.Controls.Add(this.timestamp_text);
            this.block_groupbox.Controls.Add(this.hash_text);
            this.block_groupbox.Controls.Add(this.index_text);
            this.block_groupbox.Controls.Add(this.data_label);
            this.block_groupbox.Controls.Add(this.user_label);
            this.block_groupbox.Controls.Add(this.prev_hash_label);
            this.block_groupbox.Controls.Add(this.timestamp_label);
            this.block_groupbox.Controls.Add(this.hash__label);
            this.block_groupbox.Controls.Add(this.index_label);
            this.block_groupbox.Location = new System.Drawing.Point(12, 12);
            this.block_groupbox.Name = "block_groupbox";
            this.block_groupbox.Size = new System.Drawing.Size(514, 200);
            this.block_groupbox.TabIndex = 0;
            this.block_groupbox.TabStop = false;
            this.block_groupbox.Text = "Информация о блоке";
            // 
            // data_text
            // 
            this.data_text.AutoSize = true;
            this.data_text.Location = new System.Drawing.Point(113, 90);
            this.data_text.Name = "data_text";
            this.data_text.Size = new System.Drawing.Size(28, 13);
            this.data_text.TabIndex = 11;
            this.data_text.Text = "data";
            // 
            // user_text
            // 
            this.user_text.AutoSize = true;
            this.user_text.Location = new System.Drawing.Point(113, 78);
            this.user_text.Name = "user_text";
            this.user_text.Size = new System.Drawing.Size(27, 13);
            this.user_text.TabIndex = 10;
            this.user_text.Text = "user";
            // 
            // Genez_Block_btn
            // 
            this.Genez_Block_btn.Location = new System.Drawing.Point(21, 147);
            this.Genez_Block_btn.Name = "Genez_Block_btn";
            this.Genez_Block_btn.Size = new System.Drawing.Size(310, 24);
            this.Genez_Block_btn.TabIndex = 3;
            this.Genez_Block_btn.Text = "Генерация генезис блока";
            this.Genez_Block_btn.UseVisualStyleBackColor = true;
            this.Genez_Block_btn.Click += new System.EventHandler(this.Genez_Block_btn_Click);
            // 
            // index_file_Tb
            // 
            this.index_file_Tb.Location = new System.Drawing.Point(234, 119);
            this.index_file_Tb.Name = "index_file_Tb";
            this.index_file_Tb.Size = new System.Drawing.Size(97, 20);
            this.index_file_Tb.TabIndex = 2;
            this.index_file_Tb.Text = "0";
            // 
            // prev_hash_text
            // 
            this.prev_hash_text.AutoSize = true;
            this.prev_hash_text.Location = new System.Drawing.Point(112, 52);
            this.prev_hash_text.Name = "prev_hash_text";
            this.prev_hash_text.Size = new System.Drawing.Size(57, 13);
            this.prev_hash_text.TabIndex = 9;
            this.prev_hash_text.Text = "prev_hash";
            // 
            // Get_BlockInfo_Btn
            // 
            this.Get_BlockInfo_Btn.Location = new System.Drawing.Point(20, 117);
            this.Get_BlockInfo_Btn.Name = "Get_BlockInfo_Btn";
            this.Get_BlockInfo_Btn.Size = new System.Drawing.Size(208, 23);
            this.Get_BlockInfo_Btn.TabIndex = 1;
            this.Get_BlockInfo_Btn.Text = "Вывести информацию о блоке номер:";
            this.Get_BlockInfo_Btn.UseVisualStyleBackColor = true;
            this.Get_BlockInfo_Btn.Click += new System.EventHandler(this.Get_BlockInfo_Btn_Click);
            // 
            // timestamp_text
            // 
            this.timestamp_text.AutoSize = true;
            this.timestamp_text.Location = new System.Drawing.Point(112, 39);
            this.timestamp_text.Name = "timestamp_text";
            this.timestamp_text.Size = new System.Drawing.Size(54, 13);
            this.timestamp_text.TabIndex = 8;
            this.timestamp_text.Text = "timestamp";
            // 
            // hash_text
            // 
            this.hash_text.AutoSize = true;
            this.hash_text.Location = new System.Drawing.Point(112, 66);
            this.hash_text.Name = "hash_text";
            this.hash_text.Size = new System.Drawing.Size(30, 13);
            this.hash_text.TabIndex = 7;
            this.hash_text.Text = "hash";
            // 
            // index_text
            // 
            this.index_text.AutoSize = true;
            this.index_text.Location = new System.Drawing.Point(112, 26);
            this.index_text.Name = "index_text";
            this.index_text.Size = new System.Drawing.Size(32, 13);
            this.index_text.TabIndex = 6;
            this.index_text.Text = "index";
            // 
            // data_label
            // 
            this.data_label.AutoSize = true;
            this.data_label.Location = new System.Drawing.Point(22, 90);
            this.data_label.Name = "data_label";
            this.data_label.Size = new System.Drawing.Size(28, 13);
            this.data_label.TabIndex = 5;
            this.data_label.Text = "data";
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Location = new System.Drawing.Point(22, 78);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(27, 13);
            this.user_label.TabIndex = 4;
            this.user_label.Text = "user";
            // 
            // prev_hash_label
            // 
            this.prev_hash_label.AutoSize = true;
            this.prev_hash_label.Location = new System.Drawing.Point(21, 52);
            this.prev_hash_label.Name = "prev_hash_label";
            this.prev_hash_label.Size = new System.Drawing.Size(57, 13);
            this.prev_hash_label.TabIndex = 3;
            this.prev_hash_label.Text = "prev_hash";
            // 
            // timestamp_label
            // 
            this.timestamp_label.AutoSize = true;
            this.timestamp_label.Location = new System.Drawing.Point(21, 39);
            this.timestamp_label.Name = "timestamp_label";
            this.timestamp_label.Size = new System.Drawing.Size(54, 13);
            this.timestamp_label.TabIndex = 2;
            this.timestamp_label.Text = "timestamp";
            // 
            // hash__label
            // 
            this.hash__label.AutoSize = true;
            this.hash__label.Location = new System.Drawing.Point(21, 66);
            this.hash__label.Name = "hash__label";
            this.hash__label.Size = new System.Drawing.Size(30, 13);
            this.hash__label.TabIndex = 1;
            this.hash__label.Text = "hash";
            // 
            // index_label
            // 
            this.index_label.AutoSize = true;
            this.index_label.Location = new System.Drawing.Point(21, 26);
            this.index_label.Name = "index_label";
            this.index_label.Size = new System.Drawing.Size(32, 13);
            this.index_label.TabIndex = 0;
            this.index_label.Text = "index";
            // 
            // Auth_groupbox
            // 
            this.Auth_groupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Auth_groupbox.Controls.Add(this.password_textbox);
            this.Auth_groupbox.Controls.Add(this.label1);
            this.Auth_groupbox.Controls.Add(this.button1);
            this.Auth_groupbox.Controls.Add(this.user_name_textbox);
            this.Auth_groupbox.Location = new System.Drawing.Point(13, 218);
            this.Auth_groupbox.Name = "Auth_groupbox";
            this.Auth_groupbox.Size = new System.Drawing.Size(513, 100);
            this.Auth_groupbox.TabIndex = 4;
            this.Auth_groupbox.TabStop = false;
            this.Auth_groupbox.Text = "Авторизация";
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(210, 39);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '☺';
            this.password_textbox.Size = new System.Drawing.Size(184, 20);
            this.password_textbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Представься, пользователь!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // user_name_textbox
            // 
            this.user_name_textbox.Location = new System.Drawing.Point(20, 39);
            this.user_name_textbox.Name = "user_name_textbox";
            this.user_name_textbox.Size = new System.Drawing.Size(184, 20);
            this.user_name_textbox.TabIndex = 0;
            // 
            // transaction_groupBox
            // 
            this.transaction_groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transaction_groupBox.Controls.Add(this.current_money_label);
            this.transaction_groupBox.Controls.Add(this.start_transaction_btn);
            this.transaction_groupBox.Controls.Add(this.money_value_textbox);
            this.transaction_groupBox.Controls.Add(this.label3);
            this.transaction_groupBox.Controls.Add(this.label2);
            this.transaction_groupBox.Controls.Add(this.second_user_comboBox);
            this.transaction_groupBox.Location = new System.Drawing.Point(13, 324);
            this.transaction_groupBox.Name = "transaction_groupBox";
            this.transaction_groupBox.Size = new System.Drawing.Size(513, 199);
            this.transaction_groupBox.TabIndex = 5;
            this.transaction_groupBox.TabStop = false;
            this.transaction_groupBox.Text = "Транзакция";
            // 
            // current_money_label
            // 
            this.current_money_label.AutoSize = true;
            this.current_money_label.Location = new System.Drawing.Point(130, 67);
            this.current_money_label.Name = "current_money_label";
            this.current_money_label.Size = new System.Drawing.Size(13, 13);
            this.current_money_label.TabIndex = 5;
            this.current_money_label.Text = "$";
            // 
            // start_transaction_btn
            // 
            this.start_transaction_btn.Location = new System.Drawing.Point(18, 110);
            this.start_transaction_btn.Name = "start_transaction_btn";
            this.start_transaction_btn.Size = new System.Drawing.Size(121, 23);
            this.start_transaction_btn.TabIndex = 4;
            this.start_transaction_btn.Text = "Перевести";
            this.start_transaction_btn.UseVisualStyleBackColor = true;
            this.start_transaction_btn.Click += new System.EventHandler(this.Start_transaction_btn_Click);
            // 
            // money_value_textbox
            // 
            this.money_value_textbox.Location = new System.Drawing.Point(18, 84);
            this.money_value_textbox.Name = "money_value_textbox";
            this.money_value_textbox.Size = new System.Drawing.Size(121, 20);
            this.money_value_textbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сумма перевода из:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адресат";
            // 
            // second_user_comboBox
            // 
            this.second_user_comboBox.FormattingEnabled = true;
            this.second_user_comboBox.Location = new System.Drawing.Point(18, 39);
            this.second_user_comboBox.Name = "second_user_comboBox";
            this.second_user_comboBox.Size = new System.Drawing.Size(121, 21);
            this.second_user_comboBox.Sorted = true;
            this.second_user_comboBox.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(310, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Перепроверить блоки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 531);
            this.Controls.Add(this.transaction_groupBox);
            this.Controls.Add(this.Auth_groupbox);
            this.Controls.Add(this.block_groupbox);
            this.Name = "Form1";
            this.Text = "Ultimate Koshel!";
            this.block_groupbox.ResumeLayout(false);
            this.block_groupbox.PerformLayout();
            this.Auth_groupbox.ResumeLayout(false);
            this.Auth_groupbox.PerformLayout();
            this.transaction_groupBox.ResumeLayout(false);
            this.transaction_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox block_groupbox;
        private System.Windows.Forms.Label index_label;
        private System.Windows.Forms.Label hash__label;
        private System.Windows.Forms.Label prev_hash_label;
        private System.Windows.Forms.Label timestamp_label;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Label data_text;
        private System.Windows.Forms.Label user_text;
        private System.Windows.Forms.Label prev_hash_text;
        private System.Windows.Forms.Label timestamp_text;
        private System.Windows.Forms.Label hash_text;
        private System.Windows.Forms.Label index_text;
        private System.Windows.Forms.Label data_label;
        private System.Windows.Forms.Button Get_BlockInfo_Btn;
        private System.Windows.Forms.TextBox index_file_Tb;
        private System.Windows.Forms.Button Genez_Block_btn;
        private System.Windows.Forms.GroupBox Auth_groupbox;
        private System.Windows.Forms.TextBox user_name_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.GroupBox transaction_groupBox;
        private System.Windows.Forms.TextBox money_value_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox second_user_comboBox;
        private System.Windows.Forms.Button start_transaction_btn;
        private System.Windows.Forms.Label current_money_label;
        private System.Windows.Forms.Button button2;
    }
}

