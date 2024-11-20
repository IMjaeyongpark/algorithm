def solution(k, tangerine):
    
    cnt = {}
    a = set()
    
    for val in tangerine:
        if val in a:
            cnt[val] = cnt[val] + 1
        else:
            cnt[val] = 1
            a.add(val)
    
    c = []
    for key, v in cnt.items():
        c.append(v)
        
    c.sort()
    c.reverse()
    
    answer = 0
    cur = 0
    for i in c:
        cur = cur + i
        answer = answer + 1
        if cur >= k:
            break
    
    return answer