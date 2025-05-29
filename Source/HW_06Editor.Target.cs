// © Skillbox, 2024

using UnrealBuildTool;
using System.Collections.Generic;

public class HW_06EditorTarget : TargetRules
{
	public HW_06EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "HW_06" } );
	}
}
