#include<stdio.h>
int main(void){
int a[10],b=0,c,k;
    for(int i=0;i<10;i++){
        scanf("%d",&c);
        a[i]=c%42;
    }
    for(int i=0;i<10;i++){
        for(k=0;k<i;k++){
            if(a[k]==a[i]){
                k=0;
                break;
            }
        }
        if(k==i)b++;
    }
    printf("%d",b);
    return 0;
}