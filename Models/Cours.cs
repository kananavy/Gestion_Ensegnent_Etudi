using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Ensegnent_et_Etudient.Models
{
    public class Cours
    {
        public int Id { get; set; }
        public string NomCours { get; set; }
        public string Professeur { get; set; }
        public DateTime DateCreation { get; set; }
    }

}
