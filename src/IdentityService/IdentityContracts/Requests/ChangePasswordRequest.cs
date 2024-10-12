using System.ComponentModel.DataAnnotations;

namespace IdentityContracts.Requests;

public class ChangePasswordRequest
{
    [Required] public string UserName { get; set; } = default!;
    [Required] public string Password { get; set; } = default!;
}
