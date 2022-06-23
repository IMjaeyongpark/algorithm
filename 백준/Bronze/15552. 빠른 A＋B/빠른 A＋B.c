#include<stdio.h>
int main(void){
    int a,b,c;
    scanf("%d",&c);
    for(int i=0;i<c;i++){
        scanf("%d\n%d",&a,&b);
        printf("%d\n",a+b);
    }
    return 0;
}