using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCollectionView {
    internal class Country {
#pragma warning disable CS8618
        public string CountryName { get; set; }
        public string IsoCode { get; set; }
        public string FlagUrl { get; set; }
#pragma warning restore CS8618
    }
}