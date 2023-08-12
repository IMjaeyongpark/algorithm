N = int(input())
A = list(map(int, input().split()))

a = len(A)

di = [1] * a
result = 0

for i in range(a - 1, -1, -1):
    for j in range(i + 1, a):
        if A[i] < A[j] and di[i] - 1 < di[j]:
            di[i] = di[j] + 1

print(max(di))
