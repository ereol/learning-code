%% WEEK 5



%% for-loops
%clear, clc
%while 1 
%    disp('Forever Loop!');
%end

%% Activity: Plotting Discontinuous Function
clear,clc

x = -5:0.1:30; % our mail
N = length(x); % type of mail
f = zeros(1, N); % street name

for k = 1:N
    if x < 0
        f(k) = 10;
    elseif 0 <= x && x <= 9
        f(k) = (10 * x) + 10;
    elseif 9 < x
       f(k) = (15 * sqrt(4 * x)) + 10;
    end

    MyArray = x;

figure(1), plot(x, f)

end

%% Example: Nested Loop

clear, clc
 myImage = [1 2 3 4; 2 4 6 8; 3 6 9 12; 4 8 12 16];
[rows, cols] = size(myImage);

 for k = 1:rows
     for b = 1:cols
        disp(myImage(k, b))
        disp('-----------------')
     end
 end

 %% Activity: Bank Account Balance

 clear, clc

b = 10000:10000:1000000;
y = 0:1:100;

if b == 1000000
    disp(y)
else
 while b < 1000000 
       b = 10000 + (b*(6/100));
       y = y + 1;
 end 
end   


%% Module 2 Practice
clear, clc

function dates = dategen(N)

months = randi(12, N, 1);
days = zeros(N, 1);
% put your for-loops and if-statements

dates = [days, months];
 

% for k = 1:10
%     if (months(k) == 2)
%         disp('this month has 28 days')
%     elseif (months(k) == 3)
%         disp('this month has 31 days')
%     else
%     end
end






%% Activity: A Comma Remover























