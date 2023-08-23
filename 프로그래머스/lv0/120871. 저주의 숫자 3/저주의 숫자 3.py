def solution(n):
    cur = 1
    while cur <= n:
        if cur % 3 == 0 or '3' in str(cur):
            n += 1
        cur += 1
    return n
