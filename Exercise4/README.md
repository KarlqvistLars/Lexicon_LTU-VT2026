# C# Övning 4 - Garage 1.0

### Ett första övergripande projekt
För att koppla samman mycket av det ni lärt er, så skall vi nu bygga en
garage / Consoleapplikation. Denna applikation skall tillhandahålla den funktionalitet som ett
system kan behöva om det skall användas för att simulera ett enkelt garage.
Det skall alltså gå att parkera fordon, hämta ut fordon, se efter vilka fordon som finns där och
vilka egenskaper de har. Allt detta i en konsolapplikation med huvudmeny och undermenyer.
Anledningen till att ni skall programmera ett garage är att det är enkelt att förankra
uppdelningen i det hela. Vi kan huvudsakligen dela upp ett garage i följande delar:
Garaget: En representation av själva byggnaden. Garaget är en plats där en mängd av fordon
kan förvaras. Garaget kan alltså representeras som en samling av fordon.
Fordon: Bilar, motorcyklar, enhjulingar eller vad för typ av fordon man nu vill ställa in i
garaget.
Dessa är de två “objekttyper” som man ser i ett fysiskt garage. Men tittar vi närmare bör det
också finnas subklasser till fordon, alltså att varje fordonstyp är en egen subklass i systemet.
Utöver detta krävs det funktionalitet som hanterar att fordon ställs in i garaget, att fordon kan
tas ut ur garaget, samt att vi kan få en presentation av vad som finns i garaget och söka i det. <br>
### I mer programmerings-vänliga termer skall vi alltså som minimum ha:<br>
- [ ] En kollektion av fordon; klassen Garage.  <br>
- [x] En fordonsklass, klassen Vehicle.<br>
- [x] Ett antal subklasser till fordon.<br>
- [ ] Ett användargränssnitt som låter oss använda funktionaliteten hos ett garage. Här
sker all interaktion med användaren.<br>

### Kravspecifikation
Fordonen ska implementeras som klassen Vehicle och subklasser till den.<br>
- [x] Vehicle innehåller samtliga egenskaper som ska finnas i samtliga fordonstyper.
T.ex. registreringsnummer, färg, antal hjul och andra egenskaper ni kan komma på.<br>
- [ ] Registreringsnumret är unikt
#### - [ ] Det måste minst finnas följande subklasser:<br>
- [ ] ○ Motorcycle<br>
- [ ] ○ Airplane<br>
- [ ] ○ Car<br>
- [ ] ○ Bus<br>
- [ ] ○ Boat<br>
### Dessa skall implementera minst en egen egenskap var, t.ex:<br>
- [ ] ○ Number of Engines
- [ ] ○ Cylinder volume
- [ ] ○ Fueltype (Gasoline/Diesel)
- [ ] ○ Number of seats
- [ ] ○ Length
Klassen behöver inte ärva från någon annan klass eller implementera något annat interface.
Samlingen av fordon ska internt i klassen hanteras som en array. Den interna arrayen ska
var privat. Vid instansieringen av ett nytt garage måste kapaciteten anges som argument till
konstruktorn.
Vi ska EJ använda oss av en List<Vehicle> internt i Garage klassen!!!!
Funktionalitet
### Det ska gå att:
- [ ] Lista samtliga parkerade fordon<br>
- [ ] Lista fordonstyper och hur många av varje som står i garaget<br>
- [ ] Lägga till och ta bort fordon ur garaget<br>
- [ ] Sätta en kapacitet (antal parkeringsplatser) vid instansieringen av ett nytt garage<br>
- [ ] Möjlighet att populera (sätta in bilar) i garaget med ett antal fordon från start.
- [ ] Hitta ett specifikt fordon via registreringsnumret. Det ska fungera med både ABC123
samt Abc123 eller AbC123.<br>
- [ ] Söka efter fordon utifrån en egenskap eller flera (alla möjliga kombinationer från
basklassen Vehicle). <br>
#### Exempelvis:<br>
- [ ] ○ Alla svarta fordon med fyra hjul.<br>
- [ ] ○ Alla motorcyklar som är rosa och har 3 hjul.<br>
- [ ] ○ Alla lastbilar<br>
- [ ] ○ Alla röda fordon<br><br>
- [ ] Användaren ska få feedback på att saker gått bra eller dåligt. Till exempel när vi
parkerat ett fordon vill vi få en bekräftelse på att fordonet är parkerat. Om det inte går
vill användaren få veta varför.
Programmet ska vara en konsolapplikation med ett textbaserat användargränssnitt.<br>
### Från gränssnittet skall det gå att:<br>
- [ ] Navigera till samtlig funktionalitet från garage via gränssnittet<br>
- [ ] Skapa ett garage med en användar-specificerad storlek<br>
- [ ] Det skall gå att stänga av applikationen från gränssnittet<br>
Applikationen skall fel hantera indata på ett robust sätt, så att den inte kraschar vid felaktig inmatning eller användning.

## Lösning
Skiss på klasserna.
<br>
![UML](https://github.com/KarlqvistLars/Lexicon_LTU-VT2026/blob/main/Exercise4/Exercise4/Bilder/UnifiedModelingLanguageDigram20260508.jpg)

### [Tillbaka](https://github.com/KarlqvistLars/Lexicon_LTU-VT2026/tree/main)
