#include "stdafx.h"
#include "Element.h"
#include <string>
#include "TheOther.h"

namespace CppVisitor
{
	void TheOther::accept(Visitor& v)
	{
	}

	std::string TheOther::PrintTheOther()
	{
		return "TheOther";
	}
}
