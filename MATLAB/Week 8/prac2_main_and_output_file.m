clear,clc
image1=imread("coloredChips.png");
figure(1)
imshow(image1)
disp('Select one clour from the following colours:')
disp('r for red')
disp('g for green')
disp('b for blue')
disp('y for yellow ')
disp('c for cyan')
disp('m for magenta')
x= input('what colours you want to change \n', 's');

clc

figure(2)
imshow(image1)