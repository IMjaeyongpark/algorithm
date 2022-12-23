import Foundation

func solution(_ price:Int, _ money:Int, _ count:Int) -> Int64{
    var answer:Int64 = -1
    
    answer = Int64((count + 1 )*count/2*price - money) 
    
    if answer<0 {
        return 0
    }
    
    return answer
}