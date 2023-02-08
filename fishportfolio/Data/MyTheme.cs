using MudBlazor;

namespace fishportfolio.Data
{
    public class MyTheme :MudTheme
    {
        public MyTheme() :base()
        {
            // Light mode

            Palette.Primary = "#104B41";            // Text, Select list 061713
            Palette.Secondary = "#F4FAFF";
            Palette.Tertiary = "#104B41";
            Palette.Background = "#3aba9d";
            Palette.AppbarBackground = "#061713";
            Palette.DrawerText = "#f4faffff";
            Palette.DrawerIcon = "#f4faffff";
            Palette.DrawerBackground = "#061713";
            Palette.Divider = "#104B41";
            Palette.TextPrimary = "#535657";            // Breadcrumbs, Select "#535657"
            Palette.TextSecondary = "#42f5f2";
            Palette.TextDisabled = "#3aba9d";
            Palette.ActionDisabled = "#8e9499";
            //Palette.Surface = "#42f5f2";
            //Palette.LinesInputs = "#f4faffff";          // Select Outline
            // #2e957e

            // Dark mode

            //PaletteDark.Primary = "#3aba9d";            // Text, Select list d4dbde
            //PaletteDark.Secondary = "#F4FAFF";
            //PaletteDark.Tertiary = "#3aba9d";
            PaletteDark.Background = "#104B41";
            PaletteDark.AppbarBackground = "#0D1315";
            PaletteDark.DrawerText = "#f4faffff";
            PaletteDark.DrawerIcon = "#f4faffff";
            PaletteDark.DrawerBackground = "#061713";
            PaletteDark.Divider = "#f4faffff";
            PaletteDark.TextPrimary = "#d4dbde";            // Breadcrumbs, text on MudCard, Select "#535657"
            PaletteDark.TextSecondary = "#9E4770";
            //PaletteDark.TextDisabled = "#3aba9d";
            //PaletteDark.ActionDisabled = "#8e9499";
            PaletteDark.Surface = "#0A2E36";
            //PaletteDark.LinesDefault = "#b3babc";

            // Typography
            Typography.H1.FontSize = "2rem";
            Typography.H1.FontWeight = 600;

            Typography.H2.FontSize = "1.3rem";

            Typography.H4.FontSize = "1.2rem";
            Typography.H5.FontSize = "1rem";
            Typography.H6.FontSize = "0.8rem";
        }
    }
}
