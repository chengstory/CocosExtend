using CocoStudio.Basic;
using Mono.Addins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: Addin("MyButton", Option.MainVersion, Namespace = Option.AddinNamespace)]

[assembly: AddinDependency("CocoStudio.Core", Option.MainVersion)]
[assembly: AddinDependency("CocoStudio.Projects", Option.MainVersion)]
[assembly: AddinDependency("CocoStudio.Model", Option.MainVersion)]
[assembly: AddinDependency("CocoStudio.ResourcePanel", Option.MainVersion)]
[assembly: AddinDependency("CocoStudio.Model.Lua", Option.MainVersion)]
[assembly: AddinDependency("Addins.LuaExtend", Option.MainVersion)]