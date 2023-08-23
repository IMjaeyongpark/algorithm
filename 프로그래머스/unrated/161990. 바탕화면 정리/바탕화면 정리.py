def solution(wallpaper):
    x = []
    y = []
    for i in range(len(wallpaper)):
        for j in range(len(wallpaper[i])):
            if wallpaper[i][j] == '#':
                x.append(j)
                y.append(i)

    x.sort()
    y.sort()
    return [min(y), min(x), max(y) + 1, max(x) + 1]