    #include<stdio.h>
    int main(void){
    int A,B,C;
    scanf("%d\n%d\n%d",&A,&B,&C);
    printf("%d\n",(A+B)%C);
    printf("%d\n",((A%C)+(B%C))%C);
    printf("%d\n",(A*B)%C);
    printf("%d\n",((A%C)*(B%C))%C);
    return 0;
}