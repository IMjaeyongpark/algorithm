def solution(s):
    num = s.split()
    num = list(map(int,num))
    num.sort()
        
    return f'{num[0]} {num[len(num)-1]}'