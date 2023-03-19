#include<stdio.h>
#include<time.h>

int main(){
	int piezas;
	printf("¿Cuantas piezas desea lanzar?\n");
	scanf("%i",&piezas);
	int pieza = 0;
	int i = 0;
	for(i=0;i<piezas;++i){
		pieza = LanzarPieza(pieza);
		printf("Se ha lanzado la pieza: %i\n", ++pieza);
	}
	return 0;
}

int LanzarPieza(int anterior){
	sleep(1);
	srand(time(NULL));
	int random = rand()%7;
	while(random == anterior){
		random = rand()%7;
	}
	return random;
}
