import Foundation

func solution(_ a:Int, _ b:Int, _ n:Int) -> Int {
    var sol = 0
    var m = n
    while a <= m {
        sol += (m/a)*b
        m = (m/a)*b+m%a
    }
    return sol
}