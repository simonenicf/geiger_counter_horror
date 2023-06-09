# Geiger_counter_horror_simulation
Project waar ik opzoek gegaan ben naar een game te maken met behulp van speciale input en output.

Hierin vertel ik mij onderzoek en hoe ik tot het eind resultaat ben gekomen.
## Wat is specaile input en output
Een specaile input en output is iets dat gehandicapte, developers, trainer of presentator kan gebruiken om met de computer te kunnen omgaan en te interacteren.
Denk hierbij aan refreshable braille displays zodat iemand die blind is de tekst kan lezen. Maar denk ook bijvoorbeeld aan een Digitizer aka teken tablet waardoor je makelijker kan tekenen op een computer. Hier onder heb ik een lijst van een aantal inputs en outputs:

| Inputs     | Outputs  |
|-----------|-----------|
|Camera (eye tracker)|Audio (speakers)|
|Vr headset + controllers|Licht(led lampjes, led strip)|
|Wii mote|Scherm(touch screen, led screen)|
|Arduino voor motion, extra knopen, geluid, enz.|Motoren(zie foto)|
|Microphone|vibraties|
|Controllers|Temperature(warmt,kou)|
|Telefoon|ventilatoren(lucht)|
|Sensoren (Position Sensors, Pressure Sensors,Temperature Sensors)|
|Digitizer (teken tablet)|
|Joy stick|

## Begin Process:
Ik ben vooral eerst gaan kijken naar projecten die specaile input en output hebben.
Ik ben tijdens dit onderzoek een aantal games tegen gekomen en projecten.

zoals:

[Grasping](https://duncan74.itch.io/grasping)
, [Cryptogram](http://shakethatbutton.com/cryptogram/)
, [une-partie-de-tarot](http://shakethatbutton.com/une-partie-de-tarot/)

And more projects at [shake that button](https://shakethatbutton.com/)
## ideeën:
Vanuit deze theorie en ideeën heb ik een aantal dingen bedacht en gekeken of het haalbaar:
+ Teken tablet gebruiken voor schrijven in led lichtjes.
+ Horror game maken met hulp van Arduino, geluid en andere visuele effecten.
+ Eye tracker op balletje die de lucht in geschoten wordt en moet volgen.
+ [Leap motion project verbeteren met Arduino en Led licht.](https://github.com/simonenicf/Tenacle_dot-experience)
## Keuze en waarom:
Ik heb uiteindelijk gekozen om te gaan voor de horror game met hulp van Arduino.
De groteste reden dat ik hiervoor heb gekozen is dat ik zeer geintereseerd ben in het werken met sensoren en met de Adruino software.
Want C/C++ is een codeer taal die ik super interesant vindt en verder in wil duiken.
De hoofd focus van het project zal de adruino, sensoren plus een output zijn.
## De theorie/project idee:
Het idee is om een horror game te maken met als hoofd onderdeel de Adruino. Ik wil een nep geiger counter maken die afgaat op een andere input dan radiatie.
Hiermee wil ik na maken hoe het is om met een geiger counter te werken zonder gevaar van radiatie. Dit gaat gecombineerd met een simulatie video/game die uitlegt hoe het te werk gaat en hoe je de geiger counter moet gebruiken. En als je in de buurt komt van een object die "radiatie" zou bevatten gaat het af en geeft het een output(bijv. geluid, licht).

Dit wil ik bereiken met een magnetic field sensor, Adruino NANO en een speaker/Ledstrip.
## Het process:


https://user-images.githubusercontent.com/70582804/228811880-5223f74e-5b87-417c-b7f5-924c0130c237.mp4


https://user-images.githubusercontent.com/70582804/231762241-e6b901dd-caec-4011-895c-1cf059d7afe1.mp4


## User Test

https://user-images.githubusercontent.com/70582804/231761894-31bb0409-26bc-4b81-b420-080227c00837.mp4


## user feedback:
De user feedback was dat:

Er meer visaule feedback mag zijn. want als je niet bekend bent met een sensor is het lastig te vinden.
De tekst verscheen te snel. De tekst mag wel wat langer over doen voor er weer nieuwe tekst verschijnt.
En het is handig dat er een uitleg is over wat een geiger counter is. Want als je er niks over weet is de ervaring anders.

## My stuff:
[Trello](https://trello.com/b/FqTdeQZD/geigercounterhorrorexp)


[My Website](https://michellefrankfort.wordpress.com/)
## tools used:
[Ardity](https://ardity.dwilches.com/)

[Arduino IDE](https://www.arduino.cc/en/software)
## Bronnen:
[specaile input en output](https://exploringmaintopicsofcomp214.weebly.com/index.html)
