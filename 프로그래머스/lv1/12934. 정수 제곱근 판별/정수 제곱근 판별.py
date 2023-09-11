def solution(n):
    return (n**(1/2)+1)**2 if n**(1/2) - int(n**(1/2))==0 else -1