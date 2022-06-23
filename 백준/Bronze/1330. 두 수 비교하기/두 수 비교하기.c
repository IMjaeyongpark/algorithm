#include<stdio.h>
int main(void){
    int a,b;
    scanf("%d\n%d",&a,&b);
    if(a<b)printf("<");
    else if(a>b)printf(">");
    else printf("==");
    return 0;
}