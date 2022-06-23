#include<stdio.h>
int main(void){
int a,b,c;
    scanf("%d",&a);
    for(int i=0;i<a;i++){
        scanf("%d\n%d",&b,&c);
        printf("%d\n",b+c);
    }
    return 0;
}