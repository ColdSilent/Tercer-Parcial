using System.ComponentModel.DataAnnotations;

namespace OPTATIVOIII_3ER_PARCIAL.Models

{
    public class Usuario
      
    {
        public int IDUSUARIO { get; set; }
        public int IDPERSONA { get; set; }
        public string NOMBREUSUARIO { get; set; }
        public string CONTRASEÑA { get; set; }
        public string NIVEL { get; set; }
        public string ESTADO { get; set; }

        public Persona Persona { get; set; }
    }
  
}
