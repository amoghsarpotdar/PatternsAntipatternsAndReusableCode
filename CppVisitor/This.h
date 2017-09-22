#pragma once
#include "stdafx.h"
#include <string>
#include "Element.h"

#ifndef _THIS_H_
#define _THIS_H_

namespace CppVisitor {

	class This : public Element
	{
	public:
		void accept(Visitor &v);
		std::string This::printThis();
	};
}

#endif
