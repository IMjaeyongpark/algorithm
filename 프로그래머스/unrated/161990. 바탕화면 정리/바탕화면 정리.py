def solution(wallpaper):
    a = [[] for _ in range(len(wallpaper))]
    x = []
    y = []
    for i in range(len(wallpaper)):
        for j in range(len(wallpaper[i])):
            if wallpaper[i][j] == '#':
                x.append(j)
                y.append(i)

    x.sort()
    y.sort()
    return [y[0], x[0], y.pop() + 1, x.pop() + 1]