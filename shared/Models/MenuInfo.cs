namespace Shared.Models;

public static class MenuInfo
{
    // Definisce una classe o struct per rappresentare una singola voce di menu.
    public class MenuItem
    {
        public int MenuId { get; set; }
        public int? ParentMenuId { get; set; }
        public string? PageName { get; set; }
        public string? MenuName { get; set; }
        public string? IconName { get; set; }

        public MenuItem(int menuId, int? parentMenuId, string? pageName, string? menuName, string? iconName)
        {
            MenuId = menuId;
            ParentMenuId = parentMenuId;
            PageName = pageName;
            MenuName = menuName;
            IconName = iconName;
        }
    }

    // Una lista statica che tiene traccia delle voci di menu.
    public static List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();

    // Costruttore statico per inizializzare le voci di menu di default.
    static MenuInfo()
    {
        // Aggiunge alcune voci di menu di default alla lista.
        MenuItems.Add(new MenuItem(1, 0, "", "Home", "io io-home"));
        MenuItems.Add(new MenuItem(2, 0, null, "Counter", "io io-plus"));
        MenuItems.Add(new MenuItem(3, 0, null, "Fetch data", "io io-list-rich"));
        MenuItems.Add(new MenuItem(4, 2, "counter", "Counter", "io io-cart"));
        MenuItems.Add(new MenuItem(5, 2, "child/2", "Sub Menu-2", "io io-cart"));
        MenuItems.Add(new MenuItem(6, 3, "fetchdata", "Weather Forecast", "io io-list-rich"));
        // Aggiungi altre voci di menu di default come necessario.
    }
}