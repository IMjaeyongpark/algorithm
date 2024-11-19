from collections import deque

def solution(x, y, n):
    queue = deque([(x,0)])
    visited = set()
    
    while queue:
        cur, cnt = queue.popleft()
        
        if cur == y:
            return cnt
        
        if cur in visited:
            continue
        
        visited.add(cur)
        
        if cur + n <= y:
            queue.append([cur + n, cnt + 1])
        if cur * 2 <= y:
            queue.append([cur * 2, cnt + 1])
        if cur * 3 <= y:
            queue.append([cur * 3, cnt + 1])
        
    
    return -1