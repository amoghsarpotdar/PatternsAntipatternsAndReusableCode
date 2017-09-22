#pragma once
#ifndef _CPPVISITOR_
#define _CPPVISITOR_

namespace CppVisitor
{
	class Element
	{
		public:
		virtual ~Element()
		{
		}

		virtual void accept(class Visitor &v)=0;
	};

}

#endif
