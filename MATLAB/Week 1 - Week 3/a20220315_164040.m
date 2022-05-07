%% Intro Part 1
accel = 1.5;
mass = 20;
vel_light = 2.99792e8; %Scientific Notation
force = mass*accel;

% Creating Character Array (string)
label_N = 'North';
label_S = 'South';
label_E = 'East';
label_W = 'West';

% Convert a number to character array
MyNum = 225; %Number stored as a double
MyNumStr = num2str(MyNum); %use nùm2str (number 2 string) to convert double to characters

%% Display

% input() is used to obtain an input from user on Command Line.
x = input ('Please enter a number');
%or
str0 = input('Please enter a word', 's');


%{disp() function is used to display a variable or text string on the Command Line. The syntax for this could be: disp(x)}
% To output a text string to the command line you could use:
disp('Hello World!')
str1 = ['The answer is: ' num2str(x)];
disp(str1)

% fprintf() is similar to disp() but allows more control on format.
fprintf('%1.2f\n' , x)

% Numeric Arrayss (similar to matrices)
speed = [0 1 2.6 3.11 7]; %Horizontal Array
speed1 = [ 0; 1; 2.6; 3.11; 7;]; %Vertical Array

%% Array

%Monotonically Increasing Array
% x = start:increment:end; %Monotonically increasing array
% time 0:0.1:10; 0-10 seconds
% time = linspace(0,10,101) 

t = 0:0.1:5-0.1;
x = 2*sin(2*pi*t);

figure(1) %Generates Figure Window
plot(t, x, 'g') %plot() plots data x at time with t. 'g' changes graph colour

%Labels Colour
xlabel('time')
ylabel('Y of X')

%%  Import Data
clear

[num, txt, raw] = xlsread("Buildings.xlsx");

[x, fs] = audioread("gameover.wav");
soundsc(x, 30000)






%% Activity 1

Force = 1000;
Mass = 20;
Accel = Force / Mass; 

%% Activity 2

Height = 9;
Base = 10;
T_Area = 1/2 * Base * Height; 
disp('')
disp('Your Triangle Area Calculator')
b = input('Please enter a Base value: ');
h = input('Please enter a Height Value: ');
b_base = 0.5 * b * h;

str2 = ['Your Area is: ' num2str(b_base)];
disp(str2)

%% Activity 3

Adjacent = 13;
Opposite = 4;


A_Angle = (180 * tan(Opposite / Adjacent)) / pi;

%% Activity 4


x = 0:0.01:5;

%y = sin(6 * pi * x - (pi / 2));

%y = exp(-3*x); % exp() - everything in power must go in bracket

y = log(0.1*x);

figure(1)
plot(x, y, 'r')
xlabel('a_T_i_m_e', 'FontSize', 18)
ylabel('sin_\Theta', 'FontSize',14)

%% Activity 5 Import Excel

clear

[num, text, raw] = xlsread("Buildings.xlsx");


figure(1)

plot(x(:,1), x(:,2), '*');












