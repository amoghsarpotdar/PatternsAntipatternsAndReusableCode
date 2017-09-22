#include "stdafx.h"

//using namespace CppVisitor;
#ifdef _THIS__H_

namespace CppVisitor {

	void This::accept(Visitor& v)
	{
		v.visit(this);
	}

	std::string This::printThis()
	{
		return "This";
	}

}

#endif