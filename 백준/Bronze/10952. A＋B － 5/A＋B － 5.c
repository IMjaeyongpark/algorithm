#include<stdio.h>

int main(void){
int a,b;
    while(1){
        scanf("%d\n%d",&a,&b);
        if(a==0&&b==0)return 0;
        printf("%d\n",a+b);
    }
}