namespace EmployeesApp.Web.Views.Employees
{
    public class IndexVM
    {
        public required EmployeeItemVM[] Employees { get; set; }



        public class EmployeeItemVM
        {
            public required int Id { get; set; }
            public required string Name { get; set; }
            public required string Email { get; set; }

            public bool ShowAsHighlighted { get; set; } = false;
        }
    }
}