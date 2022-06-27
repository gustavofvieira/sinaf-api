using System.ComponentModel.DataAnnotations;

namespace SinafApi.Domain.Enums
{
    public enum Sexo
    {
        /// <sumary>
        /// Masculino
        /// </sumary>
        [Display(Name = "Masculino")]
        Aceitar = 1,

        /// <sumary>
        /// Gerar Pendencia Automaticamente
        /// </sumary>
        [Display(Name = "Gerar Pendencia Automaticamente")]
        Pendente = 2,

        /// <sumary>
        /// Recusar Automaticamente
        /// </sumary>
        [Display(Name = "Recusar Automaticamente")]
        Rejeitar = 3
    }
}
