class Solution {
    public int solution(int[] schedules, int[][] timelogs, int startday) {
        
        int answer = 0;
        
        for(int i = 0;i < schedules.length;i++){
            int strat_min = trans_time(schedules[i]) + 10;
            int cur_sd = startday;
            
            boolean late_check = false;
            
            for(int j = 0;j < 7; j++){
                
                if(cur_sd % 7 == 0 || cur_sd % 7 == 6);
                else if(trans_time(timelogs[i][j]) > strat_min){
                    late_check = true;
                    break;
                }
                cur_sd++;
            }
            
            if(!late_check)answer++;
            
        }
        
        
        return answer;
    }
    
    //시간 변환
    public int trans_time(int time){
        
        int hour = time / 100;
        int minute = time % 100;
        
        return minute + hour * 60;
    }
}