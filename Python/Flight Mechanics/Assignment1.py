import sys
import math
student_no = 3+9+4+4+4+4+3

#Question A1E

#Steady level flight, trimmed, meaning no alt change, no xyz change from norm

#Variables
v = 160 #speed
altitude = 5000
p = 0.73643 # density

w = 33500 # mass
Sw = student_no*3 #Wing Area
Cw = 4 #Wing mean aerodynamic chord
St = 23.5 # Tailplane area
Ce = 2.3  #Elevator MAC
Se = 7.5 #Elevator Area
Cmacwb = -0.06 #Wing/body pitching moment coefficient about the aerodynamic centre
howbc = 1.6 # distance from wing leading edge to WB aerodynamic centre 
hc = 0.5 #Distance from wing leading edge to CG of aircraft
l = 15 # distance from wing body AC to tailplane AC
awb = 5.8 #WIng/body lift curve solve awb
a1 = 3.1  #Tailplane lift curve slope
deda = 0.45 #de/da
iT = -2 #Tailplane setting angle
b1 = -0.08 #Tailplane pitching moment curve slope
b2 = -0.05 #Elevator pitching moment curve slope
b3 = -0.1 #Elevator tab pitching moment curve slope
gE = 2 #Elevator to stick gearing

output = "Clw | {}\nClt | {}"
#find cl
lift = w
Clw = math.sqrt((w*9.81*math.cos(358))/(0.5*p*v**2*Sw))
Clt = math.sqrt(w/(0.5*p*v**2*St))
print(output.format(Clw, Clt))
