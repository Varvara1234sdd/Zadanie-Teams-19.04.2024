using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace SimpleContactManager
{
    // Klasa FileContactStorage implementuje interfejs IContactStorage i obsługuje przechowywanie kontaktów w pliku JSON.
    public class FileContactStorage : IContactStorage
    {
        // Ścieżka do pliku przechowującego kontakty.
        private readonly string _filePath = "contacts.json";
        // Lista przechowująca kontakty.
        private List<Contact> _contacts;

        // Konstruktor klasy FileContactStorage.
        public FileContactStorage()
        {
            // Sprawdzenie, czy plik istnieje.
            if (File.Exists(_filePath))
            {
                // Odczytanie zawartości pliku JSON.
                var json = File.ReadAllText(_filePath);
                // Deserializacja JSON do listy kontaktów lub utworzenie nowej listy, jeśli plik jest pusty.
                _contacts = JsonConvert.DeserializeObject<List<Contact>>(json) ?? new List<Contact>();
            }
            else
            {
                // Utworzenie nowej listy kontaktów, jeśli plik nie istnieje.
                _contacts = new List<Contact>();
            }
        }

        // Metoda dodająca nowy kontakt do listy i zapisująca zmiany w pliku.
        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
            Save();
        }

        // Metoda usuwająca kontakt z listy i zapisująca zmiany w pliku.
        public void RemoveContact(Contact contact)
        {
            _contacts.Remove(contact);
            Save();
        }

        // Metoda zwracająca listę wszystkich kontaktów.
        public List<Contact> GetContacts()
        {
            return _contacts;
        }

        // Metoda zapisująca aktualną listę kontaktów do pliku JSON.
        private void Save()
        {
            var json = JsonConvert.SerializeObject(_contacts, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}
