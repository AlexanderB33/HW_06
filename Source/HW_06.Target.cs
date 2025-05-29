// © Skillbox, 2024

using UnrealBuildTool;
using System.Collections.Generic;

public class HW_06Target : TargetRules
{
	public HW_06Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "HW_06" } );
	}
}
