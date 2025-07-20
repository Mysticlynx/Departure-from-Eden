using Sandbox.Definitions;
using VRage.Game.Components;

namespace VanillaBlockCategorySupression
{
    [MySessionComponentDescriptor(MyUpdateOrder.NoUpdate)]
    public class Example_RemoveCategory : MySessionComponentBase
    {
        public override void LoadData()
        {
            RemoveCategory("Section1_Position1_LargeBlocks");
            RemoveCategory("Section1_Position1_SmallBlocks");
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