#include<stdio.h>
int main(void){
int n,x,k;
    scanf("%d\n%d",&n,&x);
    for(int i=0;i<n;i++){
        scanf("%d",&k);
        if(k<x)printf("%d\n",k);
    }
    return 0;
}