#include<stdio.h>

int main(){
    int N;
    scanf("%d",&N);
    int c;
    scanf("%d",&c);
    int count=0;
    int num=0;
    for(int i=1;i<=N;i++){
if(N%i==0){
    count++;
        if(count==c){
            num=i;
            break;
        }
}
    }
    printf("%d",num);
}