class Solution {
    fun solution(arr: IntArray): Double {
        var answer:Double = 0.0
        var sum = 0
        for(num in arr){
            sum += num
        }
        answer = sum.toDouble()/arr.size.toDouble()
        
        return answer
    }
}