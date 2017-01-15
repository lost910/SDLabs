using SDLabsLib.Source.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SDLabsLib.Source.Helper
{
    public static class EntityValidationHelper
    {
        public static bool Validate(SonicSpeedInLiquidEntity entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Material))
                return false;
            if (string.IsNullOrWhiteSpace(entity.Type))
                return false;
            if (entity.Temperature < -273 || entity.Temperature > 3000)
                return false;
            if (entity.Speed < 0)
                return false;

            return true;
        }
    }
}
