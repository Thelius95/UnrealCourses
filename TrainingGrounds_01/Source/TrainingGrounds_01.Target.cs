// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class TrainingGrounds_01Target : TargetRules
{
	public TrainingGrounds_01Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("TrainingGrounds_01");
	}
}
