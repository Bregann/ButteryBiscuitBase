using ButteryBiscuitBase.Domain.Data.Database.Context;
using ButteryBiscuitBase.Domain.Data.Database.Models;
using ButteryBiscuitBase.Domain.Interfaces.Helpers;

namespace ButteryBiscuitBase.Domain.Helpers
{
    public class DatabaseSeedHelper
    {
        public static async Task SeedDatabase(AppDbContext context, IEnvironmentalSettingHelper settingsHelper, IServiceProvider serviceProvider)
        {
            // Generate the data
            // blah blah blah

            await context.EnvironmentalSettings.AddAsync(new EnvironmentalSetting
            {
                Key = Enums.EnvironmentalSettingEnum.HangfireUsername,
                Value = "admin"
            });

            await context.EnvironmentalSettings.AddAsync(new EnvironmentalSetting
            {
                Key = Enums.EnvironmentalSettingEnum.HangfirePassword,
                Value = "password"
            });

            await context.SaveChangesAsync();
        }
    }
}
