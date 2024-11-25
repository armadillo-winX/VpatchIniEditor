using System.IO;
using System.Windows;
using ThGameMgr.Ex.Plugin;

namespace VpatchIniEditor
{
    public class VpatchIniEditorMain : SelectedGamePluginBase
    {
        public override string Name => "vpatch.ini �G�f�B�^";

        public override string Version => "0.1.0";

        public override string Developer => "�쉹䝔�/�����ǐ����J����";

        public override string Description => "VsyncPatch�ݒ�t�@�C�� (vpatch.ini) ��ҏW���܂��B";

        public override string CommandName => "vpatch.ini ��ҏW";

        public Window? MainWindow { get; set; }

        public override void Main(string gameId, string gameFile)
        {
            string? gameDirectory = Path.GetDirectoryName(gameFile);
            if (!string.IsNullOrEmpty(gameDirectory))
            {
                string vpatchIniFile = $"{gameDirectory}\\vpatch.ini";

                EditVpatchIniDialog editVpatchIniDialog = new()
                {
                    VsyncPatchIniFilePath = vpatchIniFile
                };

                if (this.MainWindow != null)
                {
                    editVpatchIniDialog.Owner = this.MainWindow;
                }

                editVpatchIniDialog.ShowDialog();
            }
        }
    }
}
