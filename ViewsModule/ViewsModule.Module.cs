using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewsModule
{
    public class ViewsModule : IModule
    {
        private readonly IRegionViewRegistry regionViewRegistry;

        public ViewsModule(IRegionViewRegistry registry)
        {
            regionViewRegistry = registry;
        }

        public void Initialize()
        {
            regionViewRegistry.RegisterViewWithRegion("ProgramHeaderRegion",
                     typeof(View.ProgramHeaderAreaView));
            regionViewRegistry.RegisterViewWithRegion("SystemRegion",
                typeof(View.SystemAreaView));
            regionViewRegistry.RegisterViewWithRegion("AlarmRegion",
                     typeof(View.AlarmAreaView));
            regionViewRegistry.RegisterViewWithRegion("FunctionRegion",
                typeof(View.FunctionKeyView));
            regionViewRegistry.RegisterViewWithRegion("Crop1AreaRegion",
                     typeof(View.Crop1AreaView));
            regionViewRegistry.RegisterViewWithRegion("Crop2AreaRegion",
                typeof(View.Crop2AreaView));
            regionViewRegistry.RegisterViewWithRegion("SystemAnimationRegion",
                     typeof(View.SystemStateView));
            regionViewRegistry.RegisterViewWithRegion("CameraRegion",
                typeof(View.CameraView));
        }
    }
}
