using Microsoft.AspNetCore.Components;

namespace Employees.Web {

    public class MainLayoutBase : ComponentBase {

        public bool collapseNavMenu = true;

        public string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

        public void ToggleNavMenu() {
            collapseNavMenu = !collapseNavMenu;
        }

    }

}