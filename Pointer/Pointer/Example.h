#pragma once
class Iop {
public:
	virtual int op(int a, int b) = 0;
	virtual int init() = 0;
};

class sum:public Iop {
public:
	virtual int op(int a, int b)
	{
		return (a + b);
	}
	virtual int init()
	{
		return 0;
	}
};

class arr {
	int * a;
public:
	arr() {
		a = new int;
		*a = 0;
	}
	arr(const arr &p)
	{
		a = new int;
		*a = *(p.a);
	}
arr& operator = (const arr &p)
{
	if (this == &p)
	{
		return *this;
	}
	delete a;
	a = new int;
	*a = *(p.a);

	return *this;
}

~arr()
{
	delete a;
}
};

class p {
	Iop * p1;
public:
	p(Iop * p1)
	{
		this->p1 = p1;
	}

	Iop * operator ->()
	{
		return p1;
	}

	Iop& operator *()
	{
		return *p1;
	}

	~p()
	{
		delete p1;
	}
};