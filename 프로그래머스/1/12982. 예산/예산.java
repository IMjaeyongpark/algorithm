import java.util.Arrays;

class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        Arrays.sort(d);
        for(int b : d){
            if(budget >= b){
                budget -= b;
                answer ++;
            }else break;
        }
        return answer;
    }
}