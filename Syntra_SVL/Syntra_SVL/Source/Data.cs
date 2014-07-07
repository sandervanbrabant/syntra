using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syntra_SVL.Source.Aanvragen;
using Syntra_SVL.Source.Personen;
using Syntra_SVL.Source.Contactgegevens;
using Syntra_SVL.Source.Bedrijven;
using Syntra_SVL.Source.Inschrijvingen;
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
                    AanvraagMetIssues a2 = new AanvraagMetIssues();
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
                    AanvraagWijziging a3 = new AanvraagWijziging();
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
                    AanvraagWijziging a5 = new AanvraagWijziging();
                    a5.is_ingetrokken = true;
                    return new string[3] {"{\"aanvragen\":" + JsonConvert.SerializeObject(a5) + "}",
                        "aanvragen/1?versie=2", "PUT"};
                case 5:
                    PersoonNew b1 = new PersoonNew();
                    Persoon b1p = new Persoon();
                    b1p.externe_referentie = "1000003";
                    b1p.rrn = "8525654";
                    b1p.familienaam = "Daiso";
                    b1p.voornaam = "Wim";
                    b1p.geboortedatum = "2000-02-02";
                    b1p.geboorteland = "BE";
                    b1p.geboorteplaats = "runkst";
                    b1p.geslacht = "M";
                    b1p.straatnaam = "bosstraat";
                    b1p.huisnummer = "15";
                    b1p.bus = "1";
                    b1p.postcode = "2850";
                    b1p.gemeente = "boom";
                    b1p.land = "BE";
                    b1p.nationaliteit = "BE";
                    b1p.thuistaal_id = "364";
                    b1p.thuistaal = "nederlands";
                    b1p.hoofdberoep = "bediende";
                    b1p.wil_zelfstandige_worden = "false";
                    b1p.behaalde_bedrijfsbeheer = "true";
                    b1p.beroepskennis = "boekhouder";
                    b1p.diploma_buitenland = "bussiness";
                    b1p.hoogste_opleidingsniveau_id = "144";
                    b1p.sociaal_status_id = "123";
                    b1p.sociaal_statuut = "A";
                    ContactZonderLink b1c1 = new ContactZonderLink();
                    b1c1.contact_type = "gsm";
                    b1c1.waarde = "0444/444444";
                    b1c1.externe_referentie = "12121";
                    ContactZonderLink b1c2 = new ContactZonderLink();
                    b1c2.contact_type = "email";
                    b1c2.waarde = "me@me.be";
                    b1c2.externe_referentie = "12121";
                    ContactAlsLink b1cl = new ContactAlsLink();
                    b1cl.contactgegevens = new ContactZonderLink[2] { b1c1, b1c2 };
                    b1.personen = new Persoon[1] { b1p };
                    b1.linked = b1cl;
                    return new string[3] { JsonConvert.SerializeObject(b1),
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
                    PersoonWijzig b3 = new PersoonWijzig();
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
                    BedrifNew c1 = new BedrifNew();
                    Bedrijf c1b = new Bedrijf();
                    c1b.externe_referentie = "23666";
                    c1b.ondernemersnummer = "BE013456789";
                    c1b.naam = "abc bvba";
                    c1b.straatnaam = "hier";
                    c1b.huisnummer = "1";
                    c1b.bus = "1";
                    c1b.postcode = "3000";
                    c1b.gemeente = "leuven";
                    c1b.land = "BE";
                    c1b.juridisch_statuut_id = "80";
                    c1b.bedrijfs_grootte_id = "73";
                    c1b.bedrijfs_sector = "idustrie";
                    c1b.bedrijfs_activiteit = "papier";
                    ContactZonderLink c1c1 = new ContactZonderLink();
                    c1c1.contact_type = "gsm";
                    c1c1.waarde = "0444/444444";
                    c1c1.externe_referentie = "12121";
                    ContactZonderLink c1c2 = new ContactZonderLink();
                    c1c2.contact_type = "email";
                    c1c2.waarde = "me@me.be";
                    c1c2.externe_referentie = "12121";
                    ContactAlsLink c1cl = new ContactAlsLink();
                    c1cl.contactgegevens = new ContactZonderLink[2] { c1c1, c1c2 };
                    c1.bedrijven = new Bedrijf[1] { c1b };
                    c1.linked = c1cl;
                    return new string[3]{JsonConvert.SerializeObject(c1),
                        "bedrijven/", "POST"};
                case 12:
                    BedrijfMetIssues c2 = new BedrijfMetIssues();
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
                    BedrijfAdres c3 = new BedrijfAdres();
                    c3.straatnaam = "veldstraat";
                    c3.huisnummer = "50";
                    return new string[3]{"{\"bedrijven\":[" + JsonConvert.SerializeObject(c3) + "]}",
                        "bedrijven/1", "PUT"};
                case 14:
                    return new string[3] { "", "bedrijven/1", "DELETE" };
                case 15:
                    ContactMetLink d1 = new ContactMetLink();
                    d1.externe_referentie = "123";
                    d1.contact_type = "gsm";
                    d1.waarde = "0444/444444";
                    Contactgegevens.Link d1l = new Contactgegevens.Link();
                    d1l.persoon = "17";
                    d1.links = d1l;
                    return new string[3] { "{\"contactgegevens\":[" + JsonConvert.SerializeObject(d1) + "]}",
                        "contactgegevens/", "POST" };
                case 16:
                    ContactZonderLink d2 = new ContactZonderLink();
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
                    Inschrijvingen.Link e1l = new Inschrijvingen.Link();
                    e1l.aanvraag = "123";
                    e1l.cursist = "1";
                    e1l.bedrijf = "20";
                    e1.links = e1l;
                    return new string[3]{"{\"inschrijvingen\":[" + JsonConvert.SerializeObject(e1) + "]}",
                        "inschrijvingen/", "POST"};
                case 19:
                    InschrijvingWijzig e2 = new InschrijvingWijzig();
                    e2.uitschrijvingsdatum = "2014-06-02";
                    return new string[3] {"{\"inschrijvingen\":[" + JsonConvert.SerializeObject(e2) + "]}",
                        "inschrijvingen/1", "PUT"};
                case 20:
                    return new string[3] {"", "inschrijvingen/1", "DELETE"};
            }
            return null;
        }
    }
}
