// MESO Digital Interiors GmbH. (C) 2020-
#pragma once

#include "CoreMinimal.h"
#include "UObject/Interface.h"
#include "GameFramework/Actor.h"

#include "CefInitTester.generated.h"

UCLASS(BlueprintType)
class URANIUMDEPOSIT_API ACefInitTester : public AActor
{
    GENERATED_BODY()
public:

    UFUNCTION(CallInEditor)
		void InitUranium();

	UFUNCTION(CallInEditor)
		void ShutdownUranium();
};
