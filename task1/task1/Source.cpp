#include <stdio.h>

void* PushInt(void *ptr, int val)
{
	char type = 1;
	*(char *)ptr = type;
	ptr = (char *)ptr + 1;
	*(int *)ptr = val;
	ptr = (int *)ptr + 1;
	type = 0;
	*(char *)ptr = type;

	return ptr;
}

void* PushDouble(void *ptr, double val)
{
	char type = 2;
	*(char *)ptr = type;
	ptr = (char *)ptr + 1;
	*(double *)ptr = val;
	ptr = (double *)ptr + 1;
	type = 0;
	*(char *)ptr = type;

	return ptr;
}

void* GetType(void *ptr, char &type)
{
	type = *(char *)ptr;
	ptr = (char *)ptr + 1;
	return ptr;
}

void* PopInt(void *ptr, int &val)
{
	val = *(int *)ptr;
	ptr = (int *)ptr + 1;
	return ptr;
}

void* PopDouble(void *ptr, double &val)
{
	val = *(double *)ptr;
	ptr = (double *)ptr + 1;
	return ptr;
}

void main()
{
	char buff[100];
	char type = 0;
	int val1;
	double val2;
	buff[0] = 0;
	void *ptr = buff;
	ptr = PushInt(ptr, 10);
	ptr = PushInt(ptr, 20);
	ptr = PushDouble(ptr, 3.5);

	ptr = buff;
	ptr = GetType(ptr, type);

	while (type!=0)
	{
		if (type == 1)
		{
			ptr = PopInt(ptr, val1);
			printf("%d\n", val1);
		}
		else
			if (type == 2)
			{
				ptr = PopDouble(ptr, val2);
				printf("%f\n", val2);
			}
		ptr = GetType(ptr, type);
	}
	getchar();
}