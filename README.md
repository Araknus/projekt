# projekt
projekt na ZPO

Typy użytkowników:

- Nauczyciel
- Uczeń
- (opcjonalnie) Administrator

# Każdy użytkownik:

- może się zalogować (jest autoryzowany przy logowaniu)
- może się wylogować (będąc zalogowany)
- może się cofnąć do poprzedniego ekranu (będąc zalogowany)

# Nauczyciel (po zalogowaniu):
- aplikacja wyświetla listę klas (do projektu przyjmijmy klasę IA i IB)
- nauczyciel wybiera z listy konkretną klasę
- wyświetla się lista uczniów (do projektu przyjmijmy po 10 osób w każdej klasie)
- po wyborze konkretnego ucznia wyświetla się jego dziennik z przedmiotu prowadzonego przez zalogowanego nauczyciela
- nauczyciel może każdą ocenę dodać, edytować i usunąć (nie potrzeba dodatkowo zatwierdzać operacji)

# Uczeń (po zalogowaniu)
- widzi dwa interaktywne okienka ("Moja klasa" i "Mój dziennik")
- po wyborze "Mojej klasy", na ekranie wyświetlani są uczniowie należący do klasy ucznia
- po wyborze "Mojego dziennika", wyświetlane są interaktywne okienka z nazwami przedmiotu (do projektu przyjmijmy Matematykę i Język Polski)
- po wyborze przedmiotu wyświetlane są oceny z wybranego przedmiotu

# (opcjonalnie) - administrator
- dodaje / usuwa / edytuje nauczycieli i uczniów

# W skrócie:
- brak możliwości rejestracji, dane użytkowników są wrzucone do bazy danych
- dwa typy użytkowników
- dwóch nauczycieli (jeden od matematyki, drugi od języka polskiego)
- dwie klasy (IA i IB)
- w każdej klasie po 10 uczniów (chłopcy i dziewczęta)
- dwa przedmioty (Matematyka i Język Polski)
- logowanie to trzy pierwsze litery imienia + trzy pierwsze litery nazwiska + dwie ostatnie cyfry z roku urodzenia + @school.pl - 
dla przykładu Jan Kowalski urodzony w 1993 roku będzie się logował za pomocą loginu jankow93@school.pl, hasło początkowe jest takie same,
ale użytkownik ma możliwość jego zmiany















