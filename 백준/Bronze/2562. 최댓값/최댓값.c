#include<stdio.h>

int main(void){
int a[9],b=0;
    for (int i=0;i<9;i++){
        scanf("%d",&a[i]);
        if(b<a[i])b=a[i];
    }
    for(int k=0;k<9;k++){
        if(b==a[k])printf("%d\n%d",b,k+1);
    }
}