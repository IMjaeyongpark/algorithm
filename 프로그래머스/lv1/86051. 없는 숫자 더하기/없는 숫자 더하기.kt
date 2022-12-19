class Solution {
    fun solution(numbers: IntArray): Int {
        var answer: Int = 0
        var check = BooleanArray(10)
        for(idx in numbers){
            check[idx] = true
        }
        for(idx in 0..9){
            if(!check[idx]){
                answer+=idx
            }
        }
        return answer
    }
}