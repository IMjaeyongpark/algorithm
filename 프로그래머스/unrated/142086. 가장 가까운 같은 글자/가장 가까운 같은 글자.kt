class Solution {
    fun solution(s: String): IntArray {
        var answer: IntArray = IntArray(s.length)
        for(i in 0..s.length-1){
            var check = true
            for(j in i-1 downTo 0){
                if(s[i]==s[j]){
                    check = false
                    answer[i]=i-j
                    break
                }
            }
            if(check)answer[i]=-1
        }
        return answer
    }
}