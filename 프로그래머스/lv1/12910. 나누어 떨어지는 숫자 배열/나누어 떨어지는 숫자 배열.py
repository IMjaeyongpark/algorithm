def solution(arr, divisor):
    return list(sorted([n for n in arr if n%divisor==0])) or [-1]