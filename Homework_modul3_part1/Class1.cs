using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_modul3_part1
{
    class Website
    {
        private string name;
        private string url;
        private string description;
        private string ipAddress;

        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string IpAddress { get; set; }

        // Конструктор класса
        public Website(string name, string url, string description, string ipAddress)
        {
            this.name = name;
            this.url = url;
            this.description = description;
            this.ipAddress = ipAddress;
        }

        // Метод для ввода данных
        public void InputData()
        {
            Console.Write("Введите название сайта: ");
            Name = Console.ReadLine();

            Console.Write("Введите путь к сайту (URL): ");
            Url = Console.ReadLine();

            Console.Write("Введите описание сайта: ");
            Description = Console.ReadLine();

            Console.Write("Введите IP адрес сайта: ");
            IpAddress = Console.ReadLine();
        }

        // Метод для вывода данных
        public void DisplayData()
        {
            Console.WriteLine("Название сайта: " + Name);
            Console.WriteLine("Путь к сайту (URL): " + Url);
            Console.WriteLine("Описание сайта: " + Description);
            Console.WriteLine("IP адрес сайта: " + IpAddress);
        }


    }


    class Journal
    {
        // Поля класса
        private string title;
        private int yearOfEstablishment;
        private string description;
        private string contactPhone;
        private string contactEmail;

        // Конструктор класса
        public Journal(string title, int yearOfEstablishment, string description, string contactPhone, string contactEmail)
        {
            this.title = title;
            this.yearOfEstablishment = yearOfEstablishment;
            this.description = description;
            this.contactPhone = contactPhone;
            this.contactEmail = contactEmail;
        }

        // Методы для доступа к полям
        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string value)
        {
            title = value;
        }

        public int GetYearOfEstablishment()
        {
            return yearOfEstablishment;
        }

        public void SetYearOfEstablishment(int value)
        {
            yearOfEstablishment = value;
        }

        public string GetDescription()
        {
            return description;
        }

        public void SetDescription(string value)
        {
            description = value;
        }

        public string GetContactPhone()
        {
            return contactPhone;
        }

        public void SetContactPhone(string value)
        {
            contactPhone = value;
        }

        public string GetContactEmail()
        {
            return contactEmail;
        }

        public void SetContactEmail(string value)
        {
            contactEmail = value;
        }

        // Метод для ввода данных
        public void InputData()
        {
            Console.Write("Введите название журнала: ");
            SetTitle(Console.ReadLine());

            Console.Write("Введите год основания: ");
            SetYearOfEstablishment(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Введите описание журнала: ");
            SetDescription(Console.ReadLine());

            Console.Write("Введите контактный телефон: ");
            SetContactPhone(Console.ReadLine());

            Console.Write("Введите контактный e-mail: ");
            SetContactEmail(Console.ReadLine());
        }

        // Метод для вывода данных
        public void DisplayData()
        {
            Console.WriteLine("Название журнала: " + GetTitle());
            Console.WriteLine("Год основания: " + GetYearOfEstablishment());
            Console.WriteLine("Описание журнала: " + GetDescription());
            Console.WriteLine("Контактный телефон: " + GetContactPhone());
            Console.WriteLine("Контактный e-mail: " + GetContactEmail());
        }
    }
    class Shop
    {
        // Поля класса
        private string _name;
        private string _address;
        private string _profileDescription;
        private string _contactPhone;
        private string _contactEmail;

        // Методы для доступа к полям
        public string GetName() {return _name; }

        public void SetName(string value) {_name = value;}

        public string GetAddress() { return _address; }


        public void SetAddress(string value)
        {
            _address = value;
        }

        public string GetProfileDescription()
        {
            return _profileDescription;
        }

        public void SetProfileDescription(string value)
        {
            _profileDescription = value;
        }

        public string GetContactPhone()
        {
            return _contactPhone;
        }

        public void SetContactPhone(string value)
        {
            _contactPhone = value;
        }

        public string GetContactEmail()
        {
            return _contactEmail;
        }

        public void SetContactEmail(string value)
        {
            _contactEmail = value;
        }

        // Метод для ввода данных
        public void InputData()
        {
            Console.Write("Введите название магазина: ");
            SetName(Console.ReadLine());

            Console.Write("Введите адрес магазина: ");
            SetAddress(Console.ReadLine());

            Console.Write("Введите описание профиля магазина: ");
            SetProfileDescription(Console.ReadLine());

            Console.Write("Введите контактный телефон: ");
            SetContactPhone(Console.ReadLine());

            Console.Write("Введите контактный e-mail: ");
            SetContactEmail(Console.ReadLine());
        }

        // Метод для вывода данных
        public void DisplayData()
        {
            Console.WriteLine("Название магазина: " + GetName());
            Console.WriteLine("Адрес магазина: " + GetAddress());
            Console.WriteLine("Описание профиля магазина: " + GetProfileDescription());
            Console.WriteLine("Контактный телефон: " + GetContactPhone());
            Console.WriteLine("Контактный e-mail: " + GetContactEmail());
        }
    }

}



