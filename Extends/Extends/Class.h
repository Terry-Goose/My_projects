#pragma once

#include <stdio.h>

class A
{
public:
	void fA() {
		printf("void fA()\n");
	}
};

class B : public A
{
public:
	void fB() {
		printf("void fB()\n");
	}
};

class B2
{
	A a;
public:
	void fB() {
		printf("void fB()\n");
	}
	void fA() {
		a.fA();
	}
	operator A() {
		return a;
	}
};