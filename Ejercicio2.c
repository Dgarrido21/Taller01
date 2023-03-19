#include<stdio.h>

int main(){
	int numero;
	printf("Inserte un numero\n");
	scanf("%i", &numero);
	int res = numero * 100 / 2 + 50 - 10;
	printf("%i * 100 / 2 + 50 - 10 = %i",numero, res);
}
