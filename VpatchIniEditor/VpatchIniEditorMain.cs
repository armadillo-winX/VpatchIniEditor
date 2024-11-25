using System.IO;
using System.Windows;
using ThGameMgr.Ex.Plugin;

namespace VpatchIniEditor
{
    public class VpatchIniEditorMain : SelectedGamePluginBase
    {
        public override string Name => "vpatch.ini エディタ";

        public override string Version => "0.1.0";

        public override string Developer => "珠音茉白/東方管制塔開発部";

        public override string Description => "VsyncPatch設定ファイル (vpatch.ini) を編集します。";

        public override string CommandName => "vpatch.ini を編集";

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
