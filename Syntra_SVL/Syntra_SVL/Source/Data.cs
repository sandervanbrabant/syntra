using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syntra_SVL.Source.Datamodel;
using Newtonsoft.Json;

namespace Syntra_SVL.Source
{
    class Data
    {
        public Data()
        {
        }

        public string[] getData(int iItem)
        {
            switch (iItem)
            {
                case 0:
                    Aanvraag a1 = new Aanvraag();
                    a1.externe_referentie = "2013/2014|45654";
                    a1.start_datum = "2012-02-02";
                    a1.cursus_jaar = "2013/2014";
                    a1.cursus_verantwoordelijke = "Geert";
                    a1.is_ingetrokken = false;
                    a1.extra_kenmerk_id = 363;
                    a1.doelgroepen_beleid_id = 545;
                    a1.locatie = "thuis";
                    a1.commentaar = "fun";
                    a1.lesplaats_code = "52";
                    a1.module_versie_referentie = "54236";
                    a1.is_praktijksplitsing = true;
                    return new string[3] {"{\"payload\":" + JsonConvert.SerializeObject(a1) + "}",
                        "aanvragen/", "POST"};
                case 1:
                    Aanvraag a2 = new Aanvraag();
                    a2.externe_referentie = "654321";
                    a2.cursus_jaar = "2013/2014";
                    a2.cursus_verantwoordelijke = "Geert";
                    a2.is_ingetrokken = false;
                    a2.extra_kenmerk_id = 363;
                    a2.doelgroepen_beleid_id = 545;
                    a2.locatie = "thuis";
                    a2.commentaar = "fun";
                    a2.lesplaats_code = "52";
                    a2.module_versie_referentie = "54236";
                    a2.is_praktijksplitsing = true;
                    return new string[3] {"{\"payload\":" + JsonConvert.SerializeObject(a2) + "}",
                        "aanvragen/?correct=false", "POST"};
                case 2:
                    Aanvraag a3 = new Aanvraag();
                    a3.is_ingetrokken = true;
                    return new string[3] {"{\"payload\":" + JsonConvert.SerializeObject(a3) + "}",
                        "aanvragen/1", "PUT"};
                case 3:
                    Aanvraag a4 = new Aanvraag();
                    a4.externe_referentie = "2013/2014|45654";
                    a4.start_datum = "2012-02-02";
                    a4.cursus_jaar = "2013/2014";
                    a4.cursus_verantwoordelijke = "Geert";
                    a4.is_ingetrokken = false;
                    a4.extra_kenmerk_id = 363;
                    a4.doelgroepen_beleid_id = 545;
                    a4.locatie = "thuis";
                    a4.commentaar = "fun";
                    a4.lesplaats_code = "52";
                    a4.module_versie_referentie = "54236";
                    a4.is_praktijksplitsing = true;
                    return new string[3] {"{\"aanvragen\":" + JsonConvert.SerializeObject(a4) + "}",
                        "aanvragen/?versie=2", "POST"};
                case 4:
                    Aanvraag a5 = new Aanvraag();
                    a5.is_ingetrokken = true;
                    return new string[3] {"{\"aanvragen\":" + JsonConvert.SerializeObject(a5) + "}",
                        "aanvragen/1?versie=2", "PUT"};
                case 5:
                    Persoon b1 = new Persoon();
                    b1.externe_referentie = "1000003";
                    b1.rrn = "8525654";
                    b1.familienaam = "Daiso";
                    b1.voornaam = "Wim";
                    b1.geboortedatum = "2000-02-02";
                    b1.geboorteland = "BE";
                    b1.geboorteplaats = "runkst";
                    b1.geslacht = "M";
                    b1.straatnaam = "bosstraat";
                    b1.huisnummer = "15";
                    b1.bus = "1";
                    b1.postcode = "2850";
                    b1.gemeente = "boom";
                    b1.land = "BE";
                    b1.nationaliteit = "BE";
                    b1.thuistaal_id = "364";
                    b1.thuistaal = "nederlands";
                    b1.hoofdberoep = "bediende";
                    b1.wil_zelfstandige_worden = "false";
                    b1.behaalde_bedrijfsbeheer = "true";
                    b1.beroepskennis = "boekhouder";
                    b1.diploma_buitenland = "bussiness";
                    b1.hoogste_opleidingsniveau_id = "144";
                    b1.sociaal_status_id = "123";
                    b1.sociaal_statuut = "A";
                    Contact b1c1 = new Contact();
                    b1c1.contact_type = "gsm";
                    b1c1.waarde = "0444/444444";
                    b1c1.externe_referentie = "12121";
                    Contact b1c2 = new Contact();
                    b1c2.contact_type = "email";
                    b1c2.waarde = "me@me.be";
                    b1c2.externe_referentie = "12121";
                    return new string[3] { "{\"personen\":[" + JsonConvert.SerializeObject(b1) +
                        "],\"linked\":{\"contactgegevens\":" + JsonConvert.SerializeObject(new Contact[2]{b1c1, b1c2}) + "}}",
                        "personen/", "POST"};
                case 6:
                    Persoon b2p = new Persoon();
                    b2p.externe_referentie = "1000003";
                    b2p.rrn = "8525654";
                    b2p.familienaam = "Daiso";
                    b2p.voornaam = "Wim";
                    b2p.geboortedatum = "2000-02-02";
                    b2p.geboorteland = "BE";
                    b2p.geboorteplaats = "runkst";
                    b2p.geslacht = "M";
                    b2p.straatnaam = "bosstraat";
                    b2p.huisnummer = "15";
                    b2p.bus = "1";
                    b2p.postcode = "2850";
                    b2p.gemeente = "boom";
                    b2p.land = "BE";
                    b2p.nationaliteit = "BE";
                    b2p.thuistaal_id = "364";
                    b2p.thuistaal = "nederlands";
                    b2p.hoofdberoep = "bediende";
                    b2p.wil_zelfstandige_worden = "N";
                    b2p.behaalde_bedrijfsbeheer = "N";
                    b2p.beroepskennis = "";
                    b2p.diploma_buitenland = "";
                    b2p.hoogste_opleidingsniveau_id = "144";
                    b2p.sociaal_status_id = "";
                    b2p.sociaal_statuut = "";
                    return new string[3] { "{\"personen\":[" + JsonConvert.SerializeObject(new Persoon[1] {b2p}) + "]}",
                        "personen/?correct=false", "POST"};
                case 7:
                    Persoon b3 = new Persoon();
                    b3.straatnaam = "veldstraat";
                    b3.huisnummer = "1";
                    b3.postcode = "3500";
                    b3.gemeente = "hasselt";
                    return new string[3] { "{\"personen\":" + JsonConvert.SerializeObject(b3) + "}",
                        "personen/1", "PUT"};
                case 8:
                    return new string[3] { "", "personen/1", "GET"};
                case 9:
                    return new string[3] { "", "personen/1", "DELETE"};
                case 10:
                    return new string[3] { "",   "personen/zoek?externe_referentie=4|12345", "GET"};
                case 11:
                    Bedrijf c1 = new Bedrijf();
                    c1.externe_referentie = "23666";
                    c1.ondernemersnummer = "BE013456789";
                    c1.naam = "abc bvba";
                    c1.straatnaam = "hier";
                    c1.huisnummer = "1";
                    c1.bus = "1";
                    c1.postcode = "3000";
                    c1.gemeente = "leuven";
                    c1.land = "BE";
                    c1.juridisch_statuut_id = "80";
                    c1.bedrijfs_grootte_id = "73";
                    c1.bedrijfs_sector = "idustrie";
                    c1.bedrijfs_activiteit = "papier";
                    Contact c1c1 = new Contact();
                    c1c1.contact_type = "gsm";
                    c1c1.waarde = "0444/444444";
                    c1c1.externe_referentie = "12121";
                    Contact c1c2 = new Contact();
                    c1c2.contact_type = "email";
                    c1c2.waarde = "me@me.be";
                    c1c2.externe_referentie = "12121";
                    return new string[3]{"{\"bedrijven\":[" + JsonConvert.SerializeObject(c1) +
                        "],\"linked\":{\"contactgegevens\":" + JsonConvert.SerializeObject(new Contact[2]{c1c1, c1c2}) + "}}",
                        "bedrijven/", "POST"};
                case 12:
                    Bedrijf c2 = new Bedrijf();
                    c2.externe_referentie = "23666";
                    c2.ondernemersnummer = "BE013456789";
                    c2.straatnaam = "hier";
                    c2.huisnummer = "1";
                    c2.bus = "1";
                    c2.postcode = "3000";
                    c2.gemeente = "leuven";
                    c2.land = "BE";
                    c2.juridisch_statuut_id = "80";
                    c2.bedrijfs_grootte_id = "73";
                    c2.bedrijfs_sector = "idustrie";
                    c2.bedrijfs_activiteit = "papier";
                    return new string[3]{ "{\"bedrijven\":[" + JsonConvert.SerializeObject(c2) + "]}",
                        "bedrijven/?correct=false", "POST"};
                case 13:
                    Bedrijf c3 = new Bedrijf();
                    c3.straatnaam = "veldstraat";
                    c3.huisnummer = "50";
                    return new string[3]{"{\"bedrijven\":[" + JsonConvert.SerializeObject(c3) + "]}",
                        "bedrijven/1", "PUT"};
                case 14:
                    return new string[3] { "", "bedrijven/1", "DELETE" };
                case 15:
                    Contact d1 = new Contact();
                    d1.externe_referentie = "123";
                    d1.contact_type = "gsm";
                    d1.waarde = "0444/444444";
                    d1.links = new Link();
                    d1.links.persoon = "17";
                    return new string[3] { "{\"contactgegevens\":[" + JsonConvert.SerializeObject(d1) + "]}",
                        "contactgegevens/", "POST" };
                case 16:
                    Contact d2 = new Contact();
                    d2.externe_referentie = "123";
                    d2.contact_type = "gsm";
                    d2.waarde = "0444/444444";
                    return new string[3] { "{\"contactgegevens\":[" + JsonConvert.SerializeObject(d2) + "]}",
                        "contactgegevens/1", "PUT" };
                case 17:
                    return new string[3] { "", "contactgegevens/1", "DELETE" };
                case 18:
                    Inschrijving e1 = new Inschrijving();
                    e1.externe_referentie = "2014/2015|5000|10000";
                    e1.inschrijvingsdatum = "2014-06-02";
                    e1.uitschrijvingsdatum = "215-06-03";
                    e1.stage_overeenkomst = "false";
                    e1.leersecretaris_code = "011";
                    e1.contract_nummer = "123";
                    e1.opleiding_in_eigen_naam = "false";
                    e1.betaald_met_opleidingscheques = "false";
                    e1.educatief_verlof = "false";
                    e1.motivatie_bijberoep = "kok";
                    e1.request_hash = "hfjslvsh";
                    e1.identity_hash = "ljdgsmfhgfj";
                    e1.links = new Link();
                    e1.links.aanvraag = "123";
                    e1.links.cursist = "1";
                    e1.links.bedrijf = "20";
                    return new string[3]{"{\"inschrijvingen\":[" + JsonConvert.SerializeObject(e1) + "]}",
                        "inschrijvingen/", "POST"};
                case 19:
                    Inschrijving e2 = new Inschrijving();
                    e2.uitschrijvingsdatum = "2014-06-02";
                    return new string[3] {"{\"inschrijvingen\":[" + JsonConvert.SerializeObject(e2) + "]}",
                        "inschrijvingen/1", "PUT"};
                case 20:
                    return new string[3] {"", "inschrijvingen/1", "DELETE"};
                case 21:
                    Lesmoment f1 = new Lesmoment();
                    f1.links = new Link();
                    f1.links.aanvraag = "6498";
                    f1.links.module_vak = "1202";
                    f1.externe_referentie = "2013/2014|5555|2014-09-01|14:30";
                    f1.lesdag = "2014-09-01";
                    f1.startuur = "14:30";
                    f1.er_is_een_examen = "false";
                    f1.aantal_uren_lesmoment = "6";
                    f1.vak_omschrijving = "engels";
                    f1.lokaal = "A1";
                    f1.onderwerp = "vocabulary";
                    Prestatie f1p = new Prestatie();
                    f1p.externe_referentie_lesgever = "12";
                    f1p.werknemersnummer_lesgever = "500";
                    f1p.dimona_contract = "12";
                    f1p.aantal_uren_prestatie = "4";
                    f1p.externe_referentie = "2013/2014|5555|2014-09-01|14:30|12";
                    Jurylid f1j = new Jurylid();
                    f1j.voornaam = "Jan";
                    f1j.familienaam = "Bos";
                    f1j.externe_referentie = "2014|A12345|Jan|Bos";
                    LesmomentLink f1link = new LesmomentLink();
                    f1link.prestaties = new Prestatie[1] { f1p };
                    f1link.juryleden = new Jurylid[1] { f1j };
                    return new string[3]{"{\"lesmomenten\":[" + JsonConvert.SerializeObject(f1) + "],\"linked\":" +
                        JsonConvert.SerializeObject(f1link) + "}", "lesmomenten/", "POST"};
                case 22:
                    Lesmoment f2 = new Lesmoment();
                    f2.aantal_lesuren = "2";
                    return new string[3]{"{\"lesmomente,\":[" + JsonConvert.SerializeObject(f2) + "]}",
                        "lesmomenten/1", "PUT"};
                case 23:
                    Prestatie g1 = new Prestatie();
                    g1.externe_referentie_lesgever = "12";
                    g1.werknemersnummer_lesgever = "500";
                    g1.dimona_contract = "122";
                    g1.aantal_uren_prestatie = "4";
                    g1.externe_referentie = "2013/2014|5555|2014-09-01|14:30|12";
                    g1.links = new Link();
                    g1.links.lesmoment = "3444";
                    return new string[3]{"{\"prestaties\":[" + JsonConvert.SerializeObject(g1) + "]}",
                        "prestaties/", "POST"};
                case 24:
                    Prestatie g2 = new Prestatie();
                    g2.aantal_lesuren = "8";
                    return new string[3]{"{\"prestaties\":[" + JsonConvert.SerializeObject(g2) + "]}",
                        "prestaties/1", "PUT"};
                case 25:
                    return new string[3] { "", "prestaties/1", "DELETE" };
                case 26:
                    Jurylid h1 = new Jurylid();
                    h1.voornaam = "Donald";
                    h1.familienaam = "Duck";
                    h1.externe_referentie = "2014|A12345|12";
                    h1.links = new Link();
                    h1.links.lesmoment = "3444";
                    return new string[3]{"{\"juryleden\":[" + JsonConvert.SerializeObject(h1) + "]}",
                        "juryleden/", "POST"};
                case 27:
                    Jurylid h2 = new Jurylid();
                    h2.voornaam = "Mickey";
                    h2.familienaam = "Mouse";
                    return new string[3]{"{\"juryleden\":[" + JsonConvert.SerializeObject(h2) + "]}",
                        "juryleden/1", "PUT"};
                case 28:
                    return new string[3] { "", "juryleden/1", "DELETE" };
                case 29:
                    Aanwezigheden i1 = new Aanwezigheden();
                    i1.externe_referentie = "2013/2014|5555|2014-09-01|14:30|100003";
                    i1.aanwezigheids_code = "A";
                    i1.links = new Link();
                    i1.links.lesmoment = "3444";
                    i1.links.persoon = "1";
                    return new string[3]{"{\"aanwezigheden\":[" + JsonConvert.SerializeObject(i1) + "]}",
                        "aanwezigheden/", "POST"};
                case 30:
                    Aanwezigheden i2 = new Aanwezigheden();
                    i2.aanwezigheids_code = "X";
                    return new string[3]{"{\"aanwezigheden\":[" + JsonConvert.SerializeObject(i2) + "]}",
                        "aanwezigheden/1", "PUT"};
                case 31:
                    return new string[3]{"", "aanwezigheden/1", "DELETE"};
                case 32:
                    return new string[3] { "", "module_versies/zoek?nummer=1074201&versie=0", "GET" };
            }
            return null;
        }
    }
}