// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class TrainingGrounds_01EditorTarget : TargetRules
{
	public TrainingGrounds_01EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.Add("TrainingGrounds_01");
	}
}
