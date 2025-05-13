# HashWarden

## Opis aplikacji

HashWarden to aplikacja desktopowa służąca do zarządzania hasłami użytkownika. Umożliwia tworzenie i organizowanie zapisanych danych logowania w folderach, przypisywanie ich do kont użytkowników oraz bezpieczne przechowywanie haseł w formie zaszyfrowanej. Aplikacja została zbudowana w technologii C# przy użyciu Windows Forms oraz Entity Framework Core w podejściu Code First. Jako system bazodanowy wykorzystano PostgreSQL.

## Funkcje

- Logowanie
- Zapisywanie kont
- Przechowywanie szyfrowanych haseł
- Sortowanie wpisów po folderach
- Zarządzanie hasłami

## Opis bazy danych

Baza danych składa się z trzech głównych tabel: `Users`, `Folders` i `Passwords`.

| Tabela     | Kolumny                                | Relacje                                      |
|------------|----------------------------------------|----------------------------------------------|
| Users      | Id, Email, MasterHash, Salt, CreatedAt | 1:N z Folders, 1:N z Passwords               |
| Folders    | Id, FolderName, UserId                 | N:1 z Users, 1:N z Passwords                 |
| Passwords  | Id, Title, ServiceName, EncryptedPassword, Iv, CreatedAt, UpdatedAt, FolderId, UserId | N:1 z Users, N:1 z Folders |

## Wymagania

- .NET 6.0+
- PostgreSQL 12+

## Konfiguracja

1. W pliku `appsettings.json` należy dodać ciąg połączenia do bazy PostgreSQL:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=HashWardenDB;Username=postgres;Password=postgres"
  }
}
```

2. Wykonać migrację bazy danych:
```bash
    Add-Migration InitialCreate
    Update-Database
```
