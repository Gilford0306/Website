//Создайте класс «Веб-сайт». Необходимо хранить в
//полях класса: название сайта, путь к сайту, описание
//сайта, ip адрес сайта. Реализуйте методы класса для ввода
//данных, вывода данных, реализуйте доступ к отдельным
//полям через методы класса. 
using System;


namespace Website
{
    internal class Site
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string IP { get; set; }
        public Site()
        {
            Name = String.Empty;
            Url = String.Empty;
            Description = String.Empty;
            IP = String.Empty;
        }
        public Site(string _Name, string _URL, string _Description, string _IP)
        {
            this.Name = _Name;
            this.Url = _URL;
            this.Description = _Description;
            this.IP = _IP;
        }
        public override string ToString()
        {
            return String.Format("Name: {0}\nUrl: {1}\nDescription: {2}\nIP : {3} \n", Name, Url, Description, IP);
        }

    }
}
