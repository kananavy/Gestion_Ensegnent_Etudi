using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Ensegnent_et_Etudient.Models
{
    public class Devoir
    {
        public int Id { get; set; }
        public int CoursId { get; set; }
        public string Titre { get; set; }
        public DateTime DateSoumission { get; set; }
    }

}
