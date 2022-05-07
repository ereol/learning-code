n = 1:1:365;
p(n) = 1 - exp(-n.^2/730);

figure(1)
plot(n,p)
xlabel('Number of People')
ylabel('Probability')
