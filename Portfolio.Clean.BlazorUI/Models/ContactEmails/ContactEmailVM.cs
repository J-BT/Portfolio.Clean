using System.ComponentModel.DataAnnotations;

namespace Portfolio.Clean.BlazorUI.Models.ContactEmails;

public class ContactEmailVM
{

    #region Attributes & Accessors
    public int Id { get; set; }

    [Required]
    [Display(Name = "Objet")]
    public string ContactEmailObject { get; set; } = string.Empty;

    [Required]
    [Display(Name = "Message")]
    public string ContactEmailContent { get; set; } = string.Empty;

    [Required]
    [Display(Name = "Expéditeur")]
    public string ContactEmailSender { get; set; } = string.Empty;

    #endregion

    #region Constructors

    #endregion

    #region Methods

    #endregion
}
