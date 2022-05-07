
clear, clc
%% Import Barbara

clear, clc

X = imread("barbara.png");
X(1:20:512,  :) = 255; % Every 20th Row
X(:, 1:20:512) = 255;


figure(1)
imshow(X)

%% Import Barbara - Covered Face

% a = 338 15 b = 419 181

clear, clc

X = imread("barbara.png");
X(338:15, 419:181) = 0;

figure(1), imshow(X)

%% The if-Statement

if condition
    statement;
end

if (condition1) && (condition2) % condition1 AND condition2
    statement;
end

if (condition1) || (condition2) % condition1 AND/OR condition2
    statement;
end


X > Y % is X greather than Y?

X == Y % is X EQUALS Y?

X <= Y % is X EQUALS or LESSER than Y

%% Activity: The if-Statement (with Else)

clear, clc

% randi() = random integer, randi(50) from 0-50 but never greater

x = randi(100.);
y = (num2str(x));
a = ['You passed with ' y '%'];
b = ['You failed with ' y '%'];

if x > 50
    disp(a);
else
    disp(b);
end


%% Activity: if-elseif-else Statement
clear, clc


x = randi(100);
y = (num2str(x));
a = ['You passed with ' y '%'];
b = ['You have credit with ' y '%'];
c = ['You have Disctinction with ' y '%'];
d = ['You have HD with ' y '%'];
e = ['You have failed with ' y '%'];

if x > 50 && x <=60 
   disp(a);
elseif x > 60 && x <=70
       disp(b);
elseif x > 70 && x <=80
     disp(c);
elseif x > 80 && x <= 100
      disp(d);
else
     disp(e);
end



%% Activity: Switch Statement
clear, clc

disp('Welcome to Friction Program')
disp('')
disp('Please enter a number to continue')
z = input(':');
clc
disp('1. Ice')
disp('2. Teflon')
disp('3. Polyethylene')
disp('4. Brass')
disp('5. Copper')
disp('6. Aluminium')
disp('7. Steel')
disp('')
disp('PLEASE INSERT THE NUMBER OF YOUR PREFERRED MATERIAL.')
disp('WORDS ARE NOT ACCEPTED.')
x = input(':');

switch x
    case 1
        disp('Ice: 0.03N'), y = 0.03;
    case 2
        disp('Teflon: 0.04N'), y = 0.04;
    case 3
        disp('Polyethylene: 0.2N'), y = 0.2;
    case 4
        disp('Brass: 0.4N'), y = 0.4;
    case 5
        disp('Copper: 0.53N'), y = 0.53;
    case 6
        disp('Aluminium: 0.61N'), y = 0.61;
    case 7
        disp('Steel: 0.74N'), y = 0.74;
    otherwise
        disp('The option is invalid!')

end

g = 9.8;

clc
disp('Please enter your materials weight in KILOGRAMS.')

m = input(':');
F = y * m * g;
H = num2str(F);
P = [H, 'N'];
clc
disp('THIS IS YOUR FRICTION IN FORCE NEWTONS.')
disp(P);
disp('')







