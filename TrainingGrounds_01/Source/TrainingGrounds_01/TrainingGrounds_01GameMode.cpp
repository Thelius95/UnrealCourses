// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

#include "TrainingGrounds_01GameMode.h"
#include "TrainingGrounds_01HUD.h"
#include "TrainingGrounds_01Character.h"
#include "UObject/ConstructorHelpers.h"

ATrainingGrounds_01GameMode::ATrainingGrounds_01GameMode()
	: Super()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnClassFinder(TEXT("/Game/FirstPersonCPP/Blueprints/FirstPersonCharacter"));
	DefaultPawnClass = PlayerPawnClassFinder.Class;

	// use our custom HUD class
	HUDClass = ATrainingGrounds_01HUD::StaticClass();
}
