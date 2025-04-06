# Sprawozdanie – Projekt aplikacji bazodanowej .NET

## Cel projektu

Celem projektu było stworzenie aplikacji konsolowej w języku C# z wykorzystaniem .NET 8.0, która umożliwia:
- Pobieranie danych pogodowych z API Open Exchange Rates.
- Wyświetlanie użytkownikowi kursów walut w stosunku do USD.
- Rozszerzenie aplikacji o prostą bazę danych SQLite przy użyciu Entity Framework Core.
- Zapis kursów walut z podanego dnia do bazy danych i ich odczyt, jeśli są już dostępne w bazie.
- Implementację podstawowej relacji między tabelami.
- Implementację GUI przy wykorzystaniu technologii MAUI.

## Użyte technologie

- Język programowania: C#
- Platforma: .NET 8.0
- Biblioteka ORM: Entity Framework Core
- Baza danych: SQLite
- API: Open Exchange Rates

## Aktualne funkcjonalności aplikacji

- Użytkownik wpisuje datę z której zostaną pobrane kursy walut
- Program pobiera kursy z API Open Exchange Rates.
- Program zapisuje kursy do bazy danych.
- Dane są prezentowane w czytelnej formie w konsoli.

## Struktura projektu

- `Exchange Rates` - klasa przechowująca kursy walut
- `Currency` - klasa przechowująca dane do bazy danych
- `DB` - klasa do tworzenia bazy danych
- `CurrencyAPI` – klasa odpowiedzialna za pobieranie i obsługi danych.

## Problemy i ograniczenia

W obecnej wersji projektu **nie udało się w pełni skorzystać z funkcjonalności bazy danych**.


## Wnioski i dalszy rozwój

- W celu dokończenia projektu należy poprawić obsługę bazy danych, oraz interfejs GUI.

## Autor

Imię i nazwisko: Michał Janusz  
Grupa: [.NET][CZ 15:15][LAB2]  
