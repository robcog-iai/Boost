// Copyright 2019, Institute for Artificial Intelligence - University of Bremen
// Author: Andrei Haidu (http://haidu.eu)

using UnrealBuildTool;
using System.IO;

public class Boost : ModuleRules
{
	public Boost(ReadOnlyTargetRules Target) : base(Target)
	{
		// We are just setting up paths for pre-compiled binaries.
		Type = ModuleType.External;

		// For boost::
		bEnableUndefinedIdentifierWarnings = false;
		bUseRTTI = true;

		PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "includes"));
		// PublicSystemIncludePaths.Add(Path.Combine(ModuleDirectory, "includes"));
	}
}
