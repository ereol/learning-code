%% PRACTICAL EXERCISE 1: Introduction to MATLAB
clear, clc

%% Part 1 (week 3): The Physics of Projectile Motion
g = 9.8; %acceleration of gravity meters per second second.
d = 183; %canyon distance
a = pi/4; %angle of launch

v0 = sqrt((d * g) / sin(2 * a));
vkmph = v0 * 3.6;

fprintf('The intial velocity is %.2f m/s\n', v0)
fprintf('The intial velocity is %.2f km/h\n', vkmph)


%% Part 2 (week 4): Change Initial Height
y = 0;
g = 9.81; % gravity m/s^-2
d = 183; % canyon distance 
a = pi/4; % angle of launch 45 DEGREES
v01 = 125/3.6; %initial velocity

t = d / ( cos(a) * v01 ); 
H = y - v01 * t * sin(a) + (1/2) * g * t.^2;

t_all=0:0.1:9;                  
%                      graphing 35 angle
x35 = v01 * t_all * cos(35*pi/180);    
y35 = H + v01 * t_all * sin(35*pi/180) - (1 / 2) * g * t_all.^2;
%                      graphing 45 angle
x45 = v01 * t_all * cos(45*pi/180);
y45 = H + v01 * t_all * sin(45*pi/180) - (1 / 2) * g * t_all.^2;
%                      graphing 55 angle
x55 = v01 * t_all * cos(55*pi/180);
y55 = H + v01 * t_all * sin(55*pi/180) - (1 / 2) * g * t_all.^2;

% Graphing display:
figure(1);
plot(x35,y35);
hold on;
plot(x45,y45);
hold on;
plot(x55,y55);
hold on;
title('Model of projectile motion with a non-zero height')
strxlabel = ('x displacement in meters (m)');
strylabel = ('y - Height displacement in meters (m)');
legend('35 Degrees', '45 Degrees', '55 Degrees');
axis([0 200 0 200])
xlabel(strxlabel)
ylabel(strylabel)
figure(2)
subplot(1,1,1), plot(x35,y35)
title('Model of projectile motion with a non-zero height at a launch angle of 35 DEGREES')
legend('35 Degrees')
xlabel(strxlabel)
ylabel(strylabel)
axis([0 200 0 150])

