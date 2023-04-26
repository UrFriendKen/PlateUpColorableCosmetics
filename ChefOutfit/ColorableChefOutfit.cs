using KitchenData;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace KitchenColorableCosmetics.ChefOutfit
{
    // Chef Outfit Prefab
    // -- Armature
    // -- Body
    // -- Chef
    // ------ Buttons
    // ------ Hat

    public abstract class ColorableChefOutfit : ColorablePlayerCosmetic
    {
        public override CosmeticType CosmeticType => CosmeticType.Outfit;
        public override bool DisableInGame => false;
        public override bool BlockHats => false;
        public override List<RestaurantSetting> CustomerSettings => new List<RestaurantSetting>();
        public override GameObject PrefabToCopy => (GDOUtils.GetExistingGDO(PlayerCosmeticReferences.ChefOutfit) as PlayerCosmetic).Visual;
    }

    public class BlueChefOutfit : ColorableChefOutfit
    {
        public override string UniqueNameID => "chefoutfitblue";

        protected override List<BaseMaterialInstruction> MaterialsToApply => new List<BaseMaterialInstruction>()
        {
            new MaterialInstruction<SkinnedMeshRenderer>()
            {
                Path = "Chef/Chef",
                Materials = new List<(string, bool)>()
                {
                    ("Clothing Blue", false)
                }
            },
            new MaterialInstruction<SkinnedMeshRenderer>()
            {
                Path = "Chef/Chef/Buttons",
                Materials = new List<(string, bool)>()
                {
                    ("Clothing Black Shiny", false)
                }
            },
            new MaterialInstruction <SkinnedMeshRenderer>()
            {
                Path = "Chef/Chef/Hat",
                Materials = new List<(string, bool)>()
                {
                    ("Clothing Blue", false)
                }
            }
        };
    }

    public class GreenChefOutfit : ColorableChefOutfit
    {
        public override string UniqueNameID => "chefoutfitgreen";

        protected override List<BaseMaterialInstruction> MaterialsToApply => new List<BaseMaterialInstruction>()
        {
            new MaterialInstruction<SkinnedMeshRenderer>()
            {
                Path = "Chef/Chef",
                Materials = new List<(string, bool)>()
                {
                    ("Clothing Green", false)
                }
            },
            new MaterialInstruction<SkinnedMeshRenderer>()
            {
                Path = "Chef/Chef/Buttons",
                Materials = new List<(string, bool)>()
                {
                    ("Clothing Black Shiny", false)
                }
            },
            new MaterialInstruction <SkinnedMeshRenderer>()
            {
                Path = "Chef/Chef/Hat",
                Materials = new List<(string, bool)>()
                {
                    ("Clothing Green", false)
                }
            }
        };
    }

    public class YellowChefOutfit : ColorableChefOutfit
    {
        public override string UniqueNameID => "chefoutfityellow";

        protected override List<BaseMaterialInstruction> MaterialsToApply => new List<BaseMaterialInstruction>()
        {
            new MaterialInstruction<SkinnedMeshRenderer>()
            {
                Path = "Chef/Chef",
                Materials = new List<(string, bool)>()
                {
                    ("Clothing - Yellow", false)
                }
            },
            new MaterialInstruction<SkinnedMeshRenderer>()
            {
                Path = "Chef/Chef/Buttons",
                Materials = new List<(string, bool)>()
                {
                    ("Clothing Black Shiny", false)
                }
            },
            new MaterialInstruction <SkinnedMeshRenderer>()
            {
                Path = "Chef/Chef/Hat",
                Materials = new List<(string, bool)>()
                {
                    ("Clothing - Yellow", false)
                }
            }
        };
    }
}
