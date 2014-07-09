Syntra apiary tests

De github-repository is te vinden op de volgende url.
https://github.com/sandervanbrabant/syntra

De manuele cURL-test was ook succesvol (zie afbeelding 01).

De simpele GET-methode is ook getest in een browser, namelijk Google Chrome (afbeeling 02).

De curl https-oproep voor de dev-server (https://coosy-dev.syntravlaanderen.be/api/personen/1) gaf de uitkomst te zien in afbeelding 03.

Het programma loopt al tot en met Inschrijvingen.
Er zijn nu problemen met registreren van aanvraag/persoon/bedrijf met issues. Verder wordt er gebruik gemaakt van true/false waarden op 3 manieren (boolean, string als true/false en string als Y/N) en integers op 2 manieren (int en string). Ik raad aan om 1 manier aan te houden (dit is makkeijker om mee te werken en te testen). Vervolgens zou het ook beter zijn om bepaalde data als object te plaatsen wat meerdere malen wordt gebruikt, vb:

{"personen":
	{"naam":"Bert",
	"werk":"IT",
	"straatnaam":"straat",
	"huisnummer":"1"}}	naar
{"personen":
	{"naam":"Bert",
	"werk":"IT",
	"adres":{"straatnaam":"straat",
			"huisnummer":"1"}}}
De klasse adres (in dit geval) kan meerdere malen herbruikt worden en zorgt voor een betere overzichtelijkheid.

Identicatie en connectie met server is in orde, maar voor sommige requests is er nog een probleem:
404: (aantal 8/32)
Verwijder een persoon
Zoek een persoon op referentie
Verwijder een bedrijf
Wijzig een lesmoment
Registreer een jurylid
Wijzig een jurylid
Verwijder een jurylid
Zoek een module
500: (aantal 5/32)
Registreer een aanvraag 2
Wijzig aanvragen collection 2
Registreer een bedrijf
Registreer een lesmoment
Registreer een aanwezigheid
Dus 19 werken (geen 404) maar er zijn er die ik nog niet kan testen (geen registratie => niet wijzigen, verwijderen of oproepen).
