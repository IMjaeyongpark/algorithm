class Solution {
    public int solution(int n, int w, int num) {
        
        int num_floor = (num - 1) / w;
        int a = num % w;
        a = (a == 0) ? w : a;
        if(num_floor % 2 != 0) a = w - a + 1;
        
        
        int n_floor = (n - 1) / w;
        int b = n % w;
        b = (b == 0) ? w : b;
        
        int answer = n_floor - num_floor ;
        
        if(n_floor % 2 == 0 && b >= a ||
           n_floor % 2 != 0 && (w - b) < a){
            answer++;
        }
        
        return answer;
    }
}