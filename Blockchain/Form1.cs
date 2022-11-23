using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Algorithms;


namespace Blockchain
{
    public partial class Form1 : Form
    {
        private bool IsAuth = false;
        private string user_data_path = @"user.info";
        string chain_directory = @"chain_data\";
        private string current_user = null;
        private int money;
        BackgroundWorker bw = new BackgroundWorker();
        string telegram_token = "654499413:AAHYWBiHhgv3ucwzhrXPkt2APkuKLSqqnY";
        public Form1()
        {
            InitializeComponent();
            transaction_groupBox.Enabled = false;
            if(Directory.Exists(chain_directory) == false)
            {
                Directory.CreateDirectory(chain_directory);

                Block block_obj = new Block();
                block_obj.Add_to_File_data();
            }
            this.bw = new BackgroundWorker();
            this.bw.DoWork += this.bw_DoWork; // метод bw_DoWork будет работать асинхронно
            if (this.bw.IsBusy != true)
            {
                //this.bw.RunWorkerAsync(telegram_token); // передаем эту переменную в виде аргумента методу bw_DoWork
            }
        }

        async void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            //var worker = sender as BackgroundWorker;
            var key = e.Argument as String; // получаем ключ из аргументов
            try
            {
                

                //WebProxy wp = new WebProxy("92.50.162.138:8080", true);
                WebProxy wp = new WebProxy("http://tginfo.likesky.blue:443/", true);
                //wp.Credentials = new NetworkCredential("tg-shar170", "uiBuHJkC");
               // wp.Credentials = new NetworkCredential("shar170","dd77777777777777777777777777777777");
               //WebProxy proxyObject = new WebProxy("http://ru.proxy.pp.ru:443/", true);

               //var tb = new Telegram.Bot.TelegramBotClient(key, wp);
                var Bot = new Telegram.Bot.TelegramBotClient(key); // инициализируем API
                //Telegram.Bot.Requests.Re
                await Bot.SetWebhookAsync("");
                //Bot.SetWebhookAsync(""); // Обязательно! убираем старую привязку к вебхуку для бота
                int offset = 0; // отступ по сообщениям
                while (true)
                {
                    var updates = await Bot.GetUpdatesAsync(offset); // получаем массив обновлений

                    foreach (var update in updates) // Перебираем все обновления
                    {
                        var message = update.Message;
                        if (message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
                        {
                            if (message.Text == "/saysomething")
                            {
                                // в ответ на команду /saysomething выводим сообщение
                                await Bot.SendTextMessageAsync(message.Chat.Id, "тест! привет: " + message.Contact.FirstName,replyToMessageId: message.MessageId);
                            }
                        }
                        offset = update.Id + 1;
                    }

                }
            }
            catch (Telegram.Bot.Exceptions.ApiRequestException ex)
            {
                Console.WriteLine(ex.Message); // если ключ не подошел - пишем об этом в консоль отладки
            }

        }

        void BtnRunClick(object sender, EventArgs e)
        {
            //var text = txtKey.Text; // получаем содержимое текстового поля txtKey в переменную text
            
        }

        public bool Block_check(int start_index = 0)
        {
            int index = 0;
            string[] blocks_files;
            blocks_files = Directory.GetFiles(chain_directory);
            Array.Sort(blocks_files);

            foreach (string file in blocks_files)
            {
                if (index < Convert.ToInt32((file.Split('.')[0]).Split('\\')[1]))
                {
                    index = Convert.ToInt32((file.Split('.')[0]).Split('\\')[1]);
                }
            }

            for (int i = start_index; i <= index; i++)
            {
                try {
                    Block block = new Block(i.ToString());
                    Dictionary<string, string> block_info = block.GetInfo();
                    if (block_info["hash"] != Algorithms.AlgorithmHelper.GetHash(block.GetHeader())) return false;

                }catch
                {
                    MessageBox.Show("Потерян блок из цепочки блоков!");
                    return false;
                }
            }
            return true;
        }
        private void Genez_Block_btn_Click(object sender, EventArgs e)
        {
            Block block_obj = new Block();
            block_obj.Add_to_File_data();

        }

