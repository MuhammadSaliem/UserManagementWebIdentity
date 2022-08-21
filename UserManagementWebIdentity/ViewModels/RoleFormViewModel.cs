using System.ComponentModel.DataAnnotations;

namespace UserManagementWebIdentity.ViewModels
{
    public class RoleFormViewModel
    {
        [Required, MaxLength(256)]
        public string Name { get; set; }
    }
}
