# Övning 1

## C# Övning 1 - Personalregister
Inlämning Instruktioner. Finns även en snabbguide att följa under C-Sharp => Files => GIT
> 1. Add to source control nere i högra hörnet, välj git, Alternativt Git menyn Create Git
> Repository
> 2. Kryssa UR Checkboxen Private
> 3. Create and Publish
> 4. Kontrollera att repositoriet skapats i webbläsaren och alla filer finns med. Om så är fallet
> kan du hoppa över resten. Annars följ nästa steg.
> 5. Gå till git changes i Visual Studio.
> 6. Skriv in ett commit meddelande tryck på Commit
> 7. Efter det Push med pilen uppåt. Alternativt Sync med två pilar i en cirkel.
> 8. Kontrollera enligt punkt 4.
> 9. Klart

<br>
Se till att skicka upp koden med god marginal innan tiden är ute!
Bakgrund
Ett litet företag i restaurangbranschen kontaktar dig för att utveckla ett litet
personalregister. De har endast två krav:<br><br>
* Registret skall kunna ta emot och lagra anställda med namn och lön. (via inmatning
 i konsolen, inget krav på persistent lagring)<br>
 <br>
* Programmet skall kunna skriva ut registret i en konsol.<br>

### [Övningens dokumentation](https://karlqvistlars.github.io/Lexicon_LTU-VT2026/api/Exercise1/Exercise1.html)

### Uppgift 1<br>
Vilka klasser bör ingå i programmet?<br>
#### SVAR: 
Program, Employee och FileHandler.<br>
### Uppgift 2<br>
Vilka attribut och metoder bör ingå i dessa klasser?<br>
#### SVAR: 
**Program** - Innehåller Main, initialiseingar och menyhantering
<br>**Employee** - Class som skapar person med attributen: födelseår, namn och timlön.
<br>**FileHandler** - Class som hanterar misc och filhantering samt innehåller method'erna, AddPerson, ShowPerson, SavePeople och LoadPeople
<br>
### Uppgift 3<br>
Skriv programmet<br>

### =====================================================
<br>

![Exercise1b](https://github.com/KarlqvistLars/Lexicon_LTU-VT2026/blob/main/docs/bilder/Exercise1b.jpg)

<br>

Gjorde även en variant Exercise1b men Grafiskt användargänssnitt. Hittas [här.](Exercise1/Exercise1/Exercise1b)<br><br>

### =====================================================

### [Tillbaka](https://github.com/KarlqvistLars/Lexicon_LTU-VT2026/tree/main)
