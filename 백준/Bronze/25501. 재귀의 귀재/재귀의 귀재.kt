import java.util.Scanner
import java.lang.StringBuilder

val sc = Scanner(System.`in`)

var cnt : Int = 0

fun main() {
    val sb = StringBuilder()
    val T = sc.nextLine().toInt()
    for(i in 1..T){
        var s = sc.nextLine()
        sb.append("${isPalindrome(s)} ${cnt}\n")
    }
    println(sb.toString())
}

fun recursion(s: String,l:Int,r:Int): Int {
    cnt++
    if(l>=r)return 1
    else if(s[l]!=s[r])return 0
    else return recursion(s,l+1,r-1)
}

fun isPalindrome(s:String):Int{
    cnt = 0;
    return recursion(s,0,s.length-1)
}