using Department_Db.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department_Db
{
    public class ProvideServices
    {

        public static void WriteJSON<T>(string fullpath, ref T fromObj)//полній путь и ссылку на обьект
        {
            //принимает полный путь и расширением
            using (StreamWriter file = File.CreateText(fullpath))//создается поток 
            {
                JsonSerializer serializer = new JsonSerializer();//для конвертации обьекта в строку
                serializer.Serialize(file, fromObj);//появляется джейсон файл из fromObj
            }
        }

        public static T ReadJSON<T>(string fullpath)
        {
            T toObj;//обьект возвращаемый при чтении
            using (StreamReader r = new StreamReader(fullpath))
            {
                string json = r.ReadToEnd();//считывет строку 
                toObj = JsonConvert.DeserializeObject<T>(json);//конвертирует строку в обьект
            }
            return toObj;
        }
    }
}
