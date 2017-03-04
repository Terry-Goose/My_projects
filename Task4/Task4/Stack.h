#pragma once
#include <string.h>
#include <assert.h>	// для отлавливания ошибок(исключений)


class StackBin
{
	char mem[1000];
	int index;
	int sizeEl;

public:
	StackBin(int sizeEl=4) {
		index = -1;
		this->sizeEl = sizeEl;
	}

	bool IsEmpty() {
	//	assert(index < 0);// из релиза асерты убираются. С ним можно узнавать, где иименно была ошибка в коде
		return index < 0;
	}

	bool IsFull() {
		return (index+1) * sizeEl >= 1000;
	}

	void push(void *p) {
		if (IsFull())
		{
			// ничего не делать, либо написать исключение:
			throw - 1;
		}
		index++;
		memcpy(mem + index*sizeEl, p, sizeEl);		// лучше использовать её при копировании масивов (она работает быстрее)
		
	}

	void pop(void *p) {
		if (IsEmpty())
		{
			// ничего не делать, либо написать исключение:
			throw - 2;
		}
		memcpy(p, mem + index*sizeEl, sizeEl);
		index--;		
	}

};


class  StackInt {
	StackBin * st;

public:
	StackInt() {
		st = new StackBin(sizeof(int));
	}

	bool IsEmpty() {
		return st->IsEmpty();
	}

	bool IsFull() {
		return st->IsFull();
	}

	void push(int v) {
		st->push(&v);
	}

	int pop() {
		int res;
		st->pop(&res);
		return res;
	}

	~StackInt() {
		delete st;
	}

	int operator * (){
		if (IsEmpty())
		{
			// ничего не делать, либо написать исключение:
			throw - 2;
		}
		int a = pop();
		push(a);
		return a;
	}
};


template <class T>			//шаблон
class  StackTemplate {
	StackBin * st;
public:
	StackTemplate() {
		st = new StackBin(sizeof(T));
	}
	
	bool IsEmpty() {
		return st->IsEmpty();
	}

	bool IsFull() {
		return st->IsFull();
	}

	void push(T v) {
		st->push(&v);
	}

	T pop() {
		T res;
		st->pop(&res);
		return res;
	}

	~StackTemplate() {
	delete st;
	}
};