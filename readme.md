# HashWarden

## Opis aplikacji

**HashWarden** to aplikacja desktopowa służąca do zarządzania hasłami użytkownika. Umożliwia tworzenie i organizowanie zapisanych danych logowania w folderach, przypisywanie ich do kont użytkowników oraz bezpieczne przechowywanie haseł w formie zaszyfrowanej. Aplikacja została zbudowana w technologii C# przy użyciu Windows Forms oraz Entity Framework Core w podejściu Code First. Jako system bazodanowy wykorzystano PostgreSQL.

## Funkcje

- **Uwierzytelnianie użytkownika**
- **Przechowywanie szyfrowanych haseł**
- **Organizacja folderów**
- **Zarządzanie hasłami**
- **Zarządzanie sesją**
- **Eksport/import danych**
- **Wyszukiwanie wpisów**
- **Zmiana połączenia w aplikacji**

## Implementacja Bezpieczeństwa

Bezpieczeństwo danych użytkownika jest kluczowym aspektem aplikacji HashWarden. Implementacja obejmuje:

### Haszowanie Hasła Głównego

**Algorytm: Argon2**  

Proces: Hasło główne użytkownika jest haszowane przy użyciu algorytmu Argon2 z unikalną solą dla każdego użytkownika. Hasz i sól są przechowywane w bazie danych.

### Szyfrowanie Haseł

**Algorytm: AES (Advanced Encryption Standard)**  

Proces: Hasła użytkownika są szyfrowane przy użyciu algorytmu AES z unikalnym wektorem inicjalizacyjnym (IV) dla każdego hasła. Klucz szyfrowania jest pochodną hasła głównego użytkownika.

### Zarządzanie Kluczem Sesji

**Komponent: SessionKeyManager**  

Funkcja: Po pomyślnym uwierzytelnieniu, aplikacja generuje i przechowuje klucz sesji w pamięci, umożliwiając szyfrowanie i deszyfrowanie haseł podczas sesji użytkownika. Klucz sesji jest usuwany z pamięci po wylogowaniu lub zamknięciu aplikacji.

## Technologie

* **Język programowania:** C# (.NET)

* **Interfejs użytkownika:** Windows Forms

* **Baza danych:** Entity Framework z relacyjnym modelem danych

* **Szyfrowanie:** AES dla danych, Argon2 dla haseł

* **Serializacja:** JSON dla importu/eksportu danych

## Opis bazy danych

Baza danych składa się z trzech głównych tabel: `Users`, `Folders` i `Passwords`.

### Tabela Users

| Atrybut      | Typ danych | Opis                                       |
| ------------ | ---------- | ------------------------------------------ |
| `Id`         | GUID       | Unikalny identyfikator użytkownika         |
| `Email`      | string     | Adres e-mail użytkownika                   |
| `MasterHash` | string     | Hasz hasła głównego (Argon2)               |
| `Salt`       | string     | Unikalna sól używana do haszowania         |
| `Iv`         | string     | Wektor inicjalizacyjny dla szyfrowania AES |

### Tabela Folders

| Atrybut      | Typ danych | Opis                                           |
| ------------ | ---------- | ---------------------------------------------- |
| `Id`         | GUID       | Unikalny identyfikator folderu                 |
| `FolderName` | string     | Nazwa folderu                                  |
| `UserId`     | GUID       | Identyfikator użytkownika, właściciela folderu |

### Tabela Passwords

| Atrybut             | Typ danych | Opis                                           |
| ------------------- | ---------- | ---------------------------------------------- |
| `Id`                | GUID       | Unikalny identyfikator hasła                   |
| `Title`             | string     | Tytuł lub opis hasła                           |
| `EncryptedPassword` | string     | Zaszyfrowane hasło                             |
| `Iv`                | string     | Wektor inicjalizacyjny dla szyfrowania AES     |
| `UserId`            | GUID       | Identyfikator użytkownika, właściciela hasła   |
| `FolderId`          | GUID       | Identyfikator folderu, do którego należy hasło |

### Relacje
* **User -< Folder** (1 - N): Jeden użytkownik może posiadać wiele folderów.

* **Folder -< Password** (1 - N): Jeden folder może zawierać wiele haseł.

* **User -< Password** (1 - N): Jeden użytkownik może posiadać wiele haseł.

## Struktura projektu
Projekt HashWarden jest zorganizowany zgodnie ze standardami .NET:

* **Forms**: Komponenty interfejsu użytkownika (LoginForm, MainForm, AddPasswordForm, itp.)

* **Models**: Modele danych Entity Framework (User, Password, Folder) oraz model eksportu haseł(ExportModel)

* **Data**: Kontekst bazy danych i logika inicjalizacji (HashWardenDbContext, DatabaseSeeder)

* **Utils**: Klasy pomocnicze i logika biznesowa (EncryptionProvider, SessionKeyManager)

* **Images**: Ikony aplikacji i zasoby interfejsu użytkownika

* **Seeders**: Seedery do zapełniania bazy danych

* **Migrations**: Automatycznie generowane pliki migracji EF Core służące do tworzenia i aktualizacji schematu bazy danych

Punkt wejścia aplikacji to **Program.cs**, który inicjalizuje kontekst bazy danych, stosuje wszelkie oczekujące migracje, inicjalizuje dane i uruchamia formularz logowania.

## Wymagania

- .NET 6.0+
- PostgreSQL 12+

## Konfiguracja

1. Stworzyć plik `appsettings.json` w głównym folderze projektu.

2. W pliku `appsettings.json` należy dodać ciąg połączenia do bazy PostgreSQL (zmienić hasło i w razie potrzeby nazwę użytkownika):

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=HashWardenDB;Username=postgres;Password=yourpassword"
  }
}
```

3. Wykonać migrację bazy danych:  
W terminalu:
```bash
    dotnet ef migrations add Init
    dotnet ef database update
```

Lub w konsoli Packet Manager:
```bash
    Add-Migration Init
    Update-Database
```

4. Uruchomić aplikację w terminalu:
```bash
    dotnet run
```

## Widoki

### Logowanie
![Logowanie](ViewImages/LoginView.png)
### Rejestracja
![Rejestracja](ViewImages/RegisterView.png)
### Główny panel
![Główny panel](ViewImages/MainView.png)
### Zapisane hasło
![Zapisane hasło](ViewImages/SavedPasswordView.png)
