def solution(lottos, win_nums):
    
    z = lottos.count(0)
    c = 0
    
    for n in lottos:
        if n in win_nums:
            c += 1
    answer = []
    if z+c <=1:
        return [6,6]
    else:
        answer.append(7-z-c)
    
    if c <=1:
        return [answer[0],6]
    else:
        return [answer[0],7-c]