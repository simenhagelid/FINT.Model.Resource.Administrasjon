// Built from tag v3.0.0-rc-1

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Felles.Basisklasser;

namespace FINT.Model.Administrasjon.Organisasjon
{

	public class OrganisasjonselementResource : EnhetResource 
	{

        
		public Periode Gyldighetsperiode { get; set; }
		public string Kortnavn { get; set; }
		public string Navn { get; set; }
		public Identifikator OrganisasjonsId { get; set; }
		public Identifikator OrganisasjonsKode { get; set; }
		
        
        public OrganisasjonselementResource()
        {
            Links = new Dictionary<string, List<Link>>();
        }

        [JsonProperty(PropertyName = "_links")]
        public new Dictionary<string, List<Link>> Links { get; private set; }
        
        private void AddLink(string key, Link link)
        {
            if (!Links.ContainsKey(key))
            {
                Links.Add(key, new List<Link>());
            }
            Links[key].Add(link);
        }
            

        public void AddAnsvar(Link link)
        {
            AddLink("ansvar", link);
        }

        public void AddLeder(Link link)
        {
            AddLink("leder", link);
        }

        public void AddOverordnet(Link link)
        {
            AddLink("overordnet", link);
        }

        public void AddUnderordnet(Link link)
        {
            AddLink("underordnet", link);
        }

        public void AddSkole(Link link)
        {
            AddLink("skole", link);
        }

        public void AddArbeidsforhold(Link link)
        {
            AddLink("arbeidsforhold", link);
        }
    }
}
