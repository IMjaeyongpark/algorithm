import java.util.Scanner

val sc = Scanner(System.`in`)

fun main() {

    println(MaxSearch(sc.nextInt(), sc.nextInt()))

}

fun MaxSearch(N: Int, K: Int): Int {
    var max: Int = Integer.MIN_VALUE

    val Arr = Array(N) { 0 }

    for (i in 0..N - 1) {
        Arr[i] = sc.nextInt()
    }

    for (i in 0..N - K) {
        var sum: Int = 0
        for (j in i..i + K -1) {
            sum += Arr[j]
        }
        if (max < sum) {
            max = sum
        }
    }

    return max
}