#include<stdio.h>
int main(void){
int a;
    scanf("%d",&a);
    for(int i=1;i<=a;i++){
        for(int k=1;k<=i;k++)printf("*");
        printf("\n");
    }
    return 0;
}