        private void Get_BlockInfo_Btn_Click(object sender, EventArgs e)
        {
            try
            {//делаем конвертирование строки в число, и при успешном конвертировании передаём строку в конструктор
                Block block_obj = new Block(Convert.ToInt32(index_file_Tb.Text).ToString());
                Dictionary<string, string> block_info = block_obj.GetInfo();
                index_text.Text = block_info["index"];
                timestamp_text.Text = block_info["timestamp"];
                prev_hash_text.Text = block_info["prev_hash"];
                hash_text.Text = block_info["hash"];
                user_text.Text = block_info["user"];
                data_text.Text = block_info["data"];
            }
            catch
            {
                return;
            }
            
        }
        private void Update_User_list()
        {
            using (StreamReader sr = new StreamReader(user_data_path))
            {
                while (sr.EndOfStream == false)
                {

                    string user_data = sr.ReadLine();
                    if(user_data.Contains(current_user) == false)
                    {
                        second_user_comboBox.Items.Add(user_data.Substring(0, user_data.IndexOf(':')));
                    }
                    
                }
            }
        }

        private void Auth(int __money__)
        {            
            user_name_textbox.Enabled = false;
            password_textbox.Enabled = false;
            current_user = user_name_textbox.Text;
            IsAuth = true;
            button1.Text = "Выход";
            money = __money__;
            current_money_label.Text = money.ToString() + " в.е.";                            
            transaction_groupBox.Enabled = true;        
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(user_data_path) == false)
            {
                using (StreamWriter sw = new StreamWriter(user_data_path))
                {
                    sw.WriteLine();
                }
            }

            if(button1.Text == "Выход")
            {
                
                    current_user = null;
                    IsAuth = false;
                    user_name_textbox.Enabled = true;
                    password_textbox.Enabled = true;
                    user_name_textbox.Text = "";
                    password_textbox.Text = "";
                    transaction_groupBox.Enabled = false;
                    second_user_comboBox.Items.Clear();
                    money = -1;                    
                    button1.Text = "Вход";
                
                

            }
            
