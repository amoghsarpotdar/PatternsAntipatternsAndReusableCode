#pragma once
#include "stdafx.h"
#include <string>
#include "Element.h"

namespace CppVisitor
{
	class Visitor;

	class That : public Element
	{
	public:
		void accept(Visitor &v);
		std::string PrintThat();
		
	};
}
