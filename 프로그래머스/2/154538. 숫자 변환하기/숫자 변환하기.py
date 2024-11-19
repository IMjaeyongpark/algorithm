from collections import deque

def solution(x, y, n):
    # BFS를 위한 큐 초기화
    queue = deque([(x, 0)])  # (현재 값, 연산 횟수)
    visited = set()  # 방문한 숫자를 기록

    while queue:
        current, count = queue.popleft()

        # y에 도달하면 연산 횟수 반환
        if current == y:
            return count

        # 방문한 숫자는 스킵
        if current in visited:
            continue
        visited.add(current)

        # 가능한 연산을 모두 큐에 추가
        if current + n <= y:
            queue.append((current + n, count + 1))
        if current * 2 <= y:
            queue.append((current * 2, count + 1))
        if current * 3 <= y:
            queue.append((current * 3, count + 1))

    # y에 도달할 수 없으면 -1 반환
    return -1
