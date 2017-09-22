#include "stdafx.h"

#ifdef _THAT_H_

namespace CppVisitor {
	std::string That::PrintThat()
	{
		return "That";
	}

	void That::accept(Visitor& v)
	{
		v.visit(this);
	}

}

#endif