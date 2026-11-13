# Lern-Periode 2

## Projekt

Mein neues Projekt ist ein Schul- und Prüfungsplaner in C# mit Windows Forms. Man soll Prüfungen, Hausaufgaben und andere Termine eintragen und verwalten können. Später möchte ich noch weitere Funktionen wie einen Kalender und Erinnerungen hinzufügen.

## Grob-Planung

Ich möchte ein C#-Programm erstellen, mit dem ich meine Prüfungen und Hausaufgaben organisieren kann. Man soll Termine hinzufügen, bearbeiten und löschen können. Die Termine sollen gespeichert werden, damit sie beim nächsten Start noch vorhanden sind.

## 16.10.2026

- [x] Ein neues Windows-Forms-Projekt erstellen und das Hauptfenster mit einem Titel gestalten.
- [x] Textfelder für den Namen, das Fach und das Datum eines Termins hinzufügen.

Ich habe heute das Hauptfenster für meinen Schulplaner erstellt und gestaltet. Danach habe ich die Textfelder für den Namen, das Fach und das Datum hinzugefügt. Dabei hatte ich keine grösseren Probleme gehabt.

## Hausaufgaben vom 16.10.2026

- [x] Einen Button zum Hinzufügen von Terminen erstellen und die eingegebenen Daten beim Anklicken mit einer MessageBox anzeigen.

Ich habe einen Hinzufügen-Button erstellt und mit einem Klick-Ereignis verbunden. Beim Anklicken werden Name, Fach und Datum aus den Textfeldern gelesen und in einer MessageBox angezeigt.

## 23.10.2026
- [x] Prüfen, ob Name und Fach ausgefüllt sind, und bei fehlenden Angaben eine Meldung anzeigen.
- [x] Das Datumsfeld durch einen DateTimePicker ersetzen, damit ein gültiges Datum ausgewählt werden kann.
- [x] Eine Tabelle mit den Spalten Name, Fach und Datum auf dem Formular einfügen.
- [x] Den Hinzufügen-Button so erweitern, dass neue Termine in der Tabelle erscheinen und die Eingabefelder danach geleert werden.

Heute haben wir den Schulplaner erweitert: Name und Fach werden vor dem Hinzufügen geprüft, und das Datum wird mit einem DateTimePicker ausgewählt. Neue Termine erscheinen in einer Tabelle mit den Spalten Name, Fach und Datum. Nach dem Hinzufügen werden die Eingaben zurückgesetzt. Ausserdem haben wir einen Löschen-Button eingebaut und einen Fehler behoben, durch den das Löschen nicht funktionierte. Als Nächstes wollen wir die Termine speichern, damit sie nach einem Neustart erhalten bleiben.

## Hausaufgaben vom 16.10.2026

- [x] In Form1.cs eine Methode erstellen, die alle Termine aus der Tabelle sammelt.

Ich habe eine Methode eingebaut, die alle Termine aus der Tabelle ausliest. Dabei musste ich darauf achten, dass leere Zellen keinen Fehler verursachen. Die Termine werden aber noch nicht gespeichert.

## 30.10.2026
- [x] Die Termine beim Schliessen des Programms in einer JSON-Datei speichern.
- [x] Die gespeicherten Termine beim Start laden und wieder in der Tabelle anzeigen.
- [x] Testen, ob hinzugefügte und gelöschte Termine nach einem Neustart korrekt angezeigt werden.
- [x] Einen Termin in der Tabelle auswählen und seine Daten in die Eingabefelder übernehmen.
Heute habe ich meinen Schulplaner erweitert. Ich kann Termine jetzt hinzufügen, bearbeiten und löschen. Sie werden gespeichert und beim nächsten Start wieder geladen. Ausserdem habe ich einen Kalender und Erinnerungen für anstehende Termine eingebaut.

## Hausaufgaben vom 30.10.2026
- [x] Ein einheitliches Farbschema für das Fenster, die Buttons und die Tabelle gestalten.

## 06.11.2026
- [x] Abstände, Schriftgrössen und die Anordnung der Elemente verbessern, damit das Fenster übersichtlicher wird.
- [x] Einen Filter einbauen, der nur Prüfungen, Hausaufgaben oder andere Termine anzeigt.
- [x] Die Termine nach Datum sortieren, sodass die nächsten Termine oben stehen.
- [x] Termine als erledigt markieren und in der Tabelle entsprechend anzeigen.

Ich habe die Hausaufgaben und die Aufgaben vom für den 06.11.2026 beide am 01.11.2026 gemacht.
Ich habe die Farben, Schriftgrössen und Abstände im Schulplaner verbessert. Ausserdem kann ich Termine nach Art filtern, nach Datum sortieren und als erledigt markieren. Der Status bleibt auch nach einem Neustart gespeichert.

## 13.11.2026

- [x] Löschen absichern: Den Terminnamen in der Bestätigung anzeigen und «Ja» und «Nein» testen.
- [x] Statusfilter: Nach «Offen» oder «Erledigt» filtern und den Filter mit der Terminart kombinieren.
- [ ] Überfällige Termine: Offene Termine vor heute farblich markieren und die Farbe unter der Tabelle erklären.
- [ ] Notizen: Ein mehrzeiliges Notizfeld einbauen und prüfen, ob die Notiz nach einem Neustart wieder angezeigt wird.
