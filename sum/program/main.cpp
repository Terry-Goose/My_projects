#include <stdio.h>
#include <windows.h>

typedef double(*ptrf)(double a, double b);
typedef char *(*name)();

int main() 
{
	int count = 0;
	WIN32_FIND_DATA ffd;
	HANDLE hFile = INVALID_HANDLE_VALUE;
	ptrf pF[2];
	name pN[2];
	HMODULE p;
	int choice;
	double current = 0;
	double quantity;
	int vvod;

	hFile = FindFirstFile(L"*.dll", &ffd);
	if (hFile == INVALID_HANDLE_VALUE)
	{
		printf("not found any file\n");
		getchar();
		return 1;
	}
	printf("%S\n", ffd.cFileName);
	p = LoadLibrary(ffd.cFileName);	
	pN[count] = (name)GetProcAddress(p, "getName");
	pF[count] = (ptrf)GetProcAddress(p, "sub");
	
	if (pF[count] ==NULL)
		pF[count] = (ptrf)GetProcAddress(p, "sum");
	count = 1;

	while (FindNextFile(hFile, &ffd))
	{
		printf("%S\n", ffd.cFileName);
		p = LoadLibrary(ffd.cFileName);
		pF[count] = (ptrf)GetProcAddress(p, "sum");
		pN[count] = (name)GetProcAddress(p, "getName");
		count++;
	}
	printf("\n");
	printf("current = %f\n", current);
	for (int i = 0; i < count; i++)
	{
		printf("%d. %s\n", i, pN[i]());
	}
	printf("%d. quit\n", count);	
	vvod = scanf_s("%d", &choice);
	while (choice != count)
	{
		printf("quantity = ");
		vvod = scanf_s("%lf", &quantity);
		current = pF[choice](current, quantity);
		printf("\n");
		printf("current = %f\n", current);

		for (int i = 0; i < count; i++)
		{
			printf("%d. %s\n", i, pN[i]());
		}
		printf("%d. quit\n", count);
		vvod = scanf_s("%d", &choice);
	}
	return 0;
}