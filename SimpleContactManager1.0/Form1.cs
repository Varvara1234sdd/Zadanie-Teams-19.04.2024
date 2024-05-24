using System;
using System.Linq;
using System.Windows.Forms;

namespace SimpleContactManager
{
    // Klasa Form1 reprezentuje główne okno aplikacji.
    public partial class Form1 : Form
    {
        // Pole _contactStorage przechowuje obiekt implementujący interfejs IContactStorage,
        // który jest używany do zarządzania kontaktami.
        private readonly IContactStorage _contactStorage;

        // Konstruktor klasy Form1.
        public Form1()
        {
            InitializeComponent();
            // Inicjalizacja _contactStorage jako obiektu FileContactStorage.
            _contactStorage = new FileContactStorage();
            // Aktualizacja listy kontaktów po uruchomieniu aplikacji.
            UpdateContactList();
        }

        // Metoda UpdateContactList służy do aktualizacji listy kontaktów wyświetlanej w interfejsie użytkownika.
        private void UpdateContactList()
        {
            // Wyczyść aktualną listę kontaktów.
            listBoxContacts.Items.Clear();
            // Iteruj przez wszystkie kontakty pobrane z _contactStorage i dodaj ich nazwy do listy.
            foreach (var contact in _contactStorage.GetContacts())
            {
                listBoxContacts.Items.Add(contact.Name);
            }
        }

        // Obsługa zdarzenia kliknięcia przycisku Dodaj.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Utwórz nowy obiekt kontaktu na podstawie danych wprowadzonych przez użytkownika.
            var contact = new Person
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text
            };

            // Dodaj nowy kontakt do _contactStorage.
            _contactStorage.AddContact(contact);
            // Zaktualizuj listę kontaktów.
            UpdateContactList();
        }

        // Obsługa zdarzenia kliknięcia przycisku Usuń.
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // Sprawdź, czy został wybrany kontakt z listy.
            if (listBoxContacts.SelectedItem != null)
            {
                // Pobierz wybrany kontakt z _contactStorage na podstawie jego nazwy.
                var contact = _contactStorage.GetContacts().FirstOrDefault(c => c.Name == listBoxContacts.SelectedItem.ToString());
                // Jeśli kontakt istnieje...
                if (contact != null)
                {
                    // Usuń kontakt z _contactStorage.
                    _contactStorage.RemoveContact(contact);
                    // Zaktualizuj listę kontaktów.
                    UpdateContactList();
                }
            }
        }
    }
}



//Struktura projektu:

///Klasa Contact (klasa bazowa).
//Klasa Person (dziedziczy po Contact).
//Klasa Company (dziedziczy po Contact).
//Interfejs IContactStorage z metodami do dodawania, usuwania i pobierania kontaktów.
//Klasa FileContactStorage, implementująca interfejs i wykorzystująca JSON do przechowywania danych.
//Prosty interfejs Windows Forms do interakcji z użytkownikiem.



/*  Wynik
Aplikacja będzie spełniać wszystkie wymagania:

Trzy klasy (Contact, Person, Company).
Klasy Person i Company dziedziczą po Contact.
Interfejs IContactStorage i jego implementacja.
Dane są zapisywane w pliku JSON.
  */