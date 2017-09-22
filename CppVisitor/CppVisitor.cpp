// CppVisitor.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Element.h"
#include "This.h"
#include "TheOther.h"
#include "That.h"


int main()
{
	CppVisitor::Element *list[] = {
		new CppVisitor::This(),new CppVisitor::That(), new CppVisitor::TheOther()
	};


    return 0;
}

