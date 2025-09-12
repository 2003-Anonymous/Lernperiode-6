# Lern-Periode 6

22.8 bis 19.9.2024

## Grob-Planung

Ich will ein Kampfspiel machen, in dem der Player gegen einen Gegner kämpft(Autobattle). Der Player hat verschiedene Klassen wie z.B. Archer oder Berserker.

## 22.8

- [ ] Arbeitspaket 1: Erstellen Sie ein Projekt im VS und beginnen Sie mir ersten Code-Skizzen. Das ist wichtig, Sie müssen heute bereits schon C#-Code hochladen!
- [ ] Arbeitspaket 2: Schreiben Sie eine Liste, welche Klassen und Objekte es braucht, und wie diese miteinander interagieren. Das Format ist Ihnen freigestellt, aber Sie müssen es auch bereits heute auf github laden. (Dieses AP dauert ausnahmsweise nur 15')
- [ ] Arbeitspaket 3 (Falls Sie den *maker space* besuchen, dann dürfen Sie diesen Punkt löschen. Ansonsten können Sie hier mit dem Coden beginnen, nachdem Sie sich ganz klar überlegt haben, was Ihr erster Schritt ist und den hier als AP festgehalten haben.)

Heute habe ich auf Papier einen groben Plan meiner Klassen aufgezeichnet. Danach habe ich schon einmal eine Ordnerstruktur in meinem Projekt erstellt, da ich vorhabe, dass Projekt noch stark zu erweitern und es soll übersichtlich bleiben.


## 29.8

- [ ] Die Klasse Player fertig erstellen.
- [x] Grobes Design zeichnen, damit ich weiss, was in welches Forms kommt
- [x] Einen Player auf dem Form2 erstellen können.

Heute habe ich eine Skitze des groben Designs erstellt, damit ich besser weiss, was in welches Forms kommt und wie die Klassen miteinander interagieren müssn. Dann habe ich die Klasse Archer noch erweitert. Ich habe eine Klasse StatsControl erstellt, mit der die Stats einer erstellten Instanz z.B. der Klasse Archer angezeigt werden. Rechts neben dem Bild der Instanz steht der Name z.B. Damage und daneben ist eine Progressbar, welche den Wert in Relation zum höchsten Wert darstellt. Am Schluss habe ich noch eine Klasse Enemy erstellt und der schon ein paar Basisatribute gegeben, damit ich nächstes mal das Kampfsystem erstellen kann.
<img width="2661" height="3547" alt="image" src="https://github.com/user-attachments/assets/a485026b-5761-4d1e-8d1c-3f820c1b0085" />

## 05.09

- [x] Das Kampfsystem aufzeichnen. Also wie der zugefügte Schaden von den Leben des Gegners abgezogen werden.
- [x] Eine Attack-Methode erstellen
- [x] Eine GetDamage-Methode erstelllen
- [ ] Testen, ob diese Methoden richtig funktionieren und optimal sind

Heute habe ich das Kampsystem programmiert und zwar mit einer Fight-Methode im Forms2 gemacht. Diese ruft jeweils die Attack-Methoden des Players und des Enemys auf. In diesen Methoden wird ein Timer erstellt, der basierend auf dem Attackspeed eine Methode aufruft, welche dem Gegner Schaden durch die getDamage-Methode zugefügt wird. Dann habe ich noch eine abstrakte Klasse Typ erstellt, welche der Grundbauplan für die verschiedenen Klassen des Players darstellt. So ist es übersichtlicher und ich muss nicht bei jedem neuen Typ alle Werte deklarieren. Ich habe durch einen Getter und einen Setter noch hinzugefügt, dass die Leben nicht unter null oder über das Maximum gehen können. Das kämpfen funktionert aber noch nicht. Die Lebensbalken bleiben unverändert, wenn man den Kamp startet. Dieses Problem konnte ich nicht mehr lösen.


![thumbnail_pro-spWKMOOW](https://github.com/user-attachments/assets/5eef19be-6e84-4948-aa92-ef5fe806beca)

## 12.09

- [x] Herausfinden, warum das Kampfsystem nicht funktioniert.
- [ ] Einen weiteren Typen für den Player erstellen.
- [x] Hinzufügen, dass wenn man einen Player erstellt, aussuchen kann, welchen Typen man haben möchte.
- [ ] Waffen programmieren, welche man auch beim erstellen auswählen kann.

Heute habe ich das Kampsystem fertig gestellt. Es hat nicht funktioniert, weil ich neben den Leben in den Stats noch eine zweite Healthbar erstellt habe, von der Leben abgezogen wurden. Das konnte ich aber schnell beheben. Danach hatte ich ein weiteres Problem, und zwar hat der Gegner weiter angegriffen, obwohl er tot war. Um das zu lösen, habe ich mit einem If gecheckt, ob er noch lebt. Wenn nicht, wird der Attacktimer gestoppt. Als nächstes habe ich ein weiteres Forms erstellt, welches sich öffnet, wenn man den Createbutton clickt. Dort werden dann Buttons für jeden Playertypen  generiert, welche in einem String gespeichert sind. Dieser Typ wird im Tag des Buttons gespeichert und so wird ein Objekt des Types, welchen man anklickt, instanziert. Im Moment wird das Objekt aber noch diesem neuen Form hinzugefügt und nicht dem Form2. Um das zu lösen hat die Zeit nicht mehr gerreicht und für die Waffen auch nicht mehr. Ich habe länger als gedacht für das Kampfsystem gebraucht, konnte aber vorallem custom Getter und Setter gut üben. Den weiteren Typen habe ich weggelassen, weil das dann eher eine Ereweiterung ist für die Zukunft.


## 19.09

- [ ] Ändern, dass der erstellte Player dem Form2 hinzugefügt wird.
- [ ] Code herausputzen (Variablennamen)
- [ ] Programmieren, dass man die Attribute des Players auch auf dem TypeSelect-Form eingeben kann.



