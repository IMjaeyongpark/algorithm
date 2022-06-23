#include<stdio.h>
int main(void){
    int a,b,c;
    scanf("%d\n%d\n%d",&a,&b,&c);
    if(b+c>=60){
        b=b+c;
        while(b>=60){
            b-=60;
            a++;
        }
        while(a>23)a-=24;
        printf("%d %d",a,b);
}
    else printf("%d %d",a,b+c);
    return 0;
}