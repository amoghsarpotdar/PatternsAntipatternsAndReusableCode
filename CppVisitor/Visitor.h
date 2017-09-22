#pragma once
#include "This.h"
#include "That.h"
#include "TheOther.h"

#ifndef _VISITOR_H_
#define _VISITOR_H_

namespace CppVisitor {
	class Visitor
	{
	public:
		virtual ~Visitor()
		{
		}

		virtual void visit(This *e) = 0;
		virtual void visit(That *e) = 0;
		virtual void visit(TheOther *t) = 0;
	};
}

#endif