            using (StreamReader sr = new StreamReader(user_data_path))
            {
                while (sr.EndOfStream == false)
                {
                    string user_data = sr.ReadLine();
                    if (user_data.Contains(user_name_textbox.Text))
                    {
                        string user_password_hash = AlgorithmHelper.GetHash(password_textbox.Text);
                        string file_password_hash = user_data.Substring(user_data.IndexOf(':')+1, user_data.IndexOf(':', user_data.IndexOf(':') + 1) - user_data.IndexOf(':')-1);
                        if (user_password_hash == file_password_hash)
                        {
                            /* user_name_textbox.Enabled = false;
                             password_textbox.Enabled = false;
                             current_user = user_name_textbox.Text;
                             IsAuth = true;
                             button1.Text = "Выход";
                             money = Convert.ToInt32(user_data.Split(':')[2]);
                             current_money_label.Text = money.ToString() + " в.е.";                             
                             Block_check();
                             transaction_groupBox.Enabled = true;*/


                            if (Block_check()) {
                                Auth(Convert.ToInt32(user_data.Split(':')[2]));
                            }
                            else
                            {                                
                                return;
                            }
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Совпадений пароля и логина не найдено, повторите попытку :( \n" + user_name_textbox.Text);
                            return;
                        }
                    }
                }
            }

            if (IsAuth)
            {
                MessageBox.Show("Авторизация прошла успешно! Привет, " + user_name_textbox.Text);
                Update_User_list();
            }
            else
            {
                DialogResult DiRe = MessageBox.Show("Такого пользователя не существует, создадим пользователя " + user_name_textbox.Text + " ?","Регистрация" , MessageBoxButtons.OKCancel);
                if(DiRe == DialogResult.OK)
                {
                    using (StreamWriter sw =new StreamWriter(user_data_path,true))
                    {
                        /*user_name_textbox.Enabled = false;
                        password_textbox.Enabled = false;
                        current_user = user_name_textbox.Text;
                        IsAuth = true;
                        button1.Text = "Выход";                        
                        money = 0;
                        current_money_label.Text = money.ToString() + " в.е.";
                        transaction_groupBox.Enabled = true;
                        Block_check();*/

                        sw.WriteLine(user_name_textbox.Text + ":" + AlgorithmHelper.GetHash(password_textbox.Text) + ":" + "0");
                    }
                    if (Block_check()) { Auth(0); }
                    else
                    {
                        MessageBox.Show("Пользователь создан, но из-за ошибки в цепочке блоков, авторизация отменена \n" + user_name_textbox.Text);
                        return;
                    }
                    Update_User_list();
                    MessageBox.Show("Регистрация прошла успешно! Привет, " + user_name_textbox.Text +"\nНа вашем счету изначально 0 е.в.");
                }
            }            
        }
        private void rewrite_money(string first_user, string second_user, int money)
        {
            List<string> readedLines = File.ReadAllLines(user_data_path).ToList();
            int first_index= -1;
            int second_index = -1;
            int i = 0;
            foreach (string str in readedLines)
            {
                if (str.Contains(first_user)) first_index = i;
                if (str.Contains(second_user)) second_index = i;
                i++;
            }

            if (first_index < 0 || second_index < 0) throw new Exception("Один из пользователей не найден!");

            string str_first = readedLines[first_index];
            str_first = str_first.Split(':')[0] + ":" + str_first.Split(':')[1]+ ":" + (Convert.ToInt32(str_first.Split(':')[2]) - money).ToString();

            string str_second = readedLines[second_index];
            str_second = str_second.Split(':')[0] + ":" + str_second.Split(':')[1] + ":" + (Convert.ToInt32(str_second.Split(':')[2]) + money).ToString();

            readedLines.Remove(readedLines[first_index]);//удаляем запись пользователя1 из памяти
            readedLines.Insert(first_index, str_first); //вставляем новую запись о пользователе1 в уиндекс который ранее удалили

            readedLines.Remove(readedLines[second_index]);//удаляем запись пользователя2 из памяти
            readedLines.Insert(second_index, str_second); //вставляем новую запись о пользователе2 в уиндекс который ранее удалили

            File.WriteAllLines(user_data_path, readedLines.ToArray());//записываем всё из памяти обратно в БД


        }
        private void Start_transaction_btn_Click(object sender, EventArgs e)
        {
            string first_user = current_user;
            string second_user = second_user_comboBox.Text;
            if (first_user == second_user) return;
            string str_money = "";// Convert.ToInt32(money_value_textbox.Text).ToString();
            try
            {
                str_money= Convert.ToInt32(money_value_textbox.Text).ToString();
            }
            catch
            {
                return;
            }

            
            int index = 0;
            string[] blocks_files;
            blocks_files = Directory.GetFiles(chain_directory);
            Array.Sort(blocks_files);

            foreach( string file in blocks_files)
            {
                if(index < Convert.ToInt32((file.Split('.')[0]).Split('\\')[1]))
                {
                    index = Convert.ToInt32((file.Split('.')[0]).Split('\\')[1]);
                }
            }

            if(money < Convert.ToInt32(str_money))
            {
                MessageBox.Show("Не льсти себе, у тебя нет столько денег!");
            }
            else
            {
                Block prev_block = new Block(index.ToString());
                Block current_block = new Block(prev_block, str_money + " to " + second_user, current_user);
                current_block.Add_to_File_data();
                rewrite_money(first_user, second_user, Convert.ToInt32(str_money));
                money -= Convert.ToInt32(str_money);
                current_money_label.Text = money.ToString() + " в.е.";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Block_check();
        }
    }
}
