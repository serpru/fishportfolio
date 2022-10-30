using MudBlazor;

namespace fishportfolio.Data
{
    public class MyTheme :MudTheme
    {
        public MyTheme() :base()
        {
            Palette.Primary = "#f4faffff";
            Palette.Secondary = "#061713";
            Palette.Tertiary = "#4f646f";
            Palette.Background = "#3aba9d";
            Palette.AppbarBackground = "#061713";
            Palette.DrawerText = "#e6ad87";
            Palette.DrawerIcon = "#f4faffff";
            Palette.DrawerBackground = "#061713";
            Palette.Divider = "#f4faffff";
            Palette.TextPrimary = "#535657";
            Palette.TextSecondary = "#42f5f2";
            Palette.TextDisabled = "#42f5f2";
            Palette.ActionDisabled = "#8e9499";
            Typography.H1.FontSize = "2rem";
            Typography.H4.FontSize = "1.2rem";
            Typography.H5.FontSize = "1rem";
            Typography.H6.FontSize = "0.8rem";
        }
    }
}
