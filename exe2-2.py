import sys

def multiplicacaoRecursiva(a, b):
    if a == 1 :
        return(b)
    else:
        return(b + multiplicacaoRecursiva(a -1, b))

print(multiplicacaoRecursiva(5,6))
