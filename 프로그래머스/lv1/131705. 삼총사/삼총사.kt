class Solution {
    
    fun solution(number: IntArray): Int {
        var answer: Int = 0
        
        lateinit var Bt: (cnt: Int, sum: Int, cur: Int) -> Unit
        
        Bt ={cnt: Int, sum: Int, cur: Int->
            if(cnt == 3){
                if(sum == 0)
                    answer++
            }
            else {
                for(i in cur..number.size - 1){
              Bt(cnt+1,sum+number[i],i+1)      
                }
            }
        }
        
        Bt(0,0,0)
        
        return answer
    }
    
}