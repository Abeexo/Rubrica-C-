# README for Contact Management System in C#

This C# program implements a straightforward contact management system enabling users to manage contacts through functionalities such as addition, removal, search, and merging within a phonebook.
Usage Instructions:

    Compilation: Compile the C# files using a suitable C# compiler or an Integrated Development Environment (IDE).
    Execution: Run the compiled program.
    Follow the on-screen instructions to execute various contact management tasks.

Program Features:

    Add Contact: Include a new contact's details—name, home number, mobile number, and office number.
    Remove Contact: Delete a contact by specifying the contact's name.
    Merge Contacts: Combine two contacts' information (home number, mobile number, and office number) into one contact.
    Search Contacts: Search for contacts by entering a name and retrieve matching contacts.
    List Contacts Ordered by Name: Display a list of all contacts ordered alphabetically by name.
    Exit Program: Terminate the application.

Usage Notes:

    Contact details include name, home number, mobile number, and office number.
    Numeric input validation is implemented when entering contact numbers to ensure only digits are entered.
    Contacts are stored in memory during program execution and are not saved permanently.

C# Files:

    Contatto.cs: Defines the structure for a contact (name, home number, mobile number, and office number).
    Rubrica.cs: Implements a phonebook (collection of contacts) with methods to manage contacts.
    GestioneRubrica.cs: Provides the user interface for managing contacts through a console application.

Running the Program:

    Compile and execute the GestioneRubrica.cs file, which contains the entry point (Main method) for the application.

Feel free to utilize, modify, or expand upon this code for educational or personal use. Enjoy managing your contacts with this simple console-based application!

-----------------------------------------------------------

# README per il Sistema di Gestione dei Contatti in C#

Questo programma C# implementa un sistema semplice di gestione dei contatti che consente agli utenti di gestire i contatti aggiungendoli, rimuovendoli, cercandoli e unendoli all'interno di una rubrica telefonica.
Istruzioni per l'Uso:

    Compilazione: Compilare i file C# utilizzando un compilatore C# o un ambiente di sviluppo integrato (IDE) che supporti C#.
    Esecuzione: Eseguire il programma compilato.
    Seguire le istruzioni visualizzate per eseguire varie attività di gestione dei contatti.

Funzionalità del Programma:

    Aggiungi Contatto: Aggiungi un nuovo contatto specificando nome, numero di casa, numero di cellulare e numero dell'ufficio.
    Rimuovi Contatto: Rimuovi un contatto specificando il nome del contatto.
    Unisci Contatti: Combina le informazioni di due contatti (numero di casa, numero di cellulare e numero dell'ufficio) in un unico contatto.
    Cerca Contatti: Cerca i contatti inserendo un nome e recuperando i contatti corrispondenti.
    Elenco Contatti Ordinati per Nome: Mostra un elenco di tutti i contatti ordinati in ordine alfabetico per nome.
    Esci dal Programma: Termina l'applicazione.

Note sull'Utilizzo:

    I dettagli del contatto includono nome, numero di casa, numero di cellulare e numero dell'ufficio.
    La validazione dell'input numerico è implementata quando si inseriscono numeri di contatto per garantire che siano inseriti solo numeri.
    I contatti sono memorizzati in memoria durante l'esecuzione del programma e non vengono salvati permanentemente.

File C#:

    Contatto.cs: Definisce la struttura di un contatto (nome, numero di casa, numero di cellulare e numero dell'ufficio).
    Rubrica.cs: Implementa una rubrica telefonica (raccolta di contatti) con metodi per gestire i contatti.
    GestioneRubrica.cs: Fornisce l'interfaccia utente per la gestione dei contatti attraverso un'applicazione console.
