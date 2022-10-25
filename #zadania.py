#zadania
#zad1
a = int(input('wpisz liczbę'))
b = int(input('wpisz liczbę'))
if (a+b%2==0):
    print("TAK")
else:
    print('NIE')
#zad2
from math import sqrt
a = int(input("wpisz liczbę"))
b = int(input("wpisz liczbę"))
if (a+b/2) > sqrt(a*b):
    print("tak")
else:
    print("nie")
#zad3
    print("podaj 3 liczby całkowite")
a = int(input("wpisz liczbe: "))
b = int(input("wpisz liczbę: "))
c = int(input("wpisz liczbę: "))
if (a == b and a == c and a == c):
  print("wszystkie liczby są sobie równe")
elif(a == b and b !=c and a!=c):
  print('równe są sobie liczby pierwsza i druga')
elif(a == c and b!=c and a!=b):
  print('równe są sobie liczby pierwsza i trzecia')
elif(b == c and a!=c and b!=a):
  print('równe są sobie liczby druga i trzecia')   
else:
  print("żadna liczba nie jest sobie równa")

