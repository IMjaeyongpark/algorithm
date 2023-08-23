def solution(n):
    answer = n
    for i in range(1,int(n/2)+1,1):
        if n%i==0:
            answer+=i
    return answer