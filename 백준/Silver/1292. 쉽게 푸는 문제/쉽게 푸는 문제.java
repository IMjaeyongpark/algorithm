import java.util.Scanner;
public class Main {
	public static void main(String[] args) {
		Scanner in=new Scanner(System.in);
		int s = in.nextInt();
		int e = in.nextInt();
		int a=1,sum=0,count=0,sum2=0;
		while(count<e) {
			for(int i=0;i<a;i++) {
				if(count==e)break;
				sum+=a;
				count++;
				if(count==s-1)sum2=sum;
				
			}
			a++;
		}
		System.out.print(sum-sum2);
}
}