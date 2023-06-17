# CarWorkshop

Czym jest MVC?
Skrót składa się z trzech wyrazów Model, View, Controller.

**Model** - dane, przesyłane z backendu na frontend i w drugą strone.

**View** - wygenerowany kod HTML, któy w przeglądarce wyświetli dane.

**Controller** - kod po stronie backendu, który jest w stanie obsłużyć zapytanie przychodzące do klienta i zwrócić odpowiedź.

W kontekście komunikacji architektury MVC możemy wyróżnić dwa główne przypadki użycia, pierwszy to:

1.WYSWIETLENIE DANYCH, w tym przypadku użytkownik który jest już na widoku **View** korzystając z aplikacji wysyła zapytanie http które jest odpowiednio odczytane po stronie backendu i bedzie przeprocesowane w kontrollerze **Controller** i na podstawie zapytania które wyszło od klienta kontroller **Controller** bedzię w stanie ufromować model danych który następnie zostanie zwrócony po odpowiednim przerenderowaniu na kod html z powrotem do widoku naszego użytkownika **View**.

Drugim najcześciej używanym przypadkiem to komunikacja w drugą stronę czyli 2.PRZESYLANIE NA NASZ SERWER, w takim przypadku na widoku **View** model jest formowany na podstawie formularza przez który użytkownik jest w stanie wporwadzić dane po czym odpowiednio wykonujac metode taki formularz może zostać wysłany na backend.

**Architektura i biblioteki użyte w projekcie:**
Bootrstrap - biblioteka frontendowa zawierająca zbiór predefiniowanych klas css
Clean Architecture - schemat wykorzystywany w separacji zagadnień, wyznacza cztery główne moduły systemu: Presentation, Appliacation, Domain, Infrastructure

Entity Framework - Entity Framework umożliwia deweloperom pracę z danymi w postaci obiektów i właściwości specyficznych dla domeny, takich jak klienci i adresy klientów, bez konieczności samodzielnej pracy z bazowymi tabelami i kolumnami bazy danych. Jeden z najpopularniejszych narzędzi ORM.
  
FluentValidation - jest biblioteką, która pozwala pisać reguły walidacyjne za pomocą interfejsu fluent.





