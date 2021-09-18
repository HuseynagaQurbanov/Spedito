using SpeditoReposity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spedito.Models
{
    public class OptionsViewModel
    {
        public OptionsType Type { get; set; }
        public string Title { get; set; }
        public List<OptionItemViewModel> OptionItems { get; set; }
    }

    public class OptionItemViewModel
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
