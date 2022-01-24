using System.Windows.Forms;
using System;
namespace WindowsFormsDoctor
{   
    
	public static class Mode
	{
		public static bool Light;
		public static void SwitchMode(ColorScheme scheme, Control.ControlCollection container)
		{
            foreach (Control component in container)
            {   
                if (component is Panel)
                {
                    ChangeTheme(scheme, component.Controls);
                    component.BackColor = scheme.PanelBG;
                    component.ForeColor = scheme.PanelFG;
                }
                else if (component is Button)
                {
                    component.BackColor = scheme.ButtonBG;
                    component.ForeColor = scheme.ButtonFG;
                }
                else if (component is TextBox)
                {
                    component.BackColor = scheme.TextBoxBG;
                    component.ForeColor = scheme.TextBoxFG;
                }
            }
	    }
	}
}
