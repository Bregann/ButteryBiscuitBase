using ButteryBiscuitBase.Domain.Data.Database;
using ButteryBiscuitBase.Domain.Enums;
using ButteryBiscuitBase.Domain.Interfaces.Helpers;
using Microsoft.EntityFrameworkCore;

namespace ButteryBiscuitBase.Domain.Helpers
{
    public class EnvironmentalSettingHelper(AppDbContext dbContext): IEnviromentalSettingHelper
    {
        private readonly AppDbContext _dbContext = dbContext;
        private Dictionary<EnvironmentalSettingEnum, string> _environmentalSettings = [];

        public async Task LoadEnvironmentalSettings()
        {
            _environmentalSettings = await _dbContext.EnvironmentalSettings.ToDictionaryAsync(x => x.Key, x => x.Value);
        }

        public string? TryGetEnviromentalSettingValue(EnvironmentalSettingEnum key)
        {
            return _environmentalSettings.TryGetValue(key, out var value) ? value : null;
        }

        public async Task<bool> UpdateEnviromentalSettingValue(EnvironmentalSettingEnum key, string newValue)
        {
            if (!_environmentalSettings.ContainsKey(key))
            {
                return false;
            }

            _environmentalSettings[key] = newValue;
            _dbContext.EnvironmentalSettings.Where(x => x.Key == key).First().Value = newValue;
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
