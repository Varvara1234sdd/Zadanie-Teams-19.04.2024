using System.Collections.Generic;

namespace SimpleContactManager
{
    // Interfejs IContactStorage definiuje operacje do zarządzania kontaktami.
    public interface IContactStorage
    {
        // Metoda dodająca nowy kontakt do przechowywania.
        void AddContact(Contact contact);
        
        // Metoda usuwająca istniejący kontakt z przechowywania.
        void RemoveContact(Contact contact);
        
        // Metoda zwracająca listę wszystkich kontaktów przechowywanych.
        List<Contact> GetContacts();
    }
}
