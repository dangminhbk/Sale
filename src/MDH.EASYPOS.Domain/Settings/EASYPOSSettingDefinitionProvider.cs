using Volo.Abp.Settings;

namespace MDH.EASYPOS.Settings
{
    public class EASYPOSSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(EASYPOSSettings.MySetting1));
        }
    }
}
