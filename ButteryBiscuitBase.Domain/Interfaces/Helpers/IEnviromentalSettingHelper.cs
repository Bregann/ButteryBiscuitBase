using ButteryBiscuitBase.Domain.Enums;

namespace ButteryBiscuitBase.Domain.Interfaces.Helpers
{
    public interface IEnviromentalSettingHelper
    {
        Task LoadEnvironmentalSettings();
        string? TryGetEnviromentalSettingValue(EnvironmentalSettingEnum key);
        Task<bool> UpdateEnviromentalSettingValue(EnvironmentalSettingEnum key, string newValue);
    }
}
