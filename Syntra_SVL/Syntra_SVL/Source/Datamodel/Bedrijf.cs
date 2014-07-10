﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntra_SVL.Source.Datamodel
{
    class Bedrijf
    {
        public Bedrijf()
        {
        }

        public string externe_referentie { get; set; }
        public string ondernemersnummer { get; set; }
        public string naam { get; set; }
        public string straatnaam { get; set; }
        public string huisnummer { get; set; }
        public string bus { get; set; }
        public string postcode { get; set; }
        public string gemeente { get; set; }
        public string land { get; set; }
        public string juridisch_statuut_id { get; set; }
        public string bedrijfs_grootte_id { get; set; }
        public string bedrijfs_sector { get; set; }
        public string bedrijfs_activiteit { get; set; }

        public string getJson()
        {
            string sJson = "{";
            sJson += setJson(externe_referentie, "externe_referentie");
            sJson += setJson(ondernemersnummer, "ondernemersnummer");
            sJson += setJson(naam, "naam");
            sJson += setJson(straatnaam, "straatnaam");
            sJson += setJson(huisnummer, "huisnummer");
            sJson += setJson(bus, "bus");
            sJson += setJson(postcode, "postcode");
            sJson += setJson(gemeente, "gemeente");
            sJson += setJson(land, "land");
            sJson += setJson(juridisch_statuut_id, "juridisch_statuut_id");
            sJson += setJson(bedrijfs_grootte_id, "bedrijfs_grootte_id");
            sJson += setJson(bedrijfs_sector, "bedrijfs_sector");
            sJson += setJson(bedrijfs_activiteit, "bedrijfs_activiteit");
            if (sJson.Length == 1)
            {
                return "{}";
            }
            else
            {
                return sJson.Substring(0, sJson.Length - 1) + "}";
            }
        }

        private string setJson(string atribute, string atributeName)
        {
            if (atribute != null)
            {
                return "\"" + atributeName + "\":\"" + atribute + "\",";
            }
            else
            {
                return "";
            }
        }
    }
}