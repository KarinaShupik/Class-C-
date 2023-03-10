using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Lab_16
{
    class Address
    {
        /*
         Побудувати опис класу, що містить інформацію про поштову адресу
        організації. Передбачити можливість роздільної зміни складових частин
        адреси, створення й знищення об’єктів цього класу.*/

        /*Розробити клас, який повинен містити три конструктори, властивості, по
        можливості передбачити статичні елементи класу та перевантаження методів.
        Розробити Windows Form додаток, яка демонструє роботу класу. */
        public string Name { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Flat { get; set; }
        public string Email { get; set; }
        public string LocationName { get; set; }
        public string LocationRegion { get; set; }
        public string LocationArea { get; set; }
        public string CountryName { get; set; }
        public string Index { get; set; }

        //без параметрів
        //конструктори
        //ім'я користувача
        public Address(string name)
        {
            Name = name;
        }
        //телефон та email користувача
        public Address(string number, string email)
        {
            Number = number;
            Email = email;
        }
        //локація проживання користувача 
        public Address(string street, string house, string flat, string location, string region, string area)
        {
            Street = street;
            House = house;
            Flat = flat;
            LocationName = location;
            LocationRegion = region;
            LocationArea = area;
        }

        public Address(string user, string phone, string street, string house, string flat, string email, string locationName, string region, string area, string country, string index)
        {
            Name = user;
            Number = phone;
            Street = street;
            House = house;
            Flat = flat;
            Email = email;
            LocationName = locationName;
            LocationRegion = region;
            LocationArea = area;
            CountryName = country;
            Index = index;
        }

        public override string ToString()
        {
            return $"Найменування адресата: {Name}\n" +
                   $"Номер мобільного: {Number}\n" +
                   $"Найменування вулиці: {Street}\n" +
                   $"Номер будинку: {House}\n" +
                   $"Номер квартири: {Flat}\n" +
                   $"Електронна почта: {Email}\n" +
                   $"Найменування населеного пункту: {LocationName}\n" +
                   $"Найменування району: {LocationRegion}\n" +
                   $"Найменування області: {LocationArea}\n" +
                   $"Країна призначення: {CountryName}\n" +
                   $"Індекс: {Index}";     
        }

        public void Print()
        {
            MessageBox.Show(ToString());
        }

    }
}
