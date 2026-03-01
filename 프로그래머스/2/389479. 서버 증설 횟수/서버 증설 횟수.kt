import java.util.*

class Solution {
    fun solution(players: IntArray, m: Int, k: Int): Int {
        var answer: Int = 0
        var curServer: Int = 0 //현재 시간의 서버 수
        val plusServer: Queue<Int> = LinkedList() //증설된 서버 수
        val time: Queue<Int> = LinkedList() //추가된 서버의 유효 시간
        
        for(i in 0..players.size - 1){
            //유효시간이 지난 서버 반납
            if(time.peek() == i){
                time.poll()
                curServer -= plusServer.poll()
            }
            //현재 시간에 필요한 서버 수
            val needServer: Int = players[i] / m
           
            //서버 증설
            if(needServer > curServer){
                plusServer.add(needServer - curServer)
                time.add(i + k)
                answer += (needServer - curServer)
                
                curServer = needServer
            }
        }
        
        return answer
    }
}