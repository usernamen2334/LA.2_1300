# LA.2_1300

# Projekt-Dokumentation

Erik Marku

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 18.08.2023 | 0.0.1   | Ich habe mich wieder in C# eingelebt und habe mir eine grobe Vorstellung von meinem Projekt verschafft und konnte somit mein Projekt planen. |
| 25.08.2023 | 0.0.2   |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

In diesem Projekt werde ich einen coolen Numberguesser Spiel programmieren.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1  |   Muss              | Funktional     | Als ein User möchte ich die Möglichkeit erhalten, die Zufällig generierte Zahl zu erraten. |
| 2  |  Muss               | Funktional     | Als ein User möchte ich informiert werden, ob meine Zahl richtig oder falsch ist           |
| 3  |  Muss               | Funktional     | Als ein User möchte ich informiert werden, ob die zufällig generierte Zahl höher oder tiefer als meine geratene Zahl ist.                                  |
| 4  |  Muss               | Funktional     | Als ein User möchte ich eine Siegesnachricht erhalten, auf der ich sehen kann, wie viel Ratte versuche, ich gebraucht habe, sobald ich die Zahl erraten habe.                                  |
| 5  |  Muss               | Funktional     | Als ein User möchte ich, sobald ich die Zahl erraten habe, eine Chance bekommen nochmals zu spielen oder auch nicht.                                  |
| 6  |  Muss               | Funktional     | Als ein User möchte ich, dass falls ich mich entscheide nochmals zu spielen, eine neue Zahl generiert wird.                                   |
| 7  |  Muss               | Funktional     | Als ein User möchte ich, dass falls ich mich entscheide nicht nochmals zu spielen, das sich das Programm asbchliesst.                                  |
| 8  |  Muss               | Funktional     | Als ein User möchte ich, dass nach jedem Commit, den ich abgebe, die vorherigen Zeilen sich automatisch löschen.                                  |
| 9  |  Muss               | Funktional     | Als ein User möchte ich, dass das Spiel mit Fehleingabe (wie Z. B. ein #, ! Usw. Eingebe) umgehen kann.                                  |


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Programm ist offen. | F5 (um Programm zu starten) |  Versuchen sie die zufällige Zahl zu erraten.                  |
| 2.1  | Zahl wurde eingegeben. | Enter         |   Ihre Zahl ist falsch/richtig.                |
| 3.1  | Zahl wurde eingegeben und sie ist falsch. | Enter       |   Ihre eingegebene Zahl ist zu tief/hoch.             |
| 4.1  | Zahl wurde eingegeben und sie ist richtig.  | Enter        |  Sie haben die Zahl in 8 versuchen erraten.             |
| 5.1  | Siegesnachricht   |   -      |   Möchten sie nochmals spielen?                 |
| 6.1  | Siegesnachricht     |  Ja       |   Versuchen Sie die zufällige Zahl zu erraten.                 |
| 7.1  | Siegesnachricht     |  Nein     |   -               |
| 8.1  |  Eine Frage (z. B. Versuchen sie die zufällige Zahl zu erraten.)  |  Enter       |  Nur die neue Frage taucht auf.                |
| 9.1  |  Eine Frage (z. B. Versuchen sie die zufällige Zahl zu erraten.)  |   # Enter    |  Ihre Eingabe ist ungültig, geben sie eine Zahl ein.            |


### 1.4 Diagramme

<img width="934" alt="image" src="https://github.com/usernamen2334/LA.2_1300/assets/110892575/d0a118c7-127b-425e-8041-8d973fbcb7c0">

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |           |              |               |
| ...  |       |           |              |               |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden 

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.

