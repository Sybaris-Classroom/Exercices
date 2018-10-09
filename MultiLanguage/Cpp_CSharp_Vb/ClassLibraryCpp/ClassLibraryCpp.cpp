// This is the main DLL file.

#include "stdafx.h"

#include "ClassLibraryCpp.h"
namespace ClassLibraryCpp {

	int EmployeCpp::CodeCpp()
	{
		String^ s = CodeVB();

		Console :: WriteLine("Mon code Cpp");

		int i = s->Length;
		int j = i++;
		return j;
	}
}