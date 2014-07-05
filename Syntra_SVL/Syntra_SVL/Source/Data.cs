using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syntra_SVL.Source.Aanvragen;
using Syntra_SVL.Source.Personen;
using Syntra_SVL.Source.Contactgegevens;
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
            }
            return null;
        }
    }
}
