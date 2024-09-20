using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApp
{
    public class AppTheme
    {
        private MaterialSkinManager materialSkinManager;

        public AppTheme(MaterialForm form)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(form);
        }

        public void Green()
        {
            materialSkinManager.ColorScheme = new ReaLTaiizor.Colors.MaterialColorScheme(
                ReaLTaiizor.Colors.MaterialPrimary.Green300,
                ReaLTaiizor.Colors.MaterialPrimary.Green700,
                ReaLTaiizor.Colors.MaterialPrimary.Green100,
                ReaLTaiizor.Colors.MaterialAccent.Pink200,
                ReaLTaiizor.Util.MaterialTextShade.WHITE);
        }

        public void Red()
        {       
            materialSkinManager.ColorScheme = new ReaLTaiizor.Colors.MaterialColorScheme(
                ReaLTaiizor.Colors.MaterialPrimary.Red300,
                ReaLTaiizor.Colors.MaterialPrimary.Red700,
                ReaLTaiizor.Colors.MaterialPrimary.Red100,
                ReaLTaiizor.Colors.MaterialAccent.Pink200,
                ReaLTaiizor.Util.MaterialTextShade.WHITE); 
        }

        public void Blue()
        {
            materialSkinManager.ColorScheme = new ReaLTaiizor.Colors.MaterialColorScheme(
                ReaLTaiizor.Colors.MaterialPrimary.Indigo500,
                ReaLTaiizor.Colors.MaterialPrimary.Indigo700,
                ReaLTaiizor.Colors.MaterialPrimary.Indigo100,
                ReaLTaiizor.Colors.MaterialAccent.Pink200,
                ReaLTaiizor.Util.MaterialTextShade.WHITE);
        }
    }
}
