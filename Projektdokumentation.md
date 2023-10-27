# LA_1301_Projekt

Lorenzo Lai, Dorian Herzig, Cyrill Lutziger, Marek von Rogall

| Datum | Version | Zusammenfassung |
| ---- | --------------- | ---- |
| 15.09.2023 | 0.0.1   | Heute haben wir angefangen, an die Nutzwertanalyse zu programmieren, jedoch haben wir uns zuerst informiert, wie eine Nutzwertanalyse genau funktioniert und haben nochmals Windows Forms repetiert. |
| 22.09.2023 | 0.0.2   | Heute haben wir tatsächlich mit dem programmieren angefangen und konnten schon ein paar Features einbauen. (z.B. Eingabe und Ausgabe + GUI)  |
| 29.09.2023 | 0.0.3   | An diesem Tag konnten wir nicht so viel erledigen, da wir ein paar Knackpunkte getroffen haben. Wir konnten jedoch die GUI verbessern.) |   
| 27.10.2023 | 0.1.0   | Wir konnten Heute den grössten Teil der Knackpunkte erledigen und ein paar Randfeatures implementieren. Das Programm scheint reibungslos zu funktionieren. |
| 3.10.2023  | 1.0.0   | Wir haben das Projekt abgeschlossen. |

## 1 Informieren

### 1.1 Ihr Projekt

Wir haben auf c# / WinForms eine Nutzwertanalyse kreiert.

In diesem Projekt wollten wir eine Nutzwertanalyse erstellen, welche verschiedene Entscheidungen zusammen führt und vergleicht. Wir haben uns für WinForms entschieden, da man eine einfache und "simple" GUI erstellen kann. Dieses Projekt sollte als hilfe für Personen oder Unternehmen sein, welche verschiedene Optionen oder Entscheidungen treffen wollen, um das betse resultat zu erzielen.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |  Muss               |  Funktional    | Als User möchte ich, verschiedene Optionen hinzufügen können, damit ich meine verschiedene Optionen vergleichen kann. |
| 2    |  Muss               |  Funktional    | Als User möchte ich, verschiedene Kriterien hinzufügen können, damit ich sie danach bewerten und gewichten kann. |
| 3    |  Muss               |  Funktional    | Als User möchte ich, verschiedene Gewichtungen zu den Kriterien geben, um so wichtige Kriterien hervorzuheben. |
| 4    |  Muss               |  Funktional    | Als User möchte ich, dass das Programm die verschiedene Optionen und Kriterien, so wie die Gewichtung berücksichtigt und mir eine korrekte Berechnung zurückgibt. |
| 5    |  Muss               |  Funktional    |  Als User möchte ich, die Optionen selber bewerten, um die beste Analyse zu erreichen.                                 |
| 6    |  Können             |  Qualität      |  Als User möchte ich, ein schönes und simples GUI verwenden können. |
| 7    |  Können             |  Qualität      |  Als User möchte ich, dass die gewichtung nicht mehr verändert werden kann, nachdem man sie festgelegt hat. |

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | GUI: Objekte hinzufügen: |    Lidl    |         -          |
| 1.2  | GUI: "Lidl"             |    "man drückt auf Hinzufügen"     |         "Lidl erscheint rechts im Fenster"          |
| 2/3.1  | GUI: Kriterien hinzufügen:   |    Preis     |         -          |
| 2/3.2  | GUI: "Gewichtung"            |    3     |        -           |
| 2/3.3  | GUI: "Preis und 3"             |   "man drückt auf Hinzufügen"      |         "Preis (3) erscheint rechts im Fenster"           |
| 4.1  |      "2. Fenster mit Tabelle"        |    "man drückt auf Auswerten"     |         "Kriterien und gewichtung werden berechnet und entschtet ein Punktzahlreihe." |
| 5.1  |      "2. Fenster mit Tabelle"        |    3 "bei Kriterium Preis und Objekt/Option Lidl, wird 3 geschrieben"     |         -          |
| 6.1  |      -       |    -     |         -          |
| 7.1  |      "2. Fenster mit Tabelle"       |    "versucht Gewichtung zu ändern"     |        -        |

### 1.4 Diagramme

✍️Fügen Sie hier ein Use Case-Diagramm mit mindestens 10 Anwendungsfällen ein; und einen PAP.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |           |              |               |
| 1.B  |       |           |              |               |
| 1.A  |       |           |              |               |
| 1.A  |       |           |              |               |
| 1.A  |       |           |              |               |
| 1.A  |       |           |              |               |
| 1.A  |       |           |              |               |
| 1.A  |       |           |              |               |
| 1.A  |       |           |              |               |
| 1.A  |       |           |              |               |
| 1.A  |       |           |              |               |
| 1.A  |       |           |              |               |
| 1.A  |       |           |              |               |
| 1.A  |       |           |              |               |

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
