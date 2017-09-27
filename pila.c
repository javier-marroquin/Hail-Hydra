#include <stdio.h>
//#include <conio.h>

typedef struct {
 struct elemento* siguiente;
 char* nombre;
}elemento;

elemento* ultimo = NULL;

void agregar(elemento* _elemento); 
elemento* extraer();
void agregar(elemento* _elemento) {
_elemento->siguiente = NULL;
 if (ultimo == NULL) {
 ultimo = _elemento; }
 else { _elemento -> siguiente = ultimo; 
 ultimo = _elemento; 
	} 
 }
 elemento* extraer() { 
 if (ultimo == NULL) { 
 return NULL; 
 } 
 elemento* elemento_retorno = ultimo; 
 ultimo = elemento_retorno -> siguiente; 
 return elemento_retorno; }
 
 int main() { 
 
 elemento* uno = malloc(sizeof(elemento)); 
 elemento* dos = malloc(sizeof(elemento)); 
 elemento* tres = malloc(sizeof(elemento)); 
 elemento* cuatro = malloc(sizeof(elemento)); 
 uno->nombre = "Aprenda Java en 24 horas"; 
 dos->nombre = "Aprenda C++ rapidamente"; 
 tres->nombre = "Aprenda Visual Basic con este libro"; 
 cuatro->nombre = "Aprenda mas sobre windows 10"; 
 agregar(uno); 
 agregar(dos); 
 agregar(tres); 
 agregar(cuatro);
 
 elemento* i = extraer(); 
 while(i != NULL) { printf("%s.\n", i->nombre); 
 i = extraer();
 } 
 return 0;
 }

