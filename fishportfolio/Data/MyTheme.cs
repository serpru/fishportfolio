using MudBlazor;

namespace fishportfolio.Data
{
    public class MyTheme :MudTheme
    {
        public MyTheme() :base()
        {
            // Light mode

            Palette.Primary = "#104B41";            // Text, Select list 061713 104B41
            Palette.Secondary = "#A2E2D3";
            Palette.Tertiary = "#2BCAAF";
            Palette.Background = "#3aba9d";
            Palette.AppbarBackground = "#f4faffff";   //  061713 1B1B1E
            Palette.AppbarText = "#535657";
            Palette.DrawerText = "#535657";
            Palette.DrawerBackground = "#f4faffff";   //  061713
            Palette.DrawerIcon = "#104B41";
            Palette.Divider = "#104B41";
            Palette.TextPrimary = "#535657";            // Breadcrumbs, Select "#535657"
            Palette.TextSecondary = "#104B41";
            Palette.ActionDefault = "#104B41";      //  Hamburger menu, appbar icons
            Palette.ActionDisabled = "#A1A4A5";
            Palette.TextDisabled = "#A1A4A5";

            //Palette.ActionDisabledBackground = "#9E4770";

            //Palette.ActionDisabled = "#9E4770";     //  8e9499
            //Palette.Surface = "#42f5f2";
            //Palette.LinesInputs = "#f4faffff";          // Select Outline
            // #2e957e

            // Dark mode

            PaletteDark.Primary = "#3aba9d";            // Text, Select list d4dbde
            PaletteDark.Secondary = "#0A2E36";
            PaletteDark.Tertiary = "#104B41";
            PaletteDark.Background = "#104B41";
            PaletteDark.AppbarBackground = "#0D1315";
            PaletteDark.AppbarText = "#f4faffff";
            PaletteDark.DrawerText = "#f4faffff";
            PaletteDark.DrawerBackground = "#0D1315";
            PaletteDark.DrawerIcon = "#f4faffff";
            PaletteDark.Divider = "#f4faffff";
            PaletteDark.TextPrimary = "#d4dbde";            // Breadcrumbs, text on MudCard, Select "#535657" d4dbde
            PaletteDark.TextSecondary = "#3aba9d";          // 9E4770
            PaletteDark.ActionDefault = "#3aba9d";      //  Hamburger menu, appbar icons
            PaletteDark.ActionDisabled = "#83A0A0";
            PaletteDark.TextDisabled = "#83A0A0";
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
