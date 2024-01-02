using Sandbox.Definitions;
using VRage.Game.Components;

namespace VanillaBlockCategorySupression
{
    [MySessionComponentDescriptor(MyUpdateOrder.NoUpdate)]
    public class Example_RemoveCategory : MySessionComponentBase
    {
        public override void LoadData()
        {
            RemoveCategory("LargeBlocks");
            RemoveCategory("Armorblocks");
            RemoveCategory("WarfarePack1");
            RemoveCategory("WarfarePack2");
            RemoveCategory("DecorativeBlocks1");
            RemoveCategory("DecorativeBlocks2");
            RemoveCategory("DecorativeBlocks3");
            RemoveCategory("GridAutomation");
            RemoveCategory("FrozenBlocks");
            RemoveCategory("SparksOfTheFutureBlocks");
            RemoveCategory("ScrapRacePack");
            RemoveCategory("IndustrialPack");
            RemoveCategory("203Pack");
            // can repeat the above line to remove more
        }

        void RemoveCategory(string categoryName)
        {
            MyGuiBlockCategoryDefinition categoryDef;
            if(MyDefinitionManager.Static.GetCategories().TryGetValue(categoryName, out categoryDef))
            {
                categoryDef.ItemIds.Clear();

                categoryDef.IsBlockCategory = true;
                categoryDef.IsAnimationCategory = false;
                categoryDef.IsShipCategory = false;
                categoryDef.IsToolCategory = false;
            }
        }

        protected override void UnloadData()
        {
        }
    }
}