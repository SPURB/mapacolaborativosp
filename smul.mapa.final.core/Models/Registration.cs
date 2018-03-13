using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace smul.mapa.final.core.Models
{
    public class Registration
    {
        public int ID { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Nome da Instituução")]

        public string NomeInstituicao { get; set; }
        [Required]
        [StringLength(10)]
        [Display(Name = "Telefone Fixo")]
        public string TelefoneFixo { get; set; }
        [Required]
        [StringLength(11)]
        [Display(Name = "Telefone Celular")]
        public string TelefoneCelular { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Required]
        [StringLength(255)]
        public string Site { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Perfil Facebook")]
        public string ProfileFacebook { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Nome do Representante")]
        public string NomeRepresentante { get; set; }
        [Required]
        [StringLength(255)]
        public string Rua { get; set; }
        [Required]
        public string Numero { get; set; }
        [Required]

        public string CEP { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Prefeitura Regional")]
        public string PrefeituraRegional { get; set; }
        public string Segmento { get; set; }
        public string Tematica { get; set; }
        [Display(Name = "Tempo de Atuação")]
        public string TempoDeAtucao { get; set; }
        public bool Registro { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
    }
}
