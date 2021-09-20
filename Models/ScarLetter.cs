using System;
using System.Collections.Generic;

namespace ApiAppPetrol.Models
{
    public partial class ScarLetter
    {
        public int LetterId { get; set; }
        public string LetterChar { get; set; }
        public int StateId { get; set; }
        public bool? Active { get; set; }

        public virtual Nstate State { get; set; }
    }
}
