﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodAndStyleOrderPlanning.Core
{
    public static class LanguageResources
    {
        public static Dictionary<string, string> ProductTypeTranslations;
        public static Dictionary<string, string> MeasuringUnitTranslations;
        public static Dictionary<string, string> MeasuringUnitTranslationsWithOutPieces;
        public static Dictionary<string, string> ProductFreshnessTranslations;
        public static Dictionary<string, string> RecipeTypeTranslations;

        public static string GetMeasuringUnitTranslation(MeasuringUnit measuringUnit)
        {
            return LanguageResources.MeasuringUnitTranslations.First(p => p.Key == ((int)measuringUnit).ToString()).Value;
        }

        public static string GetProductTypeTranslation(ProductType productType)
        {
            return LanguageResources.ProductTypeTranslations.First(p => p.Key == ((int)productType).ToString()).Value;
        }
        public static string GetProductFreshnessTranslation(ProductFreshness productFreshnessOption)
        {
            return LanguageResources.ProductFreshnessTranslations.First(p => p.Key == ((int)productFreshnessOption).ToString()).Value;
        }

        //public static string GetMeasuringUnitTranslation(RecipeType recipeType)
        //{
        //    return LanguageResources.MeasuringUnitTranslations.First(p => p.Key == ((int)measuringUnit).ToString()).Value;
        //}


        static LanguageResources()
        {
            ProductTypeTranslations = new Dictionary<string, string>();
            ProductTypeTranslations.Add(((int)ProductType.FruitAndVegetables_Fresh).ToString(), "Φρούτα & Λαχανικά - Φρέσκα");
            ProductTypeTranslations.Add(((int)ProductType.Vegetables_Cut).ToString(), "Λαχανικά - Κομμένα");
            ProductTypeTranslations.Add(((int)ProductType.Bakaliki).ToString(), "Μπακαλική");
            ProductTypeTranslations.Add(((int)ProductType.Meat).ToString(), "Κρέατα");
            ProductTypeTranslations.Add(((int)ProductType.Fish).ToString(), "Ψάρι/Θαλασσινά");
            ProductTypeTranslations.Add(((int)ProductType.Pastry).ToString(), "Ζαχαροπλαστική");
            ProductTypeTranslations.Add(((int)ProductType.Other).ToString(), "Διάφορα");
            ProductTypeTranslations.Add(((int)ProductType.SpecialGroup1).ToString(), "Ειδική Κατηγορία 1");

            MeasuringUnitTranslations = new Dictionary<string, string>();
            MeasuringUnitTranslations.Add(((int)MeasuringUnit.Grams).ToString(), "Γραμμάρια");
            MeasuringUnitTranslations.Add(((int)MeasuringUnit.Millilitres).ToString(), "Χιλιοστόλιτρα");
            MeasuringUnitTranslations.Add(((int)MeasuringUnit.Pieces).ToString(), "Τεμάχια");

            MeasuringUnitTranslationsWithOutPieces = new Dictionary<string, string>();
            MeasuringUnitTranslationsWithOutPieces.Add(((int)MeasuringUnit.Grams).ToString(), "Γραμμάρια");
            MeasuringUnitTranslationsWithOutPieces.Add(((int)MeasuringUnit.Millilitres).ToString(), "Χιλιοστόλιτρα");

            ProductFreshnessTranslations = new Dictionary<string, string>();
            ProductFreshnessTranslations.Add(((int)ProductFreshness.OneDayBeforeOrder).ToString(), "1 ημέρα");
            ProductFreshnessTranslations.Add(((int)ProductFreshness.TwoDaysBeforeOrder).ToString(), "2 μέρες");
            ProductFreshnessTranslations.Add(((int)ProductFreshness.ThreeDaysBeforeOrder).ToString(), "3 μέρες");
            ProductFreshnessTranslations.Add(((int)ProductFreshness.FourDaysBeforeOrder).ToString(), "4 μέρες");
            ProductFreshnessTranslations.Add(((int)ProductFreshness.FiveDaysBeforeOrder).ToString(), "5 μέρες");
            ProductFreshnessTranslations.Add(((int)ProductFreshness.Indifferent).ToString(), "Αδιάφορο");

            RecipeTypeTranslations = new Dictionary<string, string>();
            RecipeTypeTranslations.Add(((int)RecipeType.Unknown).ToString(), "Άγνωστη");
            RecipeTypeTranslations.Add(((int)RecipeType.Other).ToString(), "Χωρίς Κατηγορία");
            RecipeTypeTranslations.Add(((int)RecipeType.OliveOil).ToString(), "Λαδερά");
            RecipeTypeTranslations.Add(((int)RecipeType.Ospria).ToString(), "Όσπρια");
            RecipeTypeTranslations.Add(((int)RecipeType.Soup).ToString(), "Σούπες");
            RecipeTypeTranslations.Add(((int)RecipeType.Pasta).ToString(), "Ζυμαρικά");
            RecipeTypeTranslations.Add(((int)RecipeType.Pies).ToString(), "Πίτες");
            RecipeTypeTranslations.Add(((int)RecipeType.GroundMeat).ToString(), "Με Κιμά");
            RecipeTypeTranslations.Add(((int)RecipeType.Beef).ToString(), "Με Μοσχάρι");
            RecipeTypeTranslations.Add(((int)RecipeType.Pork).ToString(), "Με Χοιρινό");
            RecipeTypeTranslations.Add(((int)RecipeType.Sausage).ToString(), "Με Λουκάνικο");
            RecipeTypeTranslations.Add(((int)RecipeType.Tartes).ToString(), "Τάρτες");
            RecipeTypeTranslations.Add(((int)RecipeType.StreetFood).ToString(), "Street Food");
            RecipeTypeTranslations.Add(((int)RecipeType.Salad).ToString(), "Σαλάτα");
            RecipeTypeTranslations.Add(((int)RecipeType.Sandwich).ToString(), "Σαντουιτς");
            RecipeTypeTranslations.Add(((int)RecipeType.Garnish).ToString(), "Γαρνιτούρες");
        }
}

    public static class OrderingConfiguration
    {
        public static Dictionary<ProductType, List<OrderDay>> ProductTypeNonDeliveryDays;

        static OrderingConfiguration()
        {
            ProductTypeNonDeliveryDays[ProductType.FruitAndVegetables_Fresh] = new List<OrderDay>();
            ProductTypeNonDeliveryDays[ProductType.Vegetables_Cut] = new List<OrderDay>() { OrderDay.Sunday };
            ProductTypeNonDeliveryDays[ProductType.Bakaliki] = new List<OrderDay>() { OrderDay.Sunday };
            ProductTypeNonDeliveryDays[ProductType.Meat] = new List<OrderDay>() { OrderDay.Sunday };
            ProductTypeNonDeliveryDays[ProductType.Fish] = new List<OrderDay>() { OrderDay.Sunday };
            ProductTypeNonDeliveryDays[ProductType.Pastry] = new List<OrderDay>() { OrderDay.Sunday };
            ProductTypeNonDeliveryDays[ProductType.Other] = new List<OrderDay>() { OrderDay.Sunday };
        }
    }
}
