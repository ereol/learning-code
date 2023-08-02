import sys
import numpy as np
import matplotlib.pyplot as plt
import math
row = 1
text = "Velocity: {:.2f}\n Cl: {:.2f}\n Cd: {:.2f}\n L/D: {:.2f}\n Tr: {:.2f}\n Round {:.2f}\n"
text2 = "Cl: {}\n Cd: {}\n L/D: {}\n Tr: {}\n\n"
S = 47
AR = 6.5
e = 0.87
Cd0 = 0.032
W = 103047
T = 402918 #one engine 
p0 = 1.225
p1 = 7.3643*10**-1
#----------array-----------#
CL_array = []
CD_array = []
LD_array = []
Tr_array = []
V_array = []
Pr_array = []
Pa_array = []

#functions to find Cl Cd
def findCL(w,p,v,s):
    x = w/(0.5*p*(v**2)*s)
    return x

def findCd(cd0, cl, e, ar):
    x = cd0 + ((cl**2)/(3.1415*e*ar))
    return x


#looping to get all Tr for each velocity m/s 100->320
#0 MSL
print("[-- MSL = 0m --]")
for V in range(20, 100, 10):
    Cl = findCL(W,p0, V, S)
    Cd = findCd(Cd0, Cl, e, AR)
    LD = Cl/Cd
    Tr = W/LD
    Pr = (Tr*V)/1000
    Pa = (2*T*100)/1000

    Cl =round(Cl, 3)
    Cd = round(Cd, 3)
    LD = round(LD, 3)
    Tr = round(Tr, 3)
    Pr = round(Pr, 3)
    Pa = round(Pa, 3)

    CL_array.append(Cl)
    CD_array.append(Cd)
    LD_array.append(LD)
    Tr_array.append(Tr)
    V_array.append(V)
    Pr_array.append(Pr)
    Pa_array.append(Pa)

    print(text.format(V, Cl, Cd, LD, Tr, row))
    row = row + 1

for V in range(100, 340, 20):
    Cl = findCL(W,p0, V, S)
    Cd = findCd(Cd0, Cl, e, AR)
    LD = Cl/Cd
    Tr = W/LD
    Pr = (Tr*V)/1000
    Pa = (2*T*100)/1000

    Cl =round(Cl, 3)
    Cd = round(Cd, 3)
    LD = round(LD, 3)
    Tr = round(Tr, 3)
    Pr = round(Pr, 3)
    Pa = round(Pa, 3)

    CL_array.append(Cl)
    CD_array.append(Cd)
    LD_array.append(LD)
    Tr_array.append(Tr)
    V_array.append(V)
    Pr_array.append(Pr)
    Pa_array.append(Pa)

    print(text.format(V, Cl, Cd, LD, Tr, row))
    row = row + 1
print(text2.format(CL_array, CD_array, LD_array, Tr_array))

Cdi = Cd0
Cli = math.sqrt(Cdi*3.14159*e*AR)
Vtrmin = math.sqrt(W/(0.5*p0*S*Cli))
Trmin = 2*(0.5*p0*(Vtrmin**2))*S*Cdi
print("\n [--------------]\n")



fig = plt.figure()
ax1 = fig.add_subplot(2, 2, 1)
ax1.set_title("V vs Tr @ 0m MSL")
ax1.plot(V_array, Tr_array, label = "0m MSL", marker = 'o')
ax1.plot(Vtrmin, Trmin, marker = 'o', color = 'r', label = 'Trmin')
ax1.annotate('Trmin', (Vtrmin, Trmin))
ax1.set_xlabel("Freestream Velocity, V\n (m/s)")
ax1.set_ylabel("Thrust Required, Tr\n (N)")

ax3 = fig.add_subplot(2, 2, 3)
ax3.set_title("V vs Power Required @ 0m MSL")
ax3.plot(V_array, Pr_array, marker = 'o')
ax3.set_xlabel('Freestream Velocity, V\n (m/s)')
ax3.set_ylabel('Power Required, kW')


#reset
row = 1

CL_array = []
CD_array = []
LD_array = []
Tr_array = []
V_array = []
Pr_array = []
Pa_array = []



#5000m MSL
print("[-- MSL = 5000m --]")
for V in range(20, 100, 10):
    Cl = findCL(W,p1, V, S)
    Cd = findCd(Cd0, Cl, e, AR)
    LD = Cl/Cd
    Tr = W/LD
    Pr = (Tr*V)/1000
    Pa = (2*T*100)/1000
    Cl =round(Cl, 3)
    Cd = round(Cd, 3)
    LD = round(LD, 3)
    Tr = round(Tr, 3)
    Pr = round(Pr, 3)
    Pa = round(Pa, 3)

    CL_array.append(Cl)
    CD_array.append(Cd)
    LD_array.append(LD)
    Tr_array.append(Tr)
    V_array.append(V)
    Pr_array.append(Pr)
    Pa_array.append(Pa)

    print(text.format(V, Cl, Cd, LD, Tr, row))
    row = row+1

for V in range(100, 340, 20):
    Cl = findCL(W,p1, V, S)
    Cd = findCd(Cd0, Cl, e, AR)
    LD = Cl/Cd
    Tr = W/LD
    Pr = (Tr*V)/1000
    Pa = (2*T*100)/1000
    Cl =round(Cl, 3)
    Cd = round(Cd, 3)
    LD = round(LD, 3)
    Tr = round(Tr, 3)
    Pr = round(Pr, 3)
    Pa = round(Pa, 3)

    CL_array.append(Cl)
    CD_array.append(Cd)
    LD_array.append(LD)
    Tr_array.append(Tr)
    V_array.append(V)
    Pr_array.append(Pr)
    Pa_array.append(Pa)

    print(text.format(V, Cl, Cd, LD, Tr, row))
    row = row+1
print(text2.format(CL_array, CD_array, LD_array, Tr_array))
print("\n [--------------]\n")

Cdi = Cd0
Cli = math.sqrt(Cdi*3.14159*e*AR)
Vtrmin = math.sqrt(W/(0.5*p1*S*Cli))
Trmin = 2*(0.5*p1*(Vtrmin**2))*S*Cdi





ax2 = fig.add_subplot(2, 2, 2)
ax2.plot(V_array, Tr_array, label = "5000m MSL", marker = 'o')
ax2.plot(Vtrmin, Trmin, marker = 'o', color = 'r', label = 'Trmin')
ax2.annotate('Trmin', (Vtrmin, Trmin))
ax2.set_title("V vs Tr @ 5000m MSL")
ax2.set_xlabel("Freestream Velocity, V")
ax2.set_ylabel("Thrust Required, Tr")

ax4 = fig.add_subplot(2, 2, 4)
ax4.set_title("V vs Power Required @ 5000m MSL")
ax4.plot(V_array, Pr_array, marker = 'o')
ax4.set_xlabel('Freestream Velocity, V\n (m/s)')
ax4.set_ylabel('Power Required, kW')

plt.show()

input('Press any key to STOP')




