## Proste wykorzystanie biblioteki devDept EyeShot

Projekt przedstawia wykorzystanie biblioteki devDept EyeShot do tworzenia prostej siatki 3D sześcianów w aplikacji Windows Forms. Każdy sześcian ma losowy kolor, a razem tworzą kostkę przypominającą Kostkę Rubika.

### Kluczowe funkcje

- **Losowe Kolory**: Każdy sześcian w siatce ma przypisany losowy kolor.
- **Układ Siatki 3D**: Sześciany są ułożone w siatkę 3x3x3 z ustalonymi rozmiarami bloków i przerwami między nimi.
- **Widok 3D**: Scena 3D jest wyświetlana w domyślnym widoku dla lepszej wizualizacji.

### Przegląd Kodu

Główna logika jest zaimplementowana w klasie `MainForm`, gdzie:

- Tworzona jest siatka sześcianów 3x3x3.
- Każdy sześcian jest pozycjonowany z małą przerwą między nimi.
- Każdy sześcian ma przypisany losowy kolor.
- Scena 3D jest ustawiana na odpowiedni widok podczas ładowania.

### Zrzut Ekranu

![Siatka 3D Sześcianów]("cube.png")
