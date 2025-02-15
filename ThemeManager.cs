namespace AutoClickerNetCore;

internal static class ThemeManager
{
    private static readonly Color DarkThemeBackColor = Color.FromArgb(255, 33, 33, 33);
    private static readonly Color DarkThemeForeColor = Color.FromArgb(255, 225, 225, 225);
    private static readonly Color LightThemeBackColor = SystemColors.Control;
    private static readonly Color LightThemeForeColor = SystemColors.ControlText;
    
    public static void ApplyTheme(Form form, bool isDarkMode)
    {
        if (isDarkMode)
        {
            form.BackColor = DarkThemeBackColor;
            form.ForeColor = DarkThemeForeColor;
        }
        else
        {
            form.BackColor = LightThemeBackColor;
            form.ForeColor = LightThemeForeColor;
        }

        foreach (Control control in form.Controls)
        {
            ApplyThemeToControl(control, isDarkMode);
        }
    }

    private static void ApplyThemeToControl(Control control, bool isDarkMode)
    {
        if (isDarkMode)
        {
            control.BackColor = DarkThemeBackColor;
            control.ForeColor = DarkThemeForeColor;
        }
        else
        {
            control.BackColor = LightThemeBackColor;
            control.ForeColor = LightThemeForeColor;
        }

        foreach (Control childControl in control.Controls)
        {
            ApplyThemeToControl(childControl, isDarkMode);
        }
    }
}