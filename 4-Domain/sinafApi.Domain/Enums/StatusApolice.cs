using System.ComponentModel.DataAnnotations;

namespace SinafApi.Domain.Enums
{
    public enum StatusApolice
    {
        /// <sumary>
        /// Aceitar Automaticamente
        /// </sumary>
        [Display(Name = "Aceito")]
        Aceito = 1,

        /// <sumary>
        /// Pendente
        /// </sumary>
        [Display(Name = "Pendente")]
        Pendente = 2,

        /// <sumary>
        /// Recusado
        /// </sumary>
        [Display(Name = "Recusado")]
        Rejeitado = 3
    }
}
