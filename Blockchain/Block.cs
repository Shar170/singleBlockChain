using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms;


namespace Blockchain
{
    class Block
    {
        string chain_directory = @"chain_data\";

        private Dictionary<string,string> info = new Dictionary<string,string>();
        /*      
         *  'version'
            info['index'] 
            info['timestamp'] 
            info['prev_hash'] 
            info['hash'] 
            info['user'] 
            info['data']
         */

        public Block (Dictionary<string,string> Atr = null)//конструктор нового блока 
        {
            if(Atr == null)
            {
                info["version"] = "1"; 
                info["index"] = "0";
                info["timestamp"] = DateTime.Now.ToString();                
                info["prev_hash"] = "hashhashhashhashhashhashhash_Misha_Kirill_Danila_hashhashhashhashhash";
                info["user"] = "admin";
                info["data"] = "first block";

                info["hash"] = Algorithms.AlgorithmHelper.GetHash(this.GetHeader());
            }
            else
            {
                foreach (string key in Atr.Keys)
                {
                    info[key] = Atr[key];
                }
            }
                
        }

        public Block(Block prev_block, string data, string user)
        {
            Dictionary<string, string> prev_info = prev_block.GetInfo();
            info["version"] = "1";
            info["timestamp"] = DateTime.Now.ToString();
            info["index"] = (Convert.ToInt32(prev_info["index"])+1).ToString(); //рассчитываем следующий индекс от предыдущего блока
            info["prev_hash"] = prev_info["hash"];//берём хэш предыдущего
            info["user"] = user; 
            info["data"] = data;

            info["hash"] = Algorithms.AlgorithmHelper.GetHash(this.GetHeader());

        }
        public string GetHeader()
        {
            string header = "";
            header += info["version"];
            header += info["timestamp"];
            header += info["prev_hash"];
            header += info["user"];
            header += info["data"];

            return header;

        }

        public Block(string index)//конструктор через файл
        {
            string block_path = @"chain_data\" + index + ".block";
            if (System.IO.File.Exists(block_path))
            {
                using (StreamReader sr = new StreamReader(block_path))
                {
                   while(sr.EndOfStream == false)
                    {
                        string line = sr.ReadLine();
                        info[line.Substring(0, line.IndexOf(":"))] = line.Substring(line.IndexOf(":")+1);
                    }
                }
            }
            else
            {
                throw new Exception("Блок не создан из-за отсутсвия файла блока");
            }

        }

        public Dictionary<string, string> GetInfo()
        {
            return info;
        }

        public string Get_prev_hash()
        {
            return info["prev_hash"];
        }

        public bool Add_to_File_data()
        {
            string block_path = @"chain_data\" + info["index"] + ".block";
            if (System.IO.File.Exists(block_path)) return false;
            if (Directory.Exists(chain_directory))
            {
                using (StreamWriter sw = new StreamWriter(block_path))
                {
                    foreach (string key in info.Keys)
                    {
                        sw.WriteLine(key + ":" + info[key]);
                    }
                }
                return true;
            }
            

            return false;
        }


    }
}
