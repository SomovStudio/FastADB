using System;
using System.Collections.Generic;
using System.Text;

namespace FastADB.data
{
    public static class DataConfig
    {
        /* Программа */
        public static String programPath = "";          // адрес программы
        public static String resource = "";             // адрес папки ресурсов
        public static String configFile = "";           // адрес и имя файла базы данных config.mdb
        public static Boolean programClose = true;      // флаг обязательного закрытия приложения

        /* Локальная база данных */
        public static String oledbConnectLineBegin = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
        public static String oledbConnectLineEnd = "";
        public static String oledbConnectPass = "";
    }
}
