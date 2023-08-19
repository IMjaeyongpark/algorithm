def solution(lottos, win_nums):
    
    c = 0
    z = 0
    for n in lottos:
        if n == 0:
            z+=1
        else:
            for w in win_nums:
                if w == n:
                    c+=1
                    break
    
    answer = []
    if (c+z)<=1:
        answer.append(6)
        answer.append(6)
        return answer
    else:
        answer.append(7-c-z)
    
    if c <=1:
        answer.append(6)
    else:
        answer.append(7-c)
    
    return answer
        
        