// MESO Digital Interiors GmbH. (C) 2020-

#include "CefInitTester.h"
#include "UraniumContext.h"

void ACefInitTester::InitUranium()
{
	GetSingletonUraniumContext()->Initialize();
}

void ACefInitTester::ShutdownUranium()
{
	GetSingletonUraniumContext()->Shutdown();
}
