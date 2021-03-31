// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

// Find documentation and class members at this links:
// https://github.com/EpicGames/UnrealEngine/blob/release/Engine/Source/Programs/UnrealBuildTool/Configuration/ModuleRules.cs
// https://github.com/EpicGames/UnrealEngine/blob/release/Engine/Source/Programs/UnrealBuildTool/Configuration/ModuleRulesContext.cs
// https://github.com/EpicGames/UnrealEngine/blob/release/Engine/Source/Programs/UnrealBuildTool/Configuration/TargetRules.cs

using UnrealBuildTool;
using System.Collections.Generic;

public class UraniumDepositTarget : TargetRules
{
	public UraniumDepositTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "UraniumDeposit" } );
	}
}
