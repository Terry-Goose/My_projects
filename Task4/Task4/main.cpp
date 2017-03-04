#include <stdio.h>
#include "Stack.h"


int main()
{
	StackBin st(sizeof(int));
/*
	StackTemplate<int> st_i;
	st_i.push(10);
	printf(" %d\n", st_i.pop());
*/
	//StackTemplate<double> st_d;
	//st_d.push(10);
	//printf(" %lf\n", st_d.pop());	

	//int val;
	//// отлавливание исключений
	//try {
	//	st.pop(&val);
	//} 
	//catch (int err)//... - любое исключение, второй вариант позволяет отлавливать сами ошибки, возвращая их код
	//{
	//	printf("error code %d\n", err);
	//}

	StackInt st_int;
	st_int.push(10);

	try {
		printf("%d\n", *st_int);
		printf("%d\n", st_int.pop());
	} 
	catch (int err)//... - любое исключение, второй вариант позволяет отлавливать сами ошибки, возвращая их код
	{
		printf("error code %d\n", err);
	}


	return 0;
}