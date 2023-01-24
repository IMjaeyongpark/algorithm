class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int cnt=0;
        int win=0;
        for(int num:lottos){
            if(num==0){
                cnt++;
                continue;
            }
            for(int win_num:win_nums){
                if(num==win_num){
                    win++;
                    continue;
                }
            }
        }
        answer[0]=7-cnt-win;
        answer[1]=7-win;
        for(int i=0;i<2;i++){
            if(answer[i]==7)
                answer[i]--;
        }
        return answer;
    }
}