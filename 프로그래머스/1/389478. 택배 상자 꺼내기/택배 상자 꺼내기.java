class Solution {
    public int solution(int n, int w, int num) {
        
        int numRow = (num - 1) / w;
        int col = num % w;
        col = (col == 0) ? w : col;
        if(numRow % 2 != 0) col = w - col + 1;
                
        int lastRow = (n - 1) / w;
        int lastCount = n % w;
        lastCount = (lastCount == 0) ? w : lastCount;
        
        int answer = lastRow - numRow ;
        
        if(lastRow % 2 == 0 && lastCount >= col ||
           lastRow % 2 != 0 && (w - lastCount) < col){
            answer++;
        }
        
        return answer;
    }
}