#include<stdio.h>

int main(){
    int N;
    scanf("%d",&N);
    long int p1=0,p2=1,p3;
    int i;
    for( i=0;i<N-1;i++){
        p3=p2;
        p2=p2+p1;
        p1=p3;
    }
    printf("%ld",p2);
}