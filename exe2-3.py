import sys

def calculaFatorial(indice):
            if indice == 1:
                return(1)
            else:
                return(indice * (calculaFatorial(indice -1)))

def alteraSinal(indice):
    if indice % 2 == 0:
        return(-1)
    else:
        return(1)

def calculaC(n):
    if n == 1:
        return(1)
    else:
        return((alteraSinal(n)*(1/calculaFatorial((n-1)*2))) + calculaC(n -1))


print(calculaC(30.0))
