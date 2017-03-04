#include <stdio.h>
#include "Class.h"

int main()
{
	A a;
	B b;
	B2 c;

	printf("nasledovanie\n");
	b.fA();
	b.fB();
	printf("agregacia\n");
	c.fA();
	c.fB();
	return 0;
}