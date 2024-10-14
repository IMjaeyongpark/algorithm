class Solution {
    public int solution(int[][] sizes) {
        
        int w = 0;
        int h = 0;
        
        for(int[] tmp : sizes){
            int tmp1 = tmp[0] > tmp[1]? tmp[0] : tmp[1];
            int tmp2 = tmp[0] < tmp[1]? tmp[0] : tmp[1];
            w = w > tmp1 ? w : tmp1;
            h = h > tmp2 ? h : tmp2;
        }
        int answer = w * h;
        return answer;
    }
}