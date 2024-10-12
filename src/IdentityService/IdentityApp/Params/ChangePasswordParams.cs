namespace IdentityApp.Params;

public record ChangePasswordParams(
    Guid UserId,
    string NewPassword,
    string OldPassword);
