//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.PoolsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {

    public partial class Pools {

        public static Pool CreateBlueprintsPool() {
            return CreatePool("Blueprints", BlueprintsComponentIds.TotalComponents, BlueprintsComponentIds.componentNames, BlueprintsComponentIds.componentTypes);
        }

        public static Pool CreateBulletsPool() {
            return CreatePool("Bullets", BulletsComponentIds.TotalComponents, BulletsComponentIds.componentNames, BulletsComponentIds.componentTypes);
        }

        public static Pool CreateCorePool() {
            return CreatePool("Core", CoreComponentIds.TotalComponents, CoreComponentIds.componentNames, CoreComponentIds.componentTypes);
        }

        public static Pool CreateInputPool() {
            return CreatePool("Input", InputComponentIds.TotalComponents, InputComponentIds.componentNames, InputComponentIds.componentTypes);
        }

        public Pool[] allPools { get { return new[] { blueprints, bullets, core, input }; } }

        public Pool blueprints;
        public Pool bullets;
        public Pool core;
        public Pool input;

        public void SetAllPools() {
            blueprints = CreateBlueprintsPool();
            bullets = CreateBulletsPool();
            core = CreateCorePool();
            input = CreateInputPool();
        }
    }
}
