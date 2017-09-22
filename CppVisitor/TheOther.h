#pragma once
#include "Element.h"

#ifndef _THEOTHER_H_
#define _THEOTHER_H_

namespace CppVisitor
{
	class TheOther : public Element
	{
	public:
		void accept(Visitor &v) override;
		std::string TheOther::PrintTheOther();
		
	};
}

#endif
