N, M = map(int, input().split())
s = list(range(N+1))
for i in range(M):
    a, b = map(int, input().split())
    s[a], s[b] = s[b], s[a]
s.pop(0)
for i in s:
    print(f'{i} ', end="")
