namespace UserManagementWebIdentity.ViewModels
{
    public class UserRolesViewModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public List<RoleViewModel> Roles { get; set; } // Must be List and not IEnumerable so we can iterate over
    }
}
