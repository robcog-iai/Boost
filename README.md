# Boost

 * third party Unreal Engine Module of the boost libraries
 * current version `1.71.0`

# Usage

* clone/download the module next to any other module in your project or plugin

   `MyProject/Source/<git clone here>`

   `MyPlugin/Source/<git clone here>`

* if you are using the library in the Module `MyModule`, add the module dependency (`Boost`) to your `MyModule.Build.cs` file:

   ```csharp
   ..
   PrivateDependencyModuleNames.AddRange(
     new string[]
     {
       "CoreUObject",
       "Engine",
       "Slate",
       "SlateCore",
       // ... add private dependencies that you statically link with here ...
       "Boost",
     }
     );
   ..
   ```

* if you are using the third party code in `MyCode.cpp` file, include the boost libraries between such macros([reason and solution](https://answers.unrealengine.com/questions/391017/constant-library-conflicts.html)):

```cpp
THIRD_PARTY_INCLUDES_START
#pragma push_macro("check")
#undef check

#include <boost/geometry.hpp>
#include <boost/geometry/geometries/point.hpp>
#include <boost/geometry/geometries/box.hpp>
#include <boost/geometry/index/rtree.hpp>

#pragma pop_macro("check")
THIRD_PARTY_INCLUDES_END
```

* depending on which headers you include, you might need more of these macros:

```cpp
THIRD_PARTY_INCLUDES_START
#pragma push_macro("CONSTEXPR")
#undef CONSTEXPR
#pragma push_macro("dynamic_cast")
#undef dynamic_cast
#pragma push_macro("check")
#undef check
#pragma push_macro("PI")
#undef PI

#include <boost/geometry.hpp>
#include <boost/geometry/geometries/point.hpp>
#include <boost/geometry/geometries/box.hpp>
#include <boost/geometry/index/rtree.hpp>

#pragma pop_macro("PI")
#pragma pop_macro("check")
#pragma pop_macro("dynamic_cast")
#pragma pop_macro("CONSTEXPR")
THIRD_PARTY_INCLUDES_END

```
