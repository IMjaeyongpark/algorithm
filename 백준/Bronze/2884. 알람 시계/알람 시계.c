#include<stdio.h>
int main(void){
    int a,b;
    scanf("%d\n%d",&a,&b);
    if(b-45<0){
         b-=45;
         b=60+b;
        if(a>0){
            printf("%d %d",a-1,b);
        }
        else {
            printf("23 %d",b);
             }
    }
    else printf("%d %d",a,b-45);
    return 0;
}