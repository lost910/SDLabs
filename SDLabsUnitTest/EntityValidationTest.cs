using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDLabsLib.Source.Entity;
using SDLabsLib.Source.Helper;

namespace SDLabsUnitTest
{
    [TestClass]
    public class EntityValidationTest
    {
        [TestMethod]
        public void ValidEntityValidationTest()
        {
            SonicSpeedInLiquidEntity entity = new SonicSpeedInLiquidEntity
            {
                Material = "Анилин",
                Type = "Чистое вещество",
                Temperature = 20,
                Speed = 1656
            };
            Assert.IsTrue(EntityValidationHelper.Validate(entity));
        }

        [TestMethod]
        public void InvalidEntityValidationTest()
        {
            SonicSpeedInLiquidEntity entity = new SonicSpeedInLiquidEntity
            {
                Material = "",
                Type = "",
                Temperature = 6000,
                Speed = 1656
            };
            Assert.IsFalse(EntityValidationHelper.Validate(entity));
        }

        [TestMethod]
        public void EmptyNameValidationTest()
        {
            SonicSpeedInLiquidEntity entity = new SonicSpeedInLiquidEntity
            {
                Material = "",
                Type = "Чистое вещество",
                Temperature = 20,
                Speed = 1656
            };
            Assert.IsFalse(EntityValidationHelper.Validate(entity));
        }

        [TestMethod]
        public void EmptyTypeValidationTest()
        {
            SonicSpeedInLiquidEntity entity = new SonicSpeedInLiquidEntity
            {
                Material = "Анилин",
                Type = "",
                Temperature = 20,
                Speed = 1656
            };
            Assert.IsFalse(EntityValidationHelper.Validate(entity));
        }

        [TestMethod]
        public void InvalidTemperatureValidationTest()
        {
            SonicSpeedInLiquidEntity entity = new SonicSpeedInLiquidEntity
            {
                Material = "",
                Type = "Чистое вещество",
                Temperature = -500,
                Speed = 1656
            };
            Assert.IsFalse(EntityValidationHelper.Validate(entity));
        }

        [TestMethod]
        public void InvalidSpeedValidationTest()
        {
            SonicSpeedInLiquidEntity entity = new SonicSpeedInLiquidEntity
            {
                Material = "Анилин",
                Type = "Чистое вещество",
                Temperature = 20,
                Speed = -1
            };
            Assert.IsFalse(EntityValidationHelper.Validate(entity));
        }
    }
}
