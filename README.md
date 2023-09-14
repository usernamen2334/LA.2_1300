# LA.2_1300

# Projekt-Dokumentation

Erik Marku

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 18.08.2023 | 0.0.1   | Ich habe mich wieder in C# eingelebt und habe mir eine grobe Vorstellung von meinem Projekt verschafft und konnte somit mein Projekt planen. |
| 25.08.2023 | 0.0.2   | Ich habe angefangen, an meinem Projekt zu programmieren.                                                             |
| 01.09.2023 | 0.0.3   | Ich habe das Realisieren fortgesetzt und habe mein Programm fast vollendet.                                                            |
| 08.09.2023 | 1.0.0   | Ich habe die letzten Änderungen an meinem Programm vorgenommen und habe die Projektdoku fertiggestellt.                                                             |
## 1 Informieren

### 1.1 Ihr Projekt

In diesem Projekt werde ich einen coolen Numberguesser Spiel programmieren.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1  |   Muss              | Funktional     | Als ein User möchte ich die Möglichkeit erhalten, die Zufällig generierte Zahl zu erraten. |
| 2  |  Muss               | Funktional     | Als ein User möchte ich informiert werden, ob meine Zahl richtig oder falsch ist           |
| 3  |  Muss               | Funktional     | Als ein User möchte ich informiert werden, ob die zufällig generierte Zahl höher oder tiefer als meine geratene Zahl ist.        |
| 4  |  Muss               | Funktional     | Als ein User möchte ich eine Siegesnachricht erhalten, auf der ich sehen kann, wie viel Ratte versuche, ich gebraucht habe, sobald ich die Zahl erraten habe.  |
| 5  |  Muss               | Funktional     | Als ein User möchte ich, sobald ich die Zahl erraten habe, eine Chance bekommen nochmals zu spielen oder auch nicht.       |
| 6  |  Muss               | Funktional     | Als ein User möchte ich, dass falls ich mich entscheide nochmals zu spielen, eine neue Zahl generiert wird.       |
| 7  |  Muss               | Funktional     | Als ein User möchte ich, dass falls ich mich entscheide nicht nochmals zu spielen, das sich das Programm asbchliesst.     |
| 8  |  Muss               | Funktional     | Als ein User möchte ich, dass nach jedem Commit, den ich abgebe, die vorherigen Zeilen sich automatisch löschen.               |
| 9  |  Muss               | Funktional     | Als ein User möchte ich, dass das Spiel mit Fehleingabe (wie Z. B. ein #, ! Usw. Eingebe) umgehen kann.                                  |


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Programm ist offen.                                               | F5 (um Programm zu starten)  |  Versuchen sie die zufällige Zahl zu erraten.        |
| 2.1  | Zahl wurde eingegeben.                                            | Enter                        |   Ihre Zahl ist falsch/richtig.                      |
| 3.1  | Zahl wurde eingegeben und sie ist falsch.                         | Enter                        |   Ihre eingegebene Zahl ist zu tief/hoch.            |
| 4.1  | Zahl wurde eingegeben und sie ist richtig.                        | Enter                        |  Sie haben die Zahl in 8 versuchen erraten.          |
| 5.1  | Siegesnachricht                                                   |   -                          |   Möchten sie nochmals spielen?                      |
| 6.1  | Siegesnachricht                                                   |  Ja                          |   Versuchen Sie die zufällige Zahl zu erraten.       |
| 7.1  | Siegesnachricht                                                   |  Nein                        |   -                                                  |
| 8.1  |  Eine Frage (z. B. Versuchen sie die zufällige Zahl zu erraten.)  |  Enter                       |  Nur die neue Frage taucht auf.                      |
| 9.1  |  Eine Frage (z. B. Versuchen sie die zufällige Zahl zu erraten.)  |   # Enter                    |  Ihre Eingabe ist ungültig, geben sie eine Zahl ein. |


### 1.4 Diagramme 

<img width="693" alt="image" src="https://github.com/usernamen2334/LA.2_1300/assets/110892575/166b13e2-cb80-4ee9-90e9-5af9996b161c">



## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  | 25.08.2023 |  Marku    |  Das Programm generiert eine Zahl 1-100.  |    45'  |
| 1.B  | 25.08.2023 |  Marku    |  Das Programm gibt dem Benutzer die Möglichkeit, eine Zahl einzugeben.   |   45'  |
| 2.A  | 25.08.2023 |  Marku    |  Das Programm prüft, ob die Eingabe vom Benutzer richtig/falsch ist.           |   45'   |
| 3.A  | 01.09.2023 |  Marku    |  Das Programm prüft, ob die Zufallszahl höher oder teifer als die eingegebene Zahl ist und gibt dies dem Benutzer auch aus.   |   45'     |
| 4.A  | 01.09.2023 |  Marku    |  Das Programm prüft, wie viele Versuche der Benutzer gebraucht hat und gibt dies in der Siegesnachricht aus.            |   45'     |
| 5.A  | 01.09.2023 |  Marku    |  Das Programm fragt den Benutzer, ob er nochmals spielen möchte.           |   45'     |
| 6.A  | 01.09.2023 |  Marku    |  Das Programm generiert eine neue Zahl, wenn der Benutzer nochmals spielen möchte.            |   45'     |
| 7.A  | 08.09.2023 |  Marku    |  Das Programm wird abgeschlossen, wenn der Benutzer sich entschieden hat, nicht mehr zu spielen.             |   45'     |
| 8.A  | 08.09.2023 |  Marku    |  Das Programm löscht die alten Ausgaben nach jeder Eingabe vom Benutzer.     |   45'     |
| 9.A  | 08.09.2023 |  Marku    |  Das Programm sagt dem Benutzer, dass er eine ungültige Eingabe eingegeben hat und stürzt dabei nicht ab.             |   45'     |

Total: 9A = 9* 45' = 405 ' 

## 3 Entscheiden 

Ich habe keine spezielle Entscheidung getroffen. Ich möchte mich einfach in die Welt des objektorientierten Programmierens einarbeiten und frei damit beginnen zu arbeiten.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 25.08.2023 |  Marku  |   45'   |    10'               |
| 1.B  | 25.08.2023 |  Marku  |   45'   |    10'              |
| 2.A  | 25.08.2023 |  Marku  |   45'   |    80'               |
| 3.A  | 01.09.2023 |  Marku  |   45'   |    60'              |
| 4.A  | 01.09.2023 |  Marku  |   45'   |    90'               |
| 5.A  | 01.09.2023 |  Marku  |   45'   |    40'               |
| 6.A  | 01.09.2023 |  Marku  |   45'   |    30'               |
| 7.A  | 08.09.2023 |  Marku  |   45'   |    45'               |
| 8.A  | 08.09.2023 |  Marku  |   45'   |    45'               |
| 9.A  | 08.09.2023 |  Marku  |   45'   |    45'              |


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